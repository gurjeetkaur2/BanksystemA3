namespace BankSystem
{
    partial class transfer_money
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
            comboBoxFrom = new ComboBox();
            comboBoxTo = new ComboBox();
            amountTextBox = new TextBox();
            transferAmountButton = new Button();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            label5 = new Label();
            panel2 = new Panel();
            label6 = new Label();
            label4 = new Label();
            button1 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // comboBoxFrom
            // 
            comboBoxFrom.FormattingEnabled = true;
            comboBoxFrom.Location = new Point(18, 93);
            comboBoxFrom.Name = "comboBoxFrom";
            comboBoxFrom.Size = new Size(182, 33);
            comboBoxFrom.TabIndex = 0;
            // 
            // comboBoxTo
            // 
            comboBoxTo.FormattingEnabled = true;
            comboBoxTo.Location = new Point(22, 89);
            comboBoxTo.Name = "comboBoxTo";
            comboBoxTo.Size = new Size(182, 33);
            comboBoxTo.TabIndex = 1;
            // 
            // amountTextBox
            // 
            amountTextBox.Location = new Point(526, 239);
            amountTextBox.Name = "amountTextBox";
            amountTextBox.Size = new Size(150, 31);
            amountTextBox.TabIndex = 2;
            // 
            // transferAmountButton
            // 
            transferAmountButton.BackColor = Color.CornflowerBlue;
            transferAmountButton.ForeColor = Color.White;
            transferAmountButton.Location = new Point(511, 483);
            transferAmountButton.Name = "transferAmountButton";
            transferAmountButton.Size = new Size(177, 59);
            transferAmountButton.TabIndex = 3;
            transferAmountButton.Text = "Transfer";
            transferAmountButton.UseVisualStyleBackColor = false;
            transferAmountButton.Click += transferAmountButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(526, 182);
            label2.Name = "label2";
            label2.Size = new Size(134, 25);
            label2.TabIndex = 5;
            label2.Text = "Enter Amount ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 174);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 4;
            label1.Text = "label1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 170);
            label3.Name = "label3";
            label3.Size = new Size(62, 25);
            label3.TabIndex = 6;
            label3.Text = "label3";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(comboBoxFrom);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 143);
            panel1.Name = "panel1";
            panel1.Size = new Size(458, 324);
            panel1.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 52);
            label5.Name = "label5";
            label5.Size = new Size(183, 25);
            label5.TabIndex = 5;
            label5.Text = "Select From Account";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(comboBoxTo);
            panel2.Location = new Point(763, 143);
            panel2.Name = "panel2";
            panel2.Size = new Size(436, 318);
            panel2.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(22, 48);
            label6.Name = "label6";
            label6.Size = new Size(159, 25);
            label6.TabIndex = 7;
            label6.Text = "Select To Account";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 41);
            label4.Name = "label4";
            label4.Size = new Size(159, 25);
            label4.TabIndex = 10;
            label4.Text = "Transfer Money - ";
            // 
            // button1
            // 
            button1.Location = new Point(1066, 587);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 11;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // transfer_money
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1243, 663);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(transferAmountButton);
            Controls.Add(amountTextBox);
            Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = Color.CornflowerBlue;
            Name = "transfer_money";
            Text = "transfer_money";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxFrom;
        private ComboBox comboBoxTo;
        private TextBox amountTextBox;
        private Button transferAmountButton;
        private Label label2;
        private Label label1;
        private Label label3;
        private Panel panel1;
        private Label label5;
        private Panel panel2;
        private Label label6;
        private Label label4;
        private Button button1;
    }
}