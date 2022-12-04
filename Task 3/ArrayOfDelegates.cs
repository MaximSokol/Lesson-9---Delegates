using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_9__Delegates_.Task_3
{
    public delegate int Arr(Elements []arr);
    public delegate int Elements();
    //------------------------------------------

    class ArrayOfDelegates
    {
        Arr instase;
        Elements []elements;
        //--------------------------------------

        public ArrayOfDelegates()
        {
            instase = null;
            elements = null;
        }
        //--------------------------------------

        public ArrayOfDelegates(int size)
        {
            elements = new Elements[size];
        }
        //--------------------------------------

        public static int GetRandom()
        {
            return new Random().Next(50);
        }
        //--------------------------------------

        public void GetAverage()
        {
            for (int i = 0; i < elements.Length; i++)
            {
                elements[i] = () => new Elements(GetRandom).Invoke();
            }

            instase = delegate (Elements[] elem)
            {
                int avg = default(int); 
                for (int i = 0; i < elem.Length; i++)
                {
                    avg += elem[i].Invoke();
                }
                return avg / elem.Length;
            };

            for (int i = 0; i < elements.Length; i++)
            {
                Console.WriteLine(elements[i]());
            }
            Console.WriteLine(instase(elements));
        }
    }
}
