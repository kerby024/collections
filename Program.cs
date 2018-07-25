using System;
using System.Collections.Generic;

namespace collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,string> user = new Dictionary<string,string>();
            user.Add("Tim", null);
            user.Add("Martin", null);
            user.Add("Nikki", null);
            foreach (var entry in user)
            {
                STUCK!!!!!!!!!!!!!!
            }
            
            foreach (var entry in user)
            {
            Console.WriteLine(entry.Key + " - " + entry.Value);
            }
            // Random rand = new Random();
            
            // List<string> icream = new List<string>();
            // icream.Add("Vanilla");
            // icream.Add("Chocolate");
            // icream.Add("Strawberry");
            // icream.Add("Cookie Dough");
            // icream.Add("Oreo");
            // Console.WriteLine(icream.Count);
            // Console.WriteLine(icream[2]);
            // icream.Remove("Strawberry");
            // Console.WriteLine(icream.Count);
            
            // // int[] numArray = {0,1,2,3,4,5,6,7,8,9};
            // // for (int i = 0; i < numArray.Length; i++)
            // // Console.WriteLine(i);

            // string[] stringArray = {"Tim", "Martin", "Nikki"};
            // for (int i = 0; i < stringArray.Length; i++)
            // Console.WriteLine(i);

            // string[] yesno = new string[10];
            // for(int i =0; i <= yesno.Length; i++)
            // {
            //     if(i%2==0)
            //     Console.WriteLine("YES");
            //     else
            //     Console.WriteLine("NO");
            // }

            // int[,] table = new int[11,11];      
            // for (int i = 1; i < 11; i++)         
            //     for (int x = 1; x < 11; x++) 
            //         table[i, x] = i*x;  
            // Console.Write("\n");
            // for (int i = 1; i < 11; i++)
            // {
            // for (int x = 1; x < 11; x++)
            // {
            //     Console.Write(table[i, x].ToString().PadRight(3));
            // }
            // Console.Write("\n");
            // Console.WriteLine("--------------------------------------------");
            // }
        }
        
    }
}
