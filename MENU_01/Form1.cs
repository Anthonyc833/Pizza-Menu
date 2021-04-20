using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MENU_01
{
    public partial class Form1 : Form
    {
        // this sorts the array of food items in the form1 class

        public Food_item[] items = new Food_item[10];
        //below is where the exception occurs
        Order order = new Order();
        // this gets the order formula in the order class
        private Comparison PrinterManager = new Comparison("Menu.txt");




        public Form1()
        {
            InitializeComponent();
        }

        public topping_types GetTopping()
        {
            // this sets the topping types enumerators
            if (PizzaC.CheckedItems.Contains("Magerita"))
            {
                return topping_types.Magerita;
            }
            else if (PizzaC.CheckedItems.Contains("Supreme"))
            {
                return topping_types.Supreme;
            }
            return topping_types.Meatlovers;
        }

        public crust_types GetCrust()
        {
            // sets the get crust enumerator and put into a method
            if (Crust.CheckedItems.Contains("Thin"))
            {
                return crust_types.thin;
            }
            return crust_types.thick;
        }

        public size_types GetSize()
        {
            if (Size.CheckedItems.Contains("Small"))
            {
                return size_types.small;
            }
            else if (Size.CheckedItems.Contains("Medium"))
            {
                return size_types.medium;

            }
            return size_types.Large;

        }

        private void Check1()
        {
            


        }




        // food array//
        private Food_item[] food = new Food_item[]
        {
            new Food_item("Magerita",20),
            new Food_item("Supreme", 25),
            new Food_item("Meatlovers", 19),
            new Food_item("Spaghetti", 20),
            new Food_item("lobster", 60),
            new Food_item("Coke", 7),
            new Food_item("Sprite", 5),
            new Food_item("Cake", 5),
            new Food_item("Browine", 5)
        };

        public void Check2()
        {
            // sets the pizzaorder thats in the previous methods
            listBox1.Items.Clear();
            Pizza pizzaorder = new Pizza(GetTopping(), GetCrust(), GetSize(), GetTopping().ToString() + "Pizza", 15);
            order.Selecteditems.Add(pizzaorder);

            //this setting the methods in a string form and checks if it has been ticked if the string contains the foodname
            if (MAINCOURSE.CheckedItems.Contains("Spaghetti"))
            {
                Food_item Rorder = new Food_item("Spaghetti", 25);
                order.Selecteditems.Add(Rorder);

            }
            if (MAINCOURSE.CheckedItems.Contains("Lobster"))
            {
                Food_item Rorder = new Food_item("Lobster", 60);
                order.Selecteditems.Add(Rorder);
            }
            if (Beverage.CheckedItems.Contains("Coke"))
            {
                Food_item Rorder = new Food_item("Coke", 7);
                order.Selecteditems.Add(Rorder);

            }
            if (Beverage.CheckedItems.Contains("Sprite"))
            {
                Food_item Rorder = new Food_item("Sprite", 5);
                order.Selecteditems.Add(Rorder);

            }
            if (Desert.CheckedItems.Contains("Browine"))
            {
                Food_item Rorder = new Food_item("Brownie", 5);
                order.Selecteditems.Add(Rorder);
            }
            if (Desert.CheckedItems.Contains("Cake"))
            {
                Food_item Rorder = new Food_item("Cake", 15);
                order.Selecteditems.Add(Rorder);
            }

            // setting the regular orders in a array
            listBox1.Items.AddRange(order.Selecteditems.ToArray());

        }
        private void Pizza(object sender, EventArgs e)
        {
            // adds pizza topping part to the menu
            PizzaC.Items.Add("Magerita");
            PizzaC.Items.Add("Supreme");
            PizzaC.Items.Add("Meatlovers");

        }

        private void PIZZA_Crust(object sender, EventArgs e)
        {
            // adds the size to the menu
            Crust.Items.Add("Thin");
            Crust.Items.Add("Thick");
        }

        private void PIZZA_SIZE(object sender, EventArgs e)
        {
            Size.Items.Add("Small");
            Size.Items.Add("Medium");
            Size.Items.Add("Large");

        }

        public void MainCourse(object sender, EventArgs e)
        {
            // adds the main courses in the main course 
            MAINCOURSE.Items.Add("Spaghetti");
            MAINCOURSE.Items.Add("Lobster");

        }

        private void COLDONES(object sender, EventArgs e)
        {
            // adds the beverage menu to the check list box
            Beverage.Items.Add("Coke");
            Beverage.Items.Add("Sprite");
        }
        public void printing()
        {
            // sets the printing for when it outputs to the text file
            foreach(Food_item food in order.Selecteditems)
            {
                if (food != null)
                {
                    Console.WriteLine(food);

                    
                }
                else
                {
                    Console.WriteLine("nothing here");
                }
            }
           
            // prints out the cost to the output
            Console.WriteLine(order.cost());
            



        }

        public void Piza_button_Click(object sender, EventArgs e)
        {
            // prints the output
            PrinterManager.Write(order);
            // goes to the printing process
            printing();




        }


        private void PlaceO(object sender, EventArgs e)
        {
            // goes to the check to check2 method
            Check2();
        }

        private void DesertC(object sender, EventArgs e)
        {
            // displays the desert checklistbox
            Desert.Items.Add("Browine");
            Desert.Items.Add("Cake");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }




    }
}
