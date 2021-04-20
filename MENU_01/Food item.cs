using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace MENU_01
{
    /* comment in this class
     * desscribe it
     */
    public class Food_item
    {
        // adds foodname and price as a object
        private object foodname;
        private object price;

        public string Foodname {get; set;}
        public int Price { get; set; }

        public Food_item( string foodname, int price )
        {
           
            Foodname = foodname;
            Price = price;
            
        }

        public Food_item(object foodname, object price)
        {
            this.foodname = foodname;
            this.price = price;
        }

        public override string ToString()
        {
            return $"{Foodname},{Price}";
        }
        public void Print()
        {
            Console.WriteLine("the total: ",Foodname, Price);
            

        }
        
    }
}
