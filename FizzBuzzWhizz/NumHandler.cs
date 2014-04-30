using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzWhizz
{
    internal abstract class NumHandler
    {
        protected NumHandler Successor;

        protected NumHandler(NumHandler successor)
        {
            Successor = successor;
        }

        public abstract string Translate(int num);
    }
}