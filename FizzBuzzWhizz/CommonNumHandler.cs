using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzWhizz
{
    internal class CommonNumHandler : NumHandler
    {
        public CommonNumHandler(NumHandler successor)
            : base(successor)
        {
        }

        public override string Translate(int num)
        {
            return num.ToString();
        }
    }
}