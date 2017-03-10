using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace TSVtoJSON
{
    class Program
    {
        static void Main(string[] args)
        {
            string in_path = "C:\\myGitProjects\\doChangeDataAnalysis\\ourWorkspace\\dev_Daniel\\ParseJSON\\TSVtoJSON\\data_heatmap.txt";
            string out_path = "C:\\myGitProjects\\doChangeDataAnalysis\\ourWorkspace\\dev_Daniel\\ParseJSON\\TSVtoJSON\\data_heatmap.json";

            string hcrow = "49, 11, 30, 4, 18, 6, 12, 20, 19, 33, 32, 26, 44, 35, 38, 3, 23, 41, 22, 10, 2, 15, 16, 36, 8, 25, 29, 7, 27, 34, 48, 31, 45, 43, 14, 9, 39, 1, 37, 47, 42, 21, 40, 5, 28, 46, 50, 17, 24, 13";
            string hccol = "6, 5, 41, 12, 42, 21, 58, 56, 14, 16, 43, 15, 17, 46, 47, 48, 54, 49, 37, 38, 25, 22, 7, 8, 2, 45, 9, 20, 24, 44, 23, 19, 13, 40, 11, 1, 39, 53, 10, 52, 3, 26, 27, 60, 50, 51, 59, 18, 31, 32, 30, 4, 55, 28, 29, 57, 36, 34, 33, 35";

            var a = hcrow.Split(',');
            var b = hccol.Split(',');

            List<int> ta = new List<int>();
            a.ToList().ForEach(x => ta.Add((Convert.ToInt16(x))));
            List<int> tb = new List<int>();
            b.ToList().ForEach(x => tb.Add((Convert.ToInt16(x))));

            ta.Sort();
            tb.Sort();




            //var a = TSVtoJSON(in_path, out_path);

            Console.WriteLine();
        }

        static bool TSVtoJSON(string in_path, string out_path)
        {
            string hcrow = "49, 11, 30, 4, 18, 6, 12, 20, 19, 33, 32, 26, 44, 35, 38, 3, 23, 41, 22, 10, 2, 15, 16, 36, 8, 25, 29, 7, 27, 34, 48, 31, 45, 43, 14, 9, 39, 1, 37, 47, 42, 21, 40, 5, 28, 46, 50, 17, 24, 13]";
            string hccol = "6, 5, 41, 12, 42, 21, 58, 56, 14, 16, 43, 15, 17, 46, 47, 48, 54, 49, 37, 38, 25, 22, 7, 8, 2, 45, 9, 20, 24, 44, 23, 19, 13, 40, 11, 1, 39, 53, 10, 52, 3, 26, 27, 60, 50, 51, 59, 18, 31, 32, 30, 4, 55, 28, 29, 57, 36, 34, 33, 35";
            string rowLabel = "'1759080_s_at', '1759302_s_at', '1759502_s_at', '1759540_s_at', '1759781_s_at', '1759828_s_at', '1759829_s_at', '1759906_s_at', '1760088_s_at', '1760164_s_at', '1760453_s_at', '1760516_s_at', '1760594_s_at', '1760894_s_at', '1760951_s_at', '1761030_s_at', '1761128_at', '1761145_s_at', '1761160_s_at', '1761189_s_at', '1761222_s_at', '1761245_s_at', '1761277_s_at', '1761434_s_at', '1761553_s_at', '1761620_s_at', '1761873_s_at', '1761884_s_at', '1761944_s_at', '1762105_s_at', '1762118_s_at', '1762151_s_at', '1762388_s_at', '1762401_s_at', '1762633_s_at', '1762701_s_at', '1762787_s_at', '1762819_s_at', '1762880_s_at', '1762945_s_at', '1762983_s_at', '1763132_s_at', '1763138_s_at', '1763146_s_at', '1763198_s_at', '1763383_at', '1763410_s_at', '1763426_s_at', '1763490_s_at', '1763491_s_at'";
            string colLabel = "'con1027', 'con1028', 'con1029', 'con103', 'con1030', 'con1031', 'con1032', 'con1033', 'con1034', 'con1035', 'con1036', 'con1037', 'con1038', 'con1039', 'con1040', 'con1041', 'con108', 'con109', 'con110', 'con111', 'con112', 'con125', 'con126', 'con127', 'con128', 'con129', 'con130', 'con131', 'con132', 'con133', 'con134', 'con135', 'con136', 'con137', 'con138', 'con139', 'con14', 'con15', 'con150', 'con151', 'con152', 'con153', 'con16', 'con17', 'con174', 'con184', 'con185', 'con186', 'con187', 'con188', 'con189', 'con191', 'con192', 'con193', 'con194', 'con199', 'con2', 'con200', 'con201', 'con21'";

            var a = hcrow.Split(',');
            var b = hccol.Split(',');
            var c = rowLabel.Split(',');
            var d = colLabel.Split(',');

            bool status = false;

            try
            {
                var lines = File.ReadAllLines(in_path);
                string[] header = lines[0].Split('\t');
                //lines = lines.Skip(1).ToList().ForEach(x => litems.Add(new Item(x.Split('\t'))));

                List<Item> litems = new List<Item>();

                var flines = lines.Skip(1).ToList();

                foreach(string s in flines)
                {
                    var lin = s.Split('\t');
                    litems.Add(new Item(lin,
                                        c[Convert.ToInt16(lin[0]) - 1],
                                        d[Convert.ToInt16(lin[1]) - 1]
                                        ));
                }


                JsonSerializer serializer = new JsonSerializer();
                using (StreamWriter sw = new StreamWriter(out_path))
                using (JsonWriter writer = new JsonTextWriter(sw))
                    serializer.Serialize(writer, litems);
                //litems.ForEach(x => serializer.Serialize(writer, x));

                status = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return status;
        }
    }

    public class Item
    {
        public int row_idx { get; set; }
        public int col_idx { get; set; }
        public int log2ratio { get; set; }
        public string rowLabel { get; set; }
        public string colLabel { get; set; }

        public Item(string[] vars, string rowLabel, string colLabel)
        {
            this.row_idx = Convert.ToInt16(vars[0]);
            this.col_idx = Convert.ToInt16(vars[1]);
            this.log2ratio = Convert.ToInt16(vars[2]);
            this.rowLabel = rowLabel.Substring(1, rowLabel.Length - 2);
            this.colLabel = colLabel.Substring(1, colLabel.Length - 2);
        }

        public Item(string[] vars)
        {

            this.row_idx = Convert.ToInt16(vars[0]);
            this.col_idx = Convert.ToInt16(vars[1]);
            this.log2ratio = Convert.ToInt16(vars[2]);
        }
    }
}
