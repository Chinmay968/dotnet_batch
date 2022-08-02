using System;

namespace timespan
 {
     class DiffTime{

         static void Main(string[] args)
         {
            DateTime date1 = new DateTime (2022, 08, 5, 11, 11, 11);
            DateTime date2 = new DateTime (2022, 08, 10, 11, 11, 11);
            timespan.Diff.diff(date1,date2);
         }
     }

     class Diff{

        public static void diff(DateTime t1,DateTime t2)
        {
        
            TimeSpan interval = t2 - t1;  
            Console.WriteLine("Timespan : " + interval);  
        }

     }   
 }        