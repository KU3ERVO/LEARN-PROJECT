using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    internal class GameManager
    {
        public int i {get; set;}
        public GameManager()
        {
            this.i = 0;
        }

        public delegate Task EventHandler(int i);

        public event EventHandler? OnStartEvent;

        public async Task num(int i)
        {


            await OnStartEvent?.Invoke(i);


        }
    }
}
