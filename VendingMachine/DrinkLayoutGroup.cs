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
 * Updateed on June 11, 2021
*/

namespace VendingMachineForm
{
    public class DrinkLayoutGroup : FormLayoutGroup
    {
        private Drink drink;
        public Drink Drink
        {
            get { return drink; }
            set 
            { 
                drink = value;
                UpdateInfo();
            }
        }
        private Label mainLabel;
        public Label MainLabel
        {
            get { return mainLabel; }
        }
        private Label info;
        public Label Info
        {
            get { return info; }
        }
        private TextBox textBox;
        public TextBox TextBox
        {
            get { return textBox; }
        }

        private EventHandler textBoxChange;
        public EventHandler TextBoxChange
        {
            get { return textBoxChange; }
            set { textBoxChange = value; }
        }

        public override void GenerateItems()
        {

            mainLabel = new System.Windows.Forms.Label();
            mainLabel.AutoSize = true;
            mainLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            
            mainLabel.Name = "lblDrink0";
            mainLabel.Size = new System.Drawing.Size(50, 20);
            mainLabel.TabIndex = 4;
            mainLabel.Text = Drink.Name;
            Form.Controls.Add(mainLabel);

            info = new System.Windows.Forms.Label();
            info.AutoSize = true;
            
            info.Name = "lblDrinkInfo0";
            info.Size = new System.Drawing.Size(134, 13);
            info.TabIndex = 5;
            
            Form.Controls.Add(info);

            textBox = new System.Windows.Forms.TextBox();
            
            textBox.Name = "txtDrinkQuantity";
            textBox.Size = new System.Drawing.Size(100, 20);
            textBox.TabIndex = 6;
            textBox.TextChanged += new System.EventHandler(this.TextChanged);
            textBox.Text = "0";
            Form.Controls.Add(textBox);

            UpdateLayout();
            UpdateInfo();
        }
        private void TextChanged(object sender, EventArgs e)
        {
            if(TextBoxChange!=null)
            {
                TextBoxChange(sender, e);
            }
        }

        public override void UpdateInfo()
        {
            if(info!=null)
            {
                info.Text = Drink.Quanity + " drinks available, Cost=" + Drink.Price;
            }
        }

        public override void UpdateLayout()
        {
            mainLabel.Location = new System.Drawing.Point(X, Y);
            info.Location = new System.Drawing.Point(X, Y + 20);
            textBox.Location = new System.Drawing.Point(x + 141, y + 13);
        }

        public override void ResetForm()
        {
            textBox.Text = "0";
        }

        public DrinkLayoutGroup(
            int x,
            int y,
            Form form,
            Drink drink)
        {
            this.x = x;
            this.y = y;
            Form = form;
            Drink = drink;
            GenerateItems();
        }
    }
}
