
namespace PrintPayment_WinForm
{
    partial class PrintPaymentForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.usernameRadioButton = new System.Windows.Forms.RadioButton();
            this.uidRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.moneyInput = new System.Windows.Forms.TextBox();
            this.getUserButton = new System.Windows.Forms.Button();
            this.nbSheetsInputDisplay = new System.Windows.Forms.TextBox();
            this.creditInputDisplay = new System.Windows.Forms.TextBox();
            this.usernameInputDisplay = new System.Windows.Forms.TextBox();
            this.uidInputDisplay = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.transferMoneyButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.userInput = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.updatePriceButton = new System.Windows.Forms.Button();
            this.pricePerSheetInput = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // usernameRadioButton
            // 
            this.usernameRadioButton.AutoSize = true;
            this.usernameRadioButton.Location = new System.Drawing.Point(22, 43);
            this.usernameRadioButton.Name = "usernameRadioButton";
            this.usernameRadioButton.Size = new System.Drawing.Size(108, 24);
            this.usernameRadioButton.TabIndex = 1;
            this.usernameRadioButton.TabStop = true;
            this.usernameRadioButton.Text = "Username";
            this.usernameRadioButton.UseVisualStyleBackColor = true;
            // 
            // uidRadioButton
            // 
            this.uidRadioButton.AutoSize = true;
            this.uidRadioButton.Location = new System.Drawing.Point(212, 43);
            this.uidRadioButton.Name = "uidRadioButton";
            this.uidRadioButton.Size = new System.Drawing.Size(63, 24);
            this.uidRadioButton.TabIndex = 2;
            this.uidRadioButton.TabStop = true;
            this.uidRadioButton.Text = "UID";
            this.uidRadioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.moneyInput);
            this.groupBox1.Controls.Add(this.getUserButton);
            this.groupBox1.Controls.Add(this.nbSheetsInputDisplay);
            this.groupBox1.Controls.Add(this.creditInputDisplay);
            this.groupBox1.Controls.Add(this.usernameInputDisplay);
            this.groupBox1.Controls.Add(this.uidInputDisplay);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.transferMoneyButton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.userInput);
            this.groupBox1.Controls.Add(this.usernameRadioButton);
            this.groupBox1.Controls.Add(this.uidRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(27, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(429, 455);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Money";
            // 
            // moneyInput
            // 
            this.moneyInput.Location = new System.Drawing.Point(212, 132);
            this.moneyInput.Name = "moneyInput";
            this.moneyInput.Size = new System.Drawing.Size(164, 26);
            this.moneyInput.TabIndex = 15;
            // 
            // getUserButton
            // 
            this.getUserButton.Location = new System.Drawing.Point(22, 189);
            this.getUserButton.Name = "getUserButton";
            this.getUserButton.Size = new System.Drawing.Size(99, 45);
            this.getUserButton.TabIndex = 5;
            this.getUserButton.Text = "GET";
            this.getUserButton.UseVisualStyleBackColor = true;
            this.getUserButton.Click += new System.EventHandler(this.getUserButton_Click);
            // 
            // nbSheetsInputDisplay
            // 
            this.nbSheetsInputDisplay.Location = new System.Drawing.Point(212, 388);
            this.nbSheetsInputDisplay.Name = "nbSheetsInputDisplay";
            this.nbSheetsInputDisplay.Size = new System.Drawing.Size(100, 26);
            this.nbSheetsInputDisplay.TabIndex = 14;
            // 
            // creditInputDisplay
            // 
            this.creditInputDisplay.Location = new System.Drawing.Point(212, 349);
            this.creditInputDisplay.Name = "creditInputDisplay";
            this.creditInputDisplay.Size = new System.Drawing.Size(100, 26);
            this.creditInputDisplay.TabIndex = 13;
            // 
            // usernameInputDisplay
            // 
            this.usernameInputDisplay.Location = new System.Drawing.Point(212, 309);
            this.usernameInputDisplay.Name = "usernameInputDisplay";
            this.usernameInputDisplay.Size = new System.Drawing.Size(100, 26);
            this.usernameInputDisplay.TabIndex = 12;
            // 
            // uidInputDisplay
            // 
            this.uidInputDisplay.Location = new System.Drawing.Point(212, 269);
            this.uidInputDisplay.Name = "uidInputDisplay";
            this.uidInputDisplay.Size = new System.Drawing.Size(100, 26);
            this.uidInputDisplay.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 389);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Nb Sheets";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 349);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Credit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "UID";
            // 
            // transferMoneyButton
            // 
            this.transferMoneyButton.Location = new System.Drawing.Point(212, 189);
            this.transferMoneyButton.Name = "transferMoneyButton";
            this.transferMoneyButton.Size = new System.Drawing.Size(189, 45);
            this.transferMoneyButton.TabIndex = 6;
            this.transferMoneyButton.Text = "TRANSFER MONEY";
            this.transferMoneyButton.UseVisualStyleBackColor = true;
            this.transferMoneyButton.Click += new System.EventHandler(this.transferMoney_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Username / UID";
            // 
            // userInput
            // 
            this.userInput.Location = new System.Drawing.Point(212, 91);
            this.userInput.Name = "userInput";
            this.userInput.Size = new System.Drawing.Size(164, 26);
            this.userInput.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.updatePriceButton);
            this.groupBox2.Controls.Add(this.pricePerSheetInput);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(502, 42);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(390, 445);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Conversion";
            // 
            // updatePriceButton
            // 
            this.updatePriceButton.Location = new System.Drawing.Point(22, 80);
            this.updatePriceButton.Name = "updatePriceButton";
            this.updatePriceButton.Size = new System.Drawing.Size(154, 45);
            this.updatePriceButton.TabIndex = 15;
            this.updatePriceButton.Text = "UPDATE PRICE";
            this.updatePriceButton.UseVisualStyleBackColor = true;
            this.updatePriceButton.Click += new System.EventHandler(this.updatePrice_Click);
            // 
            // pricePerSheetInput
            // 
            this.pricePerSheetInput.Location = new System.Drawing.Point(188, 32);
            this.pricePerSheetInput.Name = "pricePerSheetInput";
            this.pricePerSheetInput.Size = new System.Drawing.Size(100, 26);
            this.pricePerSheetInput.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Price per sheet";
            // 
            // PrintPaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 522);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "PrintPaymentForm";
            this.Text = "Print-Payment";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton usernameRadioButton;
        private System.Windows.Forms.RadioButton uidRadioButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox userInput;
        private System.Windows.Forms.TextBox nbSheetsInputDisplay;
        private System.Windows.Forms.TextBox creditInputDisplay;
        private System.Windows.Forms.TextBox usernameInputDisplay;
        private System.Windows.Forms.TextBox uidInputDisplay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button transferMoneyButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox pricePerSheetInput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button getUserButton;
        private System.Windows.Forms.Button updatePriceButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox moneyInput;
    }
}

