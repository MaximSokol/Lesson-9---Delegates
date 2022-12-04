using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_9__Delegates_.Task_2
{
    public delegate int Addition(int a, int b);
    public delegate int Substraction(int a, int b);
    public delegate int Multiplication(int a, int b);
    public delegate int Division(int a, int b);
    //-----------------------------------------------------------------

    public static class LambdaOperations
    {   
        private static int oneField;
        private static int twoField;
        private static int threeField;
        private static int fourthField;
        //------------------------------------------------------

        static LambdaOperations()
        {
            oneField = 0;
            twoField = 0;
            threeField = 0;
            fourthField = 0;
        }
        //------------------------------------------------------

        public static void CallLambdaOperations(int a, int b)
        {
           Addition add = (int a1, int b1) => { return a1 + b1; };
            oneField = add(a, b);
            Console.WriteLine("Add:\t" + oneField);
            //--------------------------------------------------------------

            Division div = (int a2, int b2) =>
            { if (b2 != 0) return a2 / b2;
                else return -1;
            };

            twoField = div(a, b);
            Console.WriteLine("Div:\t" + twoField);
            //--------------------------------------------------------------

            Multiplication mult = (int a3, int b3) => { return a3 * b3; };
            threeField = mult(a, b);
            Console.WriteLine("Mult:\t" + threeField);
            //--------------------------------------------------------------

            Substraction sub = (int a4, int b4) => { return a4 - b4; };
            fourthField = sub(a, b);
            Console.WriteLine("Sub:\t" + fourthField);
            //--------------------------------------------------------------
        }
        //------------------------------------------------------
    }
}
