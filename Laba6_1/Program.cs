using System;
using System.Text;
using System.Collections.Generic;

namespace Laba6_1
{
    class Program 
    {
        static void Main(string[] args)
        {

            var cars = new List<Cars>()
            {



            new Cars { mark = "bmw", numbers = 123123, colors = "red", owner = "Glek" },
            new Cars { mark = "audi", numbers = 123123, colors = "blue", owner = "Petro" },
            new Cars { mark = "bmw", numbers = 123123, colors = "red", owner = "Glek" },
            new Cars { mark = "audi", numbers = 123123, colors = "blue", owner = "Glek" },
            new Cars { mark = "bmw", numbers = 123123, colors = "red", owner = "Vasya" },
            new Cars { mark = "audi", numbers = 123123, colors = "blue", owner = "Glek" },

            };

            Cars d = new Cars();
            d.carss(cars);
            d.sortcars(cars);
      


           

        }
        

    }
    
}
