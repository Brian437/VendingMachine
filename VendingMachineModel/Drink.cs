using System;
using System.Collections.Generic;
using System.Text;

/*
 * Created by Brian Chaves
 * Created on June 09,2021
 * Updateed on June 10, 2021
*/

namespace VendingMachineModel
{
    public class Drink
    {
        //private int id;
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private int price;
        public int Price
        {
            get { return price; }
            set { price = value; }
        }
        private int quanity;
        public int Quanity
        {
            get { return quanity; }
            set
            {
                if(value<0)
                {
                    throw new Exception("Cannot be a negative number");
                }
                quanity = value;
            }
        }

        public Drink(
            string name,
            int price,
            int quanity=0
        )
        {
            Name = name;
            Price = price;
            Quanity = quanity;
        }
    }
}
