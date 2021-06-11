using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachineModel;
using System.Windows.Forms;

/*
 * Created by Brian Chaves
 * Created on June 10,2021
 * Updateed on June 10, 2021
*/

namespace VendingMachineForm
{
    public class CoinLayoutGroup : FormLayoutGroup
    {
        private Coin coin;
        public Coin Coin
        {
            get { return coin; }
            set { coin = value; }
        }

        private Label label;
        public Label Label
        {
            get { return label; }
        }

        private TextBox textBox;
        public TextBox TextBox
        {
            get { return textBox; }
        }

        public override void GenerateItems()
        {
            label = new System.Windows.Forms.Label();
            label.AutoSize = true;
            label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label.Name = "lblCoin0";
            label.Size = new System.Drawing.Size(58, 20);
            label.TabIndex = 1;
            label.Text = Coin.PluralName;
            Form.Controls.Add(label);

            textBox = new TextBox();
            textBox.Name = "txtCoin0";
            textBox.Size = new System.Drawing.Size(100, 20);
            textBox.TabIndex = 2;
            textBox.TextChanged += new EventHandler(this.TextBoxChange);
            textBox.Text = "0";
            Form.Controls.Add(textBox);

            UpdateLayout();
        }

        public void TextBoxChange(object sender, EventArgs e)
        {

        }

        public override void UpdateInfo()
        {
            throw new NotImplementedException();
        }

        public override void UpdateLayout()
        {
            label.Location = new System.Drawing.Point(X, Y);
            textBox.Location = new System.Drawing.Point(X, Y + 23);
        }

        public override void ResetForm()
        {
            textBox.Text = "0";
        }

        public CoinLayoutGroup(
            int x, 
            int y,
            Form form,
            Coin coin
        ){
            this.x = x;
            this.y = y;
            Form = form;
            Coin = coin;
            GenerateItems();
        }
    }
}
