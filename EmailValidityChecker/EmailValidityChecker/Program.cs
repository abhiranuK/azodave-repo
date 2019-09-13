using EmailValidityChecker.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailValidityChecker
{
    class Program
    {
        public static void Main(string[] args)
        {
            string input = String.Empty;
            string result = String.Empty;
            input = Console.ReadLine();


            IFinalResult _Result = new FinalResult();
            result = _Result.ReturnFinalResult(input);

            Console.WriteLine(result);
            Console.ReadLine();
            

        }
    }
}
