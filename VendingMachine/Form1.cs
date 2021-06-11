using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VendingMachineModel;
/*
 * Vending Machine Form
 * Created by Brian Chaves
 * Created on June 09,2021
 * Updateed on June 10, 2021
*/

namespace VendingMachineForm
{
    public partial class Form1 : Form
    {
        const int COIN_START_X = 13;
        const int COIN_X_DIFF = 120;
        const int COIN_Y = 35;
        const int DRINK_X = 13;
        const int DRINK_START_Y = 169;
        const int DRINK_Y_DIFF = 40;

        VendingMachine vendingMachine;
        List<CoinLayoutGroup> coinLayoutGroupList;
        List<DrinkLayoutGroup> drinkLayoutGroupList;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Test");
            vendingMachine = new VendingMachine();
            coinLayoutGroupList = new List<CoinLayoutGroup>();
            drinkLayoutGroupList = new List<DrinkLayoutGroup>();

            vendingMachine.Coins.Add(new Coin("Penny", "Pennies", 1, 10));
            vendingMachine.Coins.Add(new Coin("Nickel", "Nickels", 5, 5));
            vendingMachine.Coins.Add(new Coin("Dime", "Dimes", 10, 100));
            vendingMachine.Coins.Add(new Coin("Quarter", "Quarters", 25, 25));

            vendingMachine.Drinks.Add(new Drink("Coke", 25, 5));
            vendingMachine.Drinks.Add(new Drink("Pepsi", 36, 15));
            vendingMachine.Drinks.Add(new Drink("Soda", 45, 3));

            

            //foreach(Coin coin in vendingMachine.Coins)
            for(int i=0;i<vendingMachine.Coins.Count;i++)
            { 
                Coin coin = vendingMachine.Coins[i];
                coinLayoutGroupList.Add(new CoinLayoutGroup(COIN_START_X+COIN_X_DIFF*i, COIN_Y, this, coin));
            }

            for(int i=0;i<vendingMachine.Drinks.Count;i++)
            {
                Drink drink = vendingMachine.Drinks[i];
                drinkLayoutGroupList.Add(new DrinkLayoutGroup(DRINK_X, DRINK_START_Y+DRINK_Y_DIFF*i, this, drink));
            }
            
        }

        private void btnGetDrinks_Click(object sender, EventArgs e)
        {
            int totalValue = 0;
            try
            {
                foreach (CoinLayoutGroup coinLayoutGroup in coinLayoutGroupList)
                {
                    int coinValue = coinLayoutGroup.Coin.CoinValue;
                    int quanity = int.Parse(coinLayoutGroup.TextBox.Text);
                    totalValue += coinValue * quanity;
                }
                Console.WriteLine("Total Value : "+totalValue);

                foreach(DrinkLayoutGroup drinkLayoutGroup in drinkLayoutGroupList)
                {
                    int quanity = int.Parse(drinkLayoutGroup.TextBox.Text);
                    if (drinkLayoutGroup.Drink.Quanity<quanity)
                    {
                        throw new Exception("insufficient supplies in vending machine");
                    }
                    drinkLayoutGroup.Drink.Quanity -= quanity;
                    drinkLayoutGroup.UpdateInfo();
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }

        private void txtCoin0_TextChanged(object sender, EventArgs e)
        {

        }
        private void GenerateCoins()
        {

        }
        private void GenerateDrinks()
        {

        }

        private void txtDrinkQuantity_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
