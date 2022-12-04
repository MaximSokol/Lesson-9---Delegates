using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson_9__Delegates_.Additional_Task;
using Lesson_9__Delegates_.Task_2;
using Lesson_9__Delegates_.Task_3;

namespace Lesson_9__Delegates_
{
    class Program
    {
        static void Main(string[] args)
        {
            // Additional Task
            int a = 10, b = 50, res;
            int result = ClassDelegate.Avg(ref a, ref b, out res);
            Console.WriteLine("Result of Average:\t" + result);

            // Task 2
            LambdaOperations.CallLambdaOperations(10, 5);

            // Task 3
            var arrayDel = new ArrayOfDelegates(3);
            arrayDel.GetAverage();
        }
    }
}
