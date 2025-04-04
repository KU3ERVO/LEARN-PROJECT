using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    internal class Async
    {

        public async Task Delay() {

            Console.WriteLine("START");
            await Task.Delay(1000);
            Console.WriteLine("STOP");
        
        }

    }
}
