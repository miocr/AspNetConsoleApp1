using System;
using System.Configuration;
using System.Runtime;


namespace AspNetConsoleApp1
{

    public class Model1
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string keyName = "Counter";
            string keyNameDate = "Date";
            string keyNameTicks = "DateTicks";

            long ticks;
            long.TryParse(ConfigurationManager.AppSettings[keyNameTicks], out ticks);
            DateTime dateTicks = new DateTime(ticks);

            DateTime date;
            DateTime.TryParse(ConfigurationManager.AppSettings[keyNameDate], out date);

            int valueInt;
            int.TryParse(ConfigurationManager.AppSettings[keyName], out valueInt);
            valueInt++;

            string file = System.Reflection.Assembly.GetEntryAssembly().Location;
            Configuration config = ConfigurationManager.OpenExeConfiguration(file);

            DateTime now = DateTime.Now;
            config.AppSettings.Settings.Add(keyNameTicks, now.Ticks.ToString());
            config.AppSettings.Settings.Add(keyNameDate, now.ToString("O"));
            config.AppSettings.Settings.Add(keyName, valueInt.ToString());

            config.Save(ConfigurationSaveMode.Minimal);
            ConfigurationManager.RefreshSection("appSettings");

        }
    }
}
