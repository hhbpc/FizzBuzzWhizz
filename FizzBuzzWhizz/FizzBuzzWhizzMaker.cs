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
            set
            {
                if ((value < 1) || (value > 9))
                {
                    throw new ArgumentOutOfRangeException("fizz", "fizz should be non-negative and less than 10");
                }

                if ((value == buzz) || (value == whizz))
                {
                    throw new ArgumentException("the same value with fizz already exists", "fizz");
                }

                fizz = value;
            }
        }

        public int Buzz
        {
            get { return buzz; }
            set
            {
                if ((value < 1) || (value > 9))
                {
                    throw new ArgumentOutOfRangeException("buzz", "buzz should be non-negative and less than 10");
                }

                if ((value == fizz) || (value == whizz))
                {
                    throw new ArgumentException("the same value with buzz already exists", "buzz");
                }

                buzz = value;
            }
        }

        public int Whizz
        {
            get { return whizz; }
            set
            {
                if ((value < 1) || (value > 9))
                {
                    throw new ArgumentOutOfRangeException("whizz", "whizz should be non-negative and less than 10");
                }

                if ((value == fizz) || (value == buzz))
                {
                    throw new ArgumentException("the same value with whizz already exists", "whizz");
                }

                whizz = value;
            }
        }

        public FizzBuzzWhizzMaker(int fizz, int buzz, int whizz)
        {
            Fizz = fizz;
            Buzz = buzz;
            Whizz = whizz;
        }

        public const string FizzStr = "Fizz";
        public const string BuzzStr = "Buzz";
        public const string WhizzStr = "Whizz";

        public string Translate(int num)
        {
            if (num % (fizz * buzz * whizz) == 0)
            {
                return FizzStr + BuzzStr + WhizzStr;
            }

            if (num % fizz == 0)
            {
                return FizzStr;
            }

            if (num % buzz == 0)
            {
                return BuzzStr;
            }

            if (num % whizz == 0)
            {
                return WhizzStr;
            }

            return num.ToString();
        }
    }
}