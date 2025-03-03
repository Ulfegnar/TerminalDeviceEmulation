using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace TestUU
{
    public static class JSON
    {
        private static string _fileName = "Settings.json";
        public static ControlDevice Read()
        {
            ControlDevice controlDevice;
             FileStream fs = new FileStream(_fileName, FileMode.OpenOrCreate);
            try
            {
                controlDevice = JsonSerializer.DeserializeAsync<ControlDevice>(fs).GetAwaiter().GetResult();                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                controlDevice = new ControlDevice("0.0.0.0", 62305, "0.0.0.0", 62304, 62306, 
                    Enums.NotificationStatus.Unknown, new List<bool>(), new List<bool>(), false);
            }
            fs.Close();
            return controlDevice;
        }

        public static async Task Write(ControlDevice controlDevice)
        {
            if (File.Exists(_fileName)) { File.Delete(_fileName); }

             FileStream fs = new FileStream(_fileName, FileMode.OpenOrCreate);
            try
            {
                await JsonSerializer.SerializeAsync<ControlDevice>(fs, controlDevice);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            fs.Close();
        }
    }
}
