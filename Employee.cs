using System;

namespace Employee
{
    class Emp
    {
        static void Main(String[] args)
        {
            
            string[] name = {"Sam" , "John" , "Max" , "Joy"};
            string[] add = {"USA" , "UAE" , "CAL" , "IND"};

            Employee.EmpData.empdata( name, add);
                    
        }
    }

    class EmpData
    {
        public static void empdata (string[] name,string[] add)
        {
            
            for (int i=0; i<name.Length; i++)
            {
               
               Console.WriteLine("Employee Name: " +name[i]);
                Console.WriteLine("Address: " +add[i]);

            }        
        }    
    }
}