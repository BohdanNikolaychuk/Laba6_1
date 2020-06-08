using System;
using System.Collections.Generic;
using System.Text;

namespace Laba6_1
{
   public class Cars : Interface1
    {
        public string mark { get; set; }
        public int numbers { get; set; }
        public string colors { get; set; }
        public string owner { get; set; }


        public void carss(List<Cars> cars)
        {
            foreach (Cars car in cars)
            {
                Console.WriteLine("\tMark: {0}\tNumbers: {1}\tColors: {2}\tOwner: {3}",car.mark,car.numbers,car.colors,car.owner);
            }
        }

        public void sortcars(List<Cars> cars)
        {

           

            Console.WriteLine("Задайте колір і марку машини,щоб отримати дані про власника");


            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();

            foreach (Cars c in cars)
            {
                if (c.colors == s1 && c.mark == s2)
                {
                    Console.Write("\t" + "Owner");
                    Console.WriteLine("\t" + c.owner);
                }

            }
        }
        


    }
}
