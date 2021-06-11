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
 * Updateed on June 11, 2021
*/

namespace VendingMachineForm
{
    public partial class FormVendingMachine : Form
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

        public FormVendingMachine()
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

            for(int i=0;i<vendingMachine.Coins.Count;i++)
            { 
                Coin coin = vendingMachine.Coins[i];
                coinLayoutGroupList.Add(new CoinLayoutGroup(COIN_START_X+COIN_X_DIFF*i, COIN_Y, this, coin));
            }

            for(int i=0;i<vendingMachine.Drinks.Count;i++)
            {
                Drink drink = vendingMachine.Drinks[i];
                DrinkLayoutGroup drinkLayoutGroup = new DrinkLayoutGroup(DRINK_X, DRINK_START_Y + DRINK_Y_DIFF * i, this, drink);
                drinkLayoutGroup.TextBoxChange = TextBoxChange;
                drinkLayoutGroupList.Add(drinkLayoutGroup);
                
            }
            UpdateCoinQuantity();
            UpdateDrinkCost();
        }

        private void btnGetDrinks_Click(object sender, EventArgs e)
        {
            int coinValue = 0;
            int drinkValue = 0;
            rtxtOutput.Text = "";
            try
            {
                //Valadation
                foreach (CoinLayoutGroup coinLayoutGroup in coinLayoutGroupList)
                {
                    Coin coin = coinLayoutGroup.Coin;
                    int quanity = int.Parse(coinLayoutGroup.TextBox.Text);
                    if (quanity < 0)
                    {
                        throw new Exception("must be a positive number");
                    }
                    else if(quanity>coin.Quanity)
                    {
                        throw new Exception("Insufficient coins in possesion");
                    }
                    coinValue += coin.CoinValue * quanity;
                }

                foreach(DrinkLayoutGroup drinkLayoutGroup in drinkLayoutGroupList)
                {
                    Drink drink = drinkLayoutGroup.Drink;
                    int quanity = int.Parse(drinkLayoutGroup.TextBox.Text);
                    if (quanity < 0)
                    {
                        throw new Exception("must be a positive number");
                    }
                    if (drink.Quanity<quanity)
                    {
                        throw new Exception("Insufficient supplies in vending machine");
                    }
                    drinkValue += quanity * drink.Price;
                }
                if(drinkValue>coinValue)
                {
                    throw new Exception("Insufficient money");
                }


                
                foreach (CoinLayoutGroup coinLayoutGroup in coinLayoutGroupList)
                {
                    Coin coin = coinLayoutGroup.Coin;
                    int quanity = int.Parse(coinLayoutGroup.TextBox.Text);
                    coin.Quanity -= quanity;
                }
                    foreach (DrinkLayoutGroup drinkLayoutGroup in drinkLayoutGroupList)
                {
                    Drink drink = drinkLayoutGroup.Drink;
                    int quanity = int.Parse(drinkLayoutGroup.TextBox.Text);
                    drink.Quanity -= quanity;
                    drinkLayoutGroup.UpdateInfo();
                }

                int changeValue = coinValue - drinkValue;
                string changeMessage = "";
                for (int i = vendingMachine.Coins.Count-1;i>=0;i--)
                {
                    Coin coin = vendingMachine.Coins[i];
                    int quantity = 0;
                    if(changeValue<coin.CoinValue)
                    {
                        continue;
                    }
                    while(changeValue >= coin.CoinValue)
                    {
                        changeValue -= coin.CoinValue;
                        quantity++;
                    }
                    coin.Quanity += quantity;
                    if(quantity>1)
                    {
                        changeMessage += quantity+" " + coin.PluralName+ "\r\n";
                    }
                    else if(quantity==1)
                    {
                        changeMessage += "1 " + coin.SingluarName + "\r\n";
                    }
                }

                rtxtOutput.Text += "Drinks purchesed\r\n";
                if(changeMessage!="")
                {
                    rtxtOutput.Text += "Change return \r\n" + changeMessage;
                }
            }
            catch(Exception ex)
            {
                rtxtOutput.Text += "ERROR:"+ex.Message + "\r\n";
            }
            UpdateCoinQuantity();
        }
        private void TextBoxChange(object sender, EventArgs e)
        {
            UpdateDrinkCost();
        }
        private void UpdateDrinkCost()
        {
            try
            {
                int drinkValue = 0;
                foreach (DrinkLayoutGroup drinkLayoutGroup in drinkLayoutGroupList)
                {
                    Drink drink = drinkLayoutGroup.Drink;
                    int quanity = int.Parse(drinkLayoutGroup.TextBox.Text);
                    if(quanity<0)
                    {
                        throw new Exception("must be a positive number");
                    }
                    drinkValue += quanity * drink.Price;
                }
                lblOrderTotal.Text = "Cost: " + drinkValue + " cents";
            }
            catch (Exception ex)
            {
                lblOrderTotal.Text = "Enter quantity to see cost";
            }
        }
        private void UpdateCoinQuantity()
        {
            rtxtCoinQuantity.Text = "";
            foreach (Coin coin in vendingMachine.Coins)
            {
                if(coin.Quanity>1)
                {
                    rtxtCoinQuantity.Text += coin.Quanity + " " + coin.PluralName + "\r\n";
                }
                else if(coin.Quanity==1)
                {
                    rtxtCoinQuantity.Text += "1 " + coin.SingluarName + "\r\n";
                }
            }
        }
        private void txtCoin0_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDrinkQuantity_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
