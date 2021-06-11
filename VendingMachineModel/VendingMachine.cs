using System;
using System.Collections;
using System.Collections.Generic;

/*
 * Created by Brian Chaves
 * Created on June 09,2021
 * Updateed on June 10, 2021
*/

namespace VendingMachineModel
{
    public class VendingMachine
    {
        private List<Drink> drinks;
        public List<Drink> Drinks
        {
            get { return drinks; }
            set { drinks = value; }
        }
        private List<Coin> coins;
        public List<Coin> Coins
        {
            get { return coins; }
            set { coins = value; }
        }

        public VendingMachine()
        {
            Drinks = new List<Drink>();
            Coins = new List<Coin>();
        }

    }
}
