using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{
    internal class SaveClass
    {
        public void Save(string[] data)
        {
            File.WriteAllLines("save.txt", data);
        }
        public string Load()
        {
            return File.ReadAllText("save.txt");
        }
    }
}
