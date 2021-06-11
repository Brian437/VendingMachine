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
    public class Coin
    {
        private string singluarName;
        public string SingluarName
        {
            get
            {
                return singluarName;
            }
            set
            {
                singluarName = value;
            }
        }
        private string pluralName;
        public string PluralName
        {
            get
            {
                return pluralName;
            }
            set
            {
                pluralName = value;
            }
        }

        private int coinValue;
        public int CoinValue
        {
            get { return coinValue; }
            set
            {
                if (value<0)
                {
                    throw new Exception("Cannot be a negative number");
                }
                coinValue = value;
            }
        }
        private int quanity;
        public int Quanity
        {
            get { return quanity; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Cannot be a negative number");
                }
                quanity = value;
            }
        }
        public Coin(
            string singluarName,
            string pluralName,
            int coinValue,
            int quanity=0
        ){
            SingluarName = singluarName;
            PluralName = pluralName;
            CoinValue = coinValue;
            Quanity = quanity;
        }
    }
}
