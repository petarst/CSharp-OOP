

namespace HW3_6.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Range
    {
        

        public static IEnumerable<int> LambdaExpressionResult(IEnumerable<int> arr)
        {
            var lambdaResult = arr.Where(n => n % 3 == 0 || n % 7 == 0);
            return lambdaResult;
        }

        public static IEnumerable<int> LinqResult(IEnumerable<int> arr)
        {
            var linqResult =
                from n in arr
                where n % 3 == 0 || n % 7 == 0
                select n;
            return linqResult;
        }


   }

}
