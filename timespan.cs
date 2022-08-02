using System;

namespace timespan
 {
     class DiffTime{

         static void Main(string[] args)
         {
            timespan.Diff.diff();
         }
     }

     class Diff{

        public static void diff()
        {
            DateTime date1 = new DateTime (2022, 08, 5, 11, 11, 11);
            DateTime date2 = new DateTime (2022, 08, 10, 11, 11, 11);
            TimeSpan interval = date2 - date1;  
            Console.WriteLine("Timespan : " + interval);  
        }

     }   
 }        