using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Client
{
    public static class DictionaryExtension
    {
        public static void DictionaryWithButtonEnableManagement(this Dictionary<string, bool> dictionary,
            object value, string key, Button button)
        {
            if (value is TextBox)
            {
                dictionary[key] = !string.IsNullOrEmpty((value as TextBox).Text);
            }

            if (value is ComboBox)
            {
                dictionary[key] = !((value as ComboBox).SelectedIndex.Equals(-1));
            }

            button.Enabled = dictionary.All(m => m.Value.Equals(true));
        }

        public static void AddWithKey(this Dictionary<Guid, List<Guid>> dictionary, Guid key, Guid value)
        {
            if (dictionary.ContainsKey(key))
            {
                dictionary[key].Add(value);
            }
            else
            {
                dictionary.Add(key, new List<Guid>() { value });
            }
        }
    }
}
