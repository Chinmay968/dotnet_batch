using System;
using System.Collections;

namespace LargestNo
{
    class Operations
    {
        static void Main(String[] args)
        {
            LargestNo.Array.arr();
           //LargestNo.ArrayList.arraylist();
           //LargestNo.linkedList.linkedlist();
        }    
    }
    class Array
    {
        public static void arr()
        {
            int[] arr = {5,2,7,1,8,6,9,3,4};
            int largest()
            {
                int i;
                int max = arr[0];
                for (i = 1; i < arr.Length; i++)
                {
                    if(arr[i] > max)
                    {
                        max = arr[i];
                    }
                    return max;
                }
            
            Console.WriteLine("Largets Number is" +largest());
            }
        }
    }    
     
    /*class ArrayList
    {
        public static void arraylist()
        {
            ArrayList<int> arlist = new ArrayList<int> {5,2,7,1,8,6,9,3,4};
        }
    }
    class linkedList
    {
        public static void linkedlist()
        {
            LinkedList<int> my_list = new LinkedList<int> {5,2,7,1,8,6,9,3,4};
        }
    }*/
}    
