using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HW1Version2.Library;

namespace HW1Version2
{
    class Test
    {
        static void Main(string[] args)
        {
            var gsm = new GSMClass("Experia", "Sony", 123.45m, "Evstati");

            Console.WriteLine(gsm);

         gsm.CallHistory.Add(new Call() { Duration=10000, DialedPhone = "00000000" });
         
         for (int i = 0; i < 10; i++)
         {
             gsm.AddCall (new Call()
                 
                 {
                 DialedPhone= "0000" + i,
                 Duration= (uint)(i+1)*120
                 
                 });
          }
          var maxCall = new Call();
          
          foreach (Call call in gsm.CallHistory)
          {
              Console.WriteLine(call);
              if (maxCall.Duration< call.Duration)
               {
                   maxCall = call;
               }
           }

            Console.WriteLine(gsm.CalculateTotalCost(0.40m));

            gsm.DeleteCall(maxCall);

            Console.WriteLine(gsm.CalculateTotalCost(0.40m));


        }
    }
}
