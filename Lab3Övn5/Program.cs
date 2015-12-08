using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Övn5
{
    class Program
    {
        static void Main(string[] args)
        {
            int myInt;
            myInt = 0;
           
            //int result; 

            Program program = new Program();
            //program.Add(ref myInt);
            ////program.Multiply(myInt);
            //Console.WriteLine(myInt);

            //program.Add(5,10, out result);
            //Console.WriteLine(result);

            //program.Multiply(5,10, out result);
            //Console.WriteLine(result);
            //int number = 5;
            //string answer;
            //program.PosOrNeg(number, out answer);
            //Console.WriteLine(answer);

            //program.ParamArray("ettan", "tvåan", "trean", "fyran", "femman", "sexan", "sjuan");

            program.MyRecursiveMethod(ref myInt);
           
        
          
           Console.ReadLine();
        }

        public void Add(ref int myInt)
        {
            myInt += 10;
        }

        public void Multiply( int myInt)
        {
            myInt *= 10;
        }

        public void Add(int operand1, int operand2, out int result)
        {
            result = operand1 + operand2;
        }

        public void Multiply(int operand1, int operand2, out int result)
        {
            result = operand1 * operand2;
        }

        public void PosOrNeg (int nr,out string answer)
        {
            if (nr < 0)
            {
                answer = "Talet är negativt";
            }
            else if (nr > 0)
            {
                answer = "Talet är positivt";
            }
            else
            {
                answer = "Talet är 0";
            }
        }

        void ParamArray(params string[] strings)
        {
            foreach(string str in strings)
            {
                Console.WriteLine(str);
            }
        }
        void MyRecursiveMethod(ref int myInt)
        {
            Console.WriteLine(myInt);
            myInt++;
            if (myInt < 10)
            {
                MyRecursiveMethod(ref myInt);
            }
            Console.WriteLine(myInt);
        }

   }
}
