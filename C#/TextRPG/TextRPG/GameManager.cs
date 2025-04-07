using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TextRPG
{
    internal class GameManager
    {
        public GameManager() { }

        public void Save(string [] data) 
        {
            File.WriteAllLines("save.txt",data);
        }
        public string Load() 
        {
           return File.ReadAllText("save.txt");
        }
    }
}
