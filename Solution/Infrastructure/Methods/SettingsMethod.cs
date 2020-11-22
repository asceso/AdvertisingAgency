using System;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
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
                if (ex.Message.Contains("Microsoft.ACE.OLEDB.12.0"))
                {
                    if (MessageBoxImplementation.AskMessageBox(
                        "Для работы приложения необходимо установить поставщика данных." +
                        "\r\nУстановить сейчас?"))
                    {
                        string dbAccessPath = Environment.CurrentDirectory + "\\AccessDatabaseEngine";
                        dbAccessPath += Environment.Is64BitOperatingSystem ? "_X64.exe" : ".exe";
                        Process dbSetup = new Process();
                        dbSetup.StartInfo.FileName = dbAccessPath;
                        dbSetup.Start();
                        dbSetup.WaitForExit();
                    }
                    else
                    {
                        Environment.Exit(-1);
                    }
                }
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
                    Environment.Exit(-1);
                }
                if (MessageBoxImplementation.AskMessageBox("База данных требует пароля?"))
                {
                    InputBox input = new InputBox();
                    input.ShowDialog();
                    settings.Password = input.InputValue;
                    SetConfig(settings);
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
