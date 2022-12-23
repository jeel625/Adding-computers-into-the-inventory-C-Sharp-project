using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainProject
{
    internal class Computer
    {
        public const string password = "password";
        public string brand;
        public string model;
        public int sn;
        public double price;

        public Computer(string brand, string model, int sn, double price)
        {
            this.brand = brand;
            this.model = model;
            this.sn = sn;
            this.price = price;
        }
        public string getBrand()
        {
            return this.brand;
        }
        public void setBrand(string s)
        {
            this.brand = s;
        }
        public string getModel()
        {
            return this.brand;
        }
        public void setModel(string m)
        {
            this.model = m;
        }
        public int getSn()
        {
            return this.sn;
        }
        public void setSn(int si)
        {
            if (this.sn > 0)
            {
                this.sn = si;
            }
            else
            {
                Console.WriteLine("cant be negative");
            }
        }
        public double getPrice()
        {
            return this.price;
        }
        public void setPrice(int p)
        {
            if (this.price > 0)
            {
                this.price = p;
            }
            else
            {
                Console.WriteLine("cant be negative");
            }
        }
        public void showComputer(int index)
        {
            string str = "";
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("| The computer index is :" + (index)+str.PadRight(10)+"|");
            Console.WriteLine("| the brand is :" + this.brand+ str.PadRight(17) + "|");
            Console.WriteLine("| the model is :" + this.model+ str.PadRight(17) + "|");
            Console.WriteLine("| the sn is :" + this.sn+ str.PadRight(20) + "|");
            Console.WriteLine("| the price is :" + this.price+ str.PadRight(19) + "|");
            Console.WriteLine("-------------------------------------");
        }
        public void showComputer()
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine("| the brand is :" + this.brand+" |");
            Console.WriteLine("| the model is :" + this.model+" |");
            Console.WriteLine("| the sn is :" + this.sn+" |");
            Console.WriteLine("| the price is :" + this.price+" |");
            Console.WriteLine("----------------------------------");
        }
    }
}

