using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{
    internal class Item
    {
        public string name {  get; private set; }
        public Item(string name) 
        {
            this.name = name;  
        }
    }
}
