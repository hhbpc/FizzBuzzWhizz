using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzWhizz
{
    public class FizzBuzzWhizzMaker
    {
        private int fizz;

        private int buzz;

        private int whizz;

        public int Fizz
        {
            get { return fizz; }
            set { fizz = value; }
        }

        public int Buzz
        {
            get { return buzz; }
            set { buzz = value; }
        }

        public int Whizz
        {
            get { return whizz; }
            set { whizz = value; }
        }

        public FizzBuzzWhizzMaker(int fizz, int buzz, int whizz)
        {
            this.fizz = fizz;
            this.buzz = buzz;
            this.whizz = whizz;
        }

        public string Translate(int num)
        {
            return num.ToString();
        }
    }
}