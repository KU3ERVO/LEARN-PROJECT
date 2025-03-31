using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercises
{
    internal interface ICharacter
    {
        public int Attack();
        public int Move(int amount);
    }
}
