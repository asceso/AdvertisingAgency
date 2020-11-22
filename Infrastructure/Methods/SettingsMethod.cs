using System;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Windows.Forms;
using Infrastructure.Models;
using Newtonsoft.Json;

namespace Infrastructure.Methods
{
    public static class SettingsMethods
    {
        public static readonly string JsonPath = Environment.CurrentDirectory + "\\AppSettings.json";
        public static SettingsModel ReadConfig()
        {
            string buffer = string.Empty;
            using (StreamReader reader = new StreamReader(JsonPath))
            {
                buffer = reader.ReadToEnd();
            }
            if (buffer.Equals(string.Empty))
            {
                return new SettingsModel();
            }

            SettingsModel settings = JsonConvert.DeserializeObject<SettingsModel>(buffer);
            return settings;
        }

        public static void SetConfig(SettingsModel settings)
        {
            string json = JsonConvert.SerializeObject(settings, Formatting.Indented);
            using StreamWriter writer = new StreamWriter(JsonPath);
            writer.Write(json);
        }

        public static void CheckDatabaseExist(SettingsModel settings)
        {
            OleDbConnection connection = new OleDbConnection(settings.ConnectionString);
            try
            {
                connection.Open();
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("Не удается найти файл"))
                {
                    if (MessageBoxImplementation.AskMessageBox("Файл БД не найден. Перезаписать путь к файлу?"))
                    {
                        OpenFileDialog newPath = new OpenFileDialog
                        {
                            InitialDirectory = Environment.CurrentDirectory,
                            Filter = "Файл базы данных | *.mdb"
                        };
                        if (newPath.ShowDialog().Equals(DialogResult.OK))
                        {
                            settings.DataSource = newPath.FileName;
                            SetConfig(settings);
                        }
                    }
                    else
                    {
                        Application.Exit();
                    }
                }
            }
            finally
            {
                if (connection.State.Equals(ConnectionState.Open))
                {
                    connection.Close();
                }
            }
        }
    }
}
