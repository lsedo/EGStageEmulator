using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace EG_Simulator
{
    internal class StageReader
    {
        private static List<Stage>? stages;
        private static void LoadJson()
        {
            using (StreamReader reader = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + "data\\stages.json"))
            {
                string json = reader.ReadToEnd();
                stages = JsonSerializer.Deserialize<List<Stage>>(json);
            }
        }

        public static List<Stage>? LoadStages()
        {
            LoadJson();

            return stages;
        }
    }
}
