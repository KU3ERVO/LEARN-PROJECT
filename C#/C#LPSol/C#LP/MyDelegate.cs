using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    internal class MyDelegate
    {
        public PrintDelegate printDelegate;
        public MyDelegate() {

            printDelegate += new PrintDelegate(Print);
            printDelegate += new PrintDelegate(Print2);

        }

        public delegate Task PrintDelegate(string s);

        public async Task Print(string s) {
        
            await Task.Delay(5000);
            Console.WriteLine(s);
        
        }

        public async Task Print2(string s)
        {

            await Task.Delay(2005);
            Console.WriteLine("WO");

        }

        public async Task multiply(int i) 
        {
            
            i += 2 * 3 * 6 * 90;

            await Task.Delay(0);
            Console.WriteLine(i);
        
        }
        

    }
}
