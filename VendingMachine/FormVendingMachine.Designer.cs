namespace VendingMachineForm
{
    partial class FormVendingMachine
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lblCoin0 = new System.Windows.Forms.Label();
            this.txtCoin0 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDrink0 = new System.Windows.Forms.Label();
            this.lblDrinkInfo0 = new System.Windows.Forms.Label();
            this.txtDrinkQuantity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblOrderTotal = new System.Windows.Forms.Label();
            this.btnGetDrinks = new System.Windows.Forms.Button();
            this.rtxtCoinQuantity = new System.Windows.Forms.RichTextBox();
            this.rtxtOutput = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "COINS INFORMATION";
            // 
            // lblCoin0
            // 
            this.lblCoin0.AutoSize = true;
            this.lblCoin0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoin0.Location = new System.Drawing.Point(13, 37);
            this.lblCoin0.Name = "lblCoin0";
            this.lblCoin0.Size = new System.Drawing.Size(58, 20);
            this.lblCoin0.TabIndex = 1;
            this.lblCoin0.Text = "Penny";
            this.lblCoin0.Visible = false;
            // 
            // txtCoin0
            // 
            this.txtCoin0.Location = new System.Drawing.Point(17, 60);
            this.txtCoin0.Name = "txtCoin0";
            this.txtCoin0.Size = new System.Drawing.Size(100, 20);
            this.txtCoin0.TabIndex = 2;
            this.txtCoin0.Visible = false;
            this.txtCoin0.TextChanged += new System.EventHandler(this.txtCoin0_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(313, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "PRODUCTS INFORMATION";
            // 
            // lblDrink0
            // 
            this.lblDrink0.AutoSize = true;
            this.lblDrink0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDrink0.Location = new System.Drawing.Point(13, 158);
            this.lblDrink0.Name = "lblDrink0";
            this.lblDrink0.Size = new System.Drawing.Size(50, 20);
            this.lblDrink0.TabIndex = 4;
            this.lblDrink0.Text = "Coke";
            this.lblDrink0.Visible = false;
            // 
            // lblDrinkInfo0
            // 
            this.lblDrinkInfo0.AutoSize = true;
            this.lblDrinkInfo0.Location = new System.Drawing.Point(14, 178);
            this.lblDrinkInfo0.Name = "lblDrinkInfo0";
            this.lblDrinkInfo0.Size = new System.Drawing.Size(134, 13);
            this.lblDrinkInfo0.TabIndex = 5;
            this.lblDrinkInfo0.Text = "5 drinks available, Cost=25";
            this.lblDrinkInfo0.Visible = false;
            // 
            // txtDrinkQuantity
            // 
            this.txtDrinkQuantity.Location = new System.Drawing.Point(154, 171);
            this.txtDrinkQuantity.Name = "txtDrinkQuantity";
            this.txtDrinkQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtDrinkQuantity.TabIndex = 6;
            this.txtDrinkQuantity.Visible = false;
            this.txtDrinkQuantity.TextChanged += new System.EventHandler(this.txtDrinkQuantity_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(325, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 26);
            this.label3.TabIndex = 7;
            this.label3.Text = "ORDER TOTAL";
            // 
            // lblOrderTotal
            // 
            this.lblOrderTotal.AutoSize = true;
            this.lblOrderTotal.Location = new System.Drawing.Point(509, 228);
            this.lblOrderTotal.Name = "lblOrderTotal";
            this.lblOrderTotal.Size = new System.Drawing.Size(80, 13);
            this.lblOrderTotal.TabIndex = 8;
            this.lblOrderTotal.Text = "0 Cents/Dollars";
            // 
            // btnGetDrinks
            // 
            this.btnGetDrinks.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetDrinks.Location = new System.Drawing.Point(477, 339);
            this.btnGetDrinks.Name = "btnGetDrinks";
            this.btnGetDrinks.Size = new System.Drawing.Size(160, 38);
            this.btnGetDrinks.TabIndex = 9;
            this.btnGetDrinks.Text = "GET DRINKS";
            this.btnGetDrinks.UseVisualStyleBackColor = true;
            this.btnGetDrinks.Click += new System.EventHandler(this.btnGetDrinks_Click);
            // 
            // rtxtCoinQuantity
            // 
            this.rtxtCoinQuantity.Location = new System.Drawing.Point(13, 383);
            this.rtxtCoinQuantity.Name = "rtxtCoinQuantity";
            this.rtxtCoinQuantity.ReadOnly = true;
            this.rtxtCoinQuantity.Size = new System.Drawing.Size(135, 96);
            this.rtxtCoinQuantity.TabIndex = 10;
            this.rtxtCoinQuantity.Text = "";
            // 
            // rtxtOutput
            // 
            this.rtxtOutput.Location = new System.Drawing.Point(155, 383);
            this.rtxtOutput.Name = "rtxtOutput";
            this.rtxtOutput.ReadOnly = true;
            this.rtxtOutput.Size = new System.Drawing.Size(482, 96);
            this.rtxtOutput.TabIndex = 11;
            this.rtxtOutput.Text = "";
            // 
            // FormVendingMachine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 489);
            this.Controls.Add(this.rtxtOutput);
            this.Controls.Add(this.rtxtCoinQuantity);
            this.Controls.Add(this.lblCoin0);
            this.Controls.Add(this.txtCoin0);
            this.Controls.Add(this.btnGetDrinks);
            this.Controls.Add(this.lblOrderTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDrinkQuantity);
            this.Controls.Add(this.lblDrinkInfo0);
            this.Controls.Add(this.lblDrink0);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormVendingMachine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCoin0;
        private System.Windows.Forms.TextBox txtCoin0;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDrink0;
        private System.Windows.Forms.Label lblDrinkInfo0;
        private System.Windows.Forms.TextBox txtDrinkQuantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblOrderTotal;
        private System.Windows.Forms.Button btnGetDrinks;
        private System.Windows.Forms.RichTextBox rtxtCoinQuantity;
        private System.Windows.Forms.RichTextBox rtxtOutput;
    }
}

