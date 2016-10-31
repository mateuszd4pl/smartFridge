namespace smartFridge
{
    partial class Form1
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
            this.panelInside = new System.Windows.Forms.Panel();
            this.dataGridViewContent = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnContentMenu = new System.Windows.Forms.Button();
            this.btnAddMenu = new System.Windows.Forms.Button();
            this.btnCookbookMenu = new System.Windows.Forms.Button();
            this.panelCookBook = new System.Windows.Forms.Panel();
            this.deleteAmountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.deleteAmountBtn = new System.Windows.Forms.Button();
            this.deleteUnitLabel = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.deleteNameTxtBox = new System.Windows.Forms.TextBox();
            this.deleteProdCodeTxtBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelAdd = new System.Windows.Forms.Panel();
            this.unitComboBox = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.priceTxtBox = new System.Windows.Forms.TextBox();
            this.amountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.nameTxtBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.codeLbl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.codeTxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelWelcome = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSendSMS = new System.Windows.Forms.Button();
            this.smsTxtBox = new System.Windows.Forms.TextBox();
            this.panelInside.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContent)).BeginInit();
            this.panelCookBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deleteAmountNumericUpDown)).BeginInit();
            this.panelAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amountNumericUpDown)).BeginInit();
            this.panelWelcome.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelInside
            // 
            this.panelInside.Controls.Add(this.dataGridViewContent);
            this.panelInside.Controls.Add(this.label1);
            this.panelInside.Location = new System.Drawing.Point(12, 16);
            this.panelInside.Name = "panelInside";
            this.panelInside.Size = new System.Drawing.Size(299, 285);
            this.panelInside.TabIndex = 0;
            // 
            // dataGridViewContent
            // 
            this.dataGridViewContent.AllowUserToAddRows = false;
            this.dataGridViewContent.AllowUserToDeleteRows = false;
            this.dataGridViewContent.AllowUserToResizeColumns = false;
            this.dataGridViewContent.AllowUserToResizeRows = false;
            this.dataGridViewContent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewContent.Location = new System.Drawing.Point(32, 24);
            this.dataGridViewContent.Name = "dataGridViewContent";
            this.dataGridViewContent.ReadOnly = true;
            this.dataGridViewContent.Size = new System.Drawing.Size(241, 252);
            this.dataGridViewContent.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ZAWARTOŚĆ LODÓWKI";
            // 
            // btnContentMenu
            // 
            this.btnContentMenu.Location = new System.Drawing.Point(85, 307);
            this.btnContentMenu.Name = "btnContentMenu";
            this.btnContentMenu.Size = new System.Drawing.Size(75, 23);
            this.btnContentMenu.TabIndex = 1;
            this.btnContentMenu.Text = "Zawartość";
            this.btnContentMenu.UseVisualStyleBackColor = true;
            this.btnContentMenu.Click += new System.EventHandler(this.btnContent_Click);
            // 
            // btnAddMenu
            // 
            this.btnAddMenu.Location = new System.Drawing.Point(722, 307);
            this.btnAddMenu.Name = "btnAddMenu";
            this.btnAddMenu.Size = new System.Drawing.Size(103, 23);
            this.btnAddMenu.TabIndex = 2;
            this.btnAddMenu.Text = "Dodaj produkt";
            this.btnAddMenu.UseVisualStyleBackColor = true;
            this.btnAddMenu.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCookbookMenu
            // 
            this.btnCookbookMenu.Location = new System.Drawing.Point(403, 307);
            this.btnCookbookMenu.Name = "btnCookbookMenu";
            this.btnCookbookMenu.Size = new System.Drawing.Size(91, 23);
            this.btnCookbookMenu.TabIndex = 3;
            this.btnCookbookMenu.Text = "Usuń produkt";
            this.btnCookbookMenu.UseVisualStyleBackColor = true;
            this.btnCookbookMenu.Click += new System.EventHandler(this.btnCookbook_Click);
            // 
            // panelCookBook
            // 
            this.panelCookBook.Controls.Add(this.deleteAmountNumericUpDown);
            this.panelCookBook.Controls.Add(this.deleteAmountBtn);
            this.panelCookBook.Controls.Add(this.deleteUnitLabel);
            this.panelCookBook.Controls.Add(this.label14);
            this.panelCookBook.Controls.Add(this.btnDeleteProduct);
            this.panelCookBook.Controls.Add(this.deleteNameTxtBox);
            this.panelCookBook.Controls.Add(this.deleteProdCodeTxtBox);
            this.panelCookBook.Controls.Add(this.label12);
            this.panelCookBook.Controls.Add(this.label11);
            this.panelCookBook.Controls.Add(this.label9);
            this.panelCookBook.Controls.Add(this.label3);
            this.panelCookBook.Location = new System.Drawing.Point(317, 16);
            this.panelCookBook.Name = "panelCookBook";
            this.panelCookBook.Size = new System.Drawing.Size(299, 285);
            this.panelCookBook.TabIndex = 4;
            // 
            // deleteAmountNumericUpDown
            // 
            this.deleteAmountNumericUpDown.Location = new System.Drawing.Point(110, 169);
            this.deleteAmountNumericUpDown.Name = "deleteAmountNumericUpDown";
            this.deleteAmountNumericUpDown.Size = new System.Drawing.Size(144, 20);
            this.deleteAmountNumericUpDown.TabIndex = 27;
            // 
            // deleteAmountBtn
            // 
            this.deleteAmountBtn.Location = new System.Drawing.Point(110, 223);
            this.deleteAmountBtn.Name = "deleteAmountBtn";
            this.deleteAmountBtn.Size = new System.Drawing.Size(144, 23);
            this.deleteAmountBtn.TabIndex = 25;
            this.deleteAmountBtn.Text = "Zmień ilość";
            this.deleteAmountBtn.UseVisualStyleBackColor = true;
            this.deleteAmountBtn.Click += new System.EventHandler(this.deleteAmountBtn_Click);
            // 
            // deleteUnitLabel
            // 
            this.deleteUnitLabel.AutoSize = true;
            this.deleteUnitLabel.Location = new System.Drawing.Point(107, 198);
            this.deleteUnitLabel.Name = "deleteUnitLabel";
            this.deleteUnitLabel.Size = new System.Drawing.Size(13, 13);
            this.deleteUnitLabel.TabIndex = 24;
            this.deleteUnitLabel.Text = "[]";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(22, 196);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 13);
            this.label14.TabIndex = 21;
            this.label14.Text = "Jednostka:";
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Location = new System.Drawing.Point(110, 121);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(144, 23);
            this.btnDeleteProduct.TabIndex = 19;
            this.btnDeleteProduct.Text = "Usuń produkt";
            this.btnDeleteProduct.UseVisualStyleBackColor = true;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // deleteNameTxtBox
            // 
            this.deleteNameTxtBox.Location = new System.Drawing.Point(110, 85);
            this.deleteNameTxtBox.Name = "deleteNameTxtBox";
            this.deleteNameTxtBox.Size = new System.Drawing.Size(144, 20);
            this.deleteNameTxtBox.TabIndex = 22;
            // 
            // deleteProdCodeTxtBox
            // 
            this.deleteProdCodeTxtBox.Location = new System.Drawing.Point(110, 38);
            this.deleteProdCodeTxtBox.Name = "deleteProdCodeTxtBox";
            this.deleteProdCodeTxtBox.Size = new System.Drawing.Size(144, 20);
            this.deleteProdCodeTxtBox.TabIndex = 21;
            this.deleteProdCodeTxtBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.deleteProdCodeTxtBox_KeyDown);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(22, 173);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = "Ilość:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(22, 88);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Nazwa:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Wprowadź kod:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(103, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "USUŃ PRODUKT";
            // 
            // panelAdd
            // 
            this.panelAdd.Controls.Add(this.unitComboBox);
            this.panelAdd.Controls.Add(this.label13);
            this.panelAdd.Controls.Add(this.btnAddProduct);
            this.panelAdd.Controls.Add(this.priceTxtBox);
            this.panelAdd.Controls.Add(this.amountNumericUpDown);
            this.panelAdd.Controls.Add(this.nameTxtBox);
            this.panelAdd.Controls.Add(this.label10);
            this.panelAdd.Controls.Add(this.label8);
            this.panelAdd.Controls.Add(this.label7);
            this.panelAdd.Controls.Add(this.codeLbl);
            this.panelAdd.Controls.Add(this.label6);
            this.panelAdd.Controls.Add(this.label5);
            this.panelAdd.Controls.Add(this.codeTxtBox);
            this.panelAdd.Controls.Add(this.label2);
            this.panelAdd.Location = new System.Drawing.Point(622, 16);
            this.panelAdd.Name = "panelAdd";
            this.panelAdd.Size = new System.Drawing.Size(299, 285);
            this.panelAdd.TabIndex = 5;
            // 
            // unitComboBox
            // 
            this.unitComboBox.FormattingEnabled = true;
            this.unitComboBox.Items.AddRange(new object[] {
            "sztuk(a)",
            "dekagram",
            "mililitr"});
            this.unitComboBox.Location = new System.Drawing.Point(103, 220);
            this.unitComboBox.Name = "unitComboBox";
            this.unitComboBox.Size = new System.Drawing.Size(120, 21);
            this.unitComboBox.TabIndex = 20;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(15, 223);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 13);
            this.label13.TabIndex = 19;
            this.label13.Text = "Jednostka:";
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(74, 253);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(157, 23);
            this.btnAddProduct.TabIndex = 18;
            this.btnAddProduct.Text = "Dodaj";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // priceTxtBox
            // 
            this.priceTxtBox.Location = new System.Drawing.Point(103, 166);
            this.priceTxtBox.Name = "priceTxtBox";
            this.priceTxtBox.Size = new System.Drawing.Size(100, 20);
            this.priceTxtBox.TabIndex = 17;
            // 
            // amountNumericUpDown
            // 
            this.amountNumericUpDown.Location = new System.Drawing.Point(103, 196);
            this.amountNumericUpDown.Name = "amountNumericUpDown";
            this.amountNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.amountNumericUpDown.TabIndex = 16;
            // 
            // nameTxtBox
            // 
            this.nameTxtBox.Location = new System.Drawing.Point(103, 138);
            this.nameTxtBox.Name = "nameTxtBox";
            this.nameTxtBox.Size = new System.Drawing.Size(100, 20);
            this.nameTxtBox.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 198);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Ilość:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 169);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Cena:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Nazwa:";
            // 
            // codeLbl
            // 
            this.codeLbl.AutoSize = true;
            this.codeLbl.Location = new System.Drawing.Point(71, 101);
            this.codeLbl.Name = "codeLbl";
            this.codeLbl.Size = new System.Drawing.Size(154, 13);
            this.codeLbl.TabIndex = 4;
            this.codeLbl.Text = ".................................................";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(71, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Kod zeskanowanego produktu:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Wprowadź kod:";
            // 
            // codeTxtBox
            // 
            this.codeTxtBox.Location = new System.Drawing.Point(109, 42);
            this.codeTxtBox.Name = "codeTxtBox";
            this.codeTxtBox.Size = new System.Drawing.Size(188, 20);
            this.codeTxtBox.TabIndex = 1;
            this.codeTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.codeTxtBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.codeTxtBox_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "DODAJ PRODUKT";
            // 
            // panelWelcome
            // 
            this.panelWelcome.Controls.Add(this.smsTxtBox);
            this.panelWelcome.Controls.Add(this.btnSendSMS);
            this.panelWelcome.Controls.Add(this.label4);
            this.panelWelcome.Location = new System.Drawing.Point(12, 336);
            this.panelWelcome.Name = "panelWelcome";
            this.panelWelcome.Size = new System.Drawing.Size(909, 100);
            this.panelWelcome.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(497, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "WELCOME";
            // 
            // btnSendSMS
            // 
            this.btnSendSMS.Location = new System.Drawing.Point(311, 44);
            this.btnSendSMS.Name = "btnSendSMS";
            this.btnSendSMS.Size = new System.Drawing.Size(75, 23);
            this.btnSendSMS.TabIndex = 1;
            this.btnSendSMS.Text = "Wyślij SMS";
            this.btnSendSMS.UseVisualStyleBackColor = true;
            this.btnSendSMS.Click += new System.EventHandler(this.btnSendSMS_Click);
            // 
            // smsTxtBox
            // 
            this.smsTxtBox.Location = new System.Drawing.Point(32, 18);
            this.smsTxtBox.Multiline = true;
            this.smsTxtBox.Name = "smsTxtBox";
            this.smsTxtBox.Size = new System.Drawing.Size(253, 71);
            this.smsTxtBox.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 448);
            this.Controls.Add(this.panelWelcome);
            this.Controls.Add(this.panelAdd);
            this.Controls.Add(this.panelCookBook);
            this.Controls.Add(this.btnCookbookMenu);
            this.Controls.Add(this.btnAddMenu);
            this.Controls.Add(this.btnContentMenu);
            this.Controls.Add(this.panelInside);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Smart Fridge";
            this.panelInside.ResumeLayout(false);
            this.panelInside.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContent)).EndInit();
            this.panelCookBook.ResumeLayout(false);
            this.panelCookBook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deleteAmountNumericUpDown)).EndInit();
            this.panelAdd.ResumeLayout(false);
            this.panelAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amountNumericUpDown)).EndInit();
            this.panelWelcome.ResumeLayout(false);
            this.panelWelcome.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelInside;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnContentMenu;
        private System.Windows.Forms.Button btnAddMenu;
        private System.Windows.Forms.Button btnCookbookMenu;
        private System.Windows.Forms.Panel panelCookBook;
        private System.Windows.Forms.Panel panelAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelWelcome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox codeTxtBox;
        private System.Windows.Forms.Label codeLbl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox nameTxtBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown amountNumericUpDown;
        private System.Windows.Forms.TextBox priceTxtBox;
        private System.Windows.Forms.DataGridView dataGridViewContent;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.TextBox deleteNameTxtBox;
        private System.Windows.Forms.TextBox deleteProdCodeTxtBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox unitComboBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label deleteUnitLabel;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button deleteAmountBtn;
        private System.Windows.Forms.NumericUpDown deleteAmountNumericUpDown;
        private System.Windows.Forms.TextBox smsTxtBox;
        private System.Windows.Forms.Button btnSendSMS;
    }
}

