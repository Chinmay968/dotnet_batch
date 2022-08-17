using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Assessment
{
    class RainbowSchool
    {
        public static void Main(String[] args)
        {
            List<string> datalist = new List<string>();
            string path = @"C:\Users\chinmay.daund\Documents\GitHub\dotnet_batch\Data.txt";
            datalist = File.ReadAllLines(path).ToList();
            Console.Write("1.View 2.Insert 3.Update 4.Delete \nENter your choice number: ");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                Assessment.View.Vew(datalist,path);
                break;

                case 2:
                Assessment.Insert.Ins(datalist,path);
                break;

                case 3:
                Assessment.Update.Upd(datalist,path);
                break;

                case 4:
                Assessment.Delete.Del(datalist,path);
                break;
            }
        }
    }

    class View
    {
        public static void Vew( List<string> datalist,string path )
        {
            foreach (String item in datalist)
                    {
                        Console.WriteLine(item);
                    }
        }

    }

    class Insert
    {
        public static void Ins( List<string> datalist,string path )
        {
             Console.Write("Enter all the Data(ID Name class/section): ");
                    string data = Console.ReadLine();
                    datalist.Add(data);
                    File.WriteAllLines(path, datalist); 
                    foreach (String item in datalist)
                    {
                        Console.WriteLine(item);
                    }
                    Console.WriteLine("Data Added Successfully!");
        }
    }

    class Update
    {
        public static void Upd( List<string> datalist,string path )
        {
            Console.Write("Enter the ID number: ");
                    string UpdateId = Console.ReadLine();
                    foreach (String item in datalist)
                    {
                        if (item.Trim().StartsWith(UpdateId))
                        {
                            datalist.Remove(item);
                            Console.Write("Enter a the Data(ID Name class/section): ");
                            string UpdatedData = Console.ReadLine();
                            datalist.Add(UpdatedData);
                            File.WriteAllLines(path, datalist);
                            break;
                        }
                    }

                    foreach (String item in datalist)
                    {
                        Console.WriteLine(item);
                    }
                    Console.WriteLine("Data Updated Successfully!");
        }
    }

    class Delete
    {
        public static void Del(List<string> datalist,string path )
        {
             Console.Write("Enter the ID number: ");
                    string id = Console.ReadLine();
                    foreach (String item in datalist)
                    {
                        if (item.Trim().StartsWith(id))
                        {
                            datalist.Remove(item);
                            File.WriteAllLines(path, datalist);
                            break;
                        }
                    }
                    foreach (String item in datalist)
                    {
                        Console.WriteLine(item);
                    }
                    Console.WriteLine("Data Deleted Successfully!");
        }
    }
   
}