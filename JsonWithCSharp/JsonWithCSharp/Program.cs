using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace JsonWithCSharp
{
    class Program
    {

        static string filename = "\\rows.json";
        static object dataa;

        static void Main(string[] args)
        {
            DeserializeJson();

        }

        public static void DeserializeJson()
        {
            string path = Directory.GetCurrentDirectory() + filename;
            string file = File.ReadAllText(path);
            dataa = JsonConvert.DeserializeObject(file);
            Rootobject ro = JsonConvert.DeserializeObject<Rootobject>(file);
            Console.ReadLine();

        }
    } 
}
