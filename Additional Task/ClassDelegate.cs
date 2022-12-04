using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_9__Delegates_.Additional_Task
{
    public delegate int AverageDel(ref int fParam, ref int sParam, out int res);

   public static class ClassDelegate
    {
       public static int Avg(ref int a, ref int b, out int res)
        {
            AverageDel avg = default;
            avg = delegate (ref int a_, ref int b_, out int res_) { return res_ = (a_ + b_) / 2; };
            return avg(ref a, ref b, out res);
        }
    }
}
