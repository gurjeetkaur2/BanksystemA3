namespace BankSystem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelCustomer = new Label();
            infoLabel = new Label();
            amountTextBox = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            listBox1 = new ListBox();
            label2 = new Label();
            label1 = new Label();
            button4 = new Button();
            button5 = new Button();
            listBox2 = new ListBox();
            button6 = new Button();
            SuspendLayout();
            // 
            // labelCustomer
            // 
            labelCustomer.AutoSize = true;
            labelCustomer.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            labelCustomer.ForeColor = Color.PaleVioletRed;
            labelCustomer.Location = new Point(24, 18);
            labelCustomer.Name = "labelCustomer";
            labelCustomer.Size = new Size(116, 30);
            labelCustomer.TabIndex = 0;
            labelCustomer.Text = "Greeting, ";
            // 
            // infoLabel
            // 
            infoLabel.AutoSize = true;
            infoLabel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            infoLabel.ForeColor = Color.CornflowerBlue;
            infoLabel.Location = new Point(24, 286);
            infoLabel.Name = "infoLabel";
            infoLabel.Size = new Size(158, 28);
            infoLabel.TabIndex = 2;
            infoLabel.Text = "SelectedAccount";
            // 
            // amountTextBox
            // 
            amountTextBox.Location = new Point(911, 62);
            amountTextBox.Name = "amountTextBox";
            amountTextBox.Size = new Size(149, 31);
            amountTextBox.TabIndex = 3;
            amountTextBox.TextChanged += amountTextBox_TextChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.CornflowerBlue;
            button1.Location = new Point(717, 170);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 4;
            button1.Text = "Deposite";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.CornflowerBlue;
            button2.Location = new Point(878, 170);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 5;
            button2.Text = "Withdraw";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.CornflowerBlue;
            button3.Location = new Point(1037, 170);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 6;
            button3.Text = "Interest";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(24, 410);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(819, 204);
            listBox1.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.CornflowerBlue;
            label2.Location = new Point(24, 345);
            label2.Name = "label2";
            label2.Size = new Size(78, 28);
            label2.TabIndex = 8;
            label2.Text = "Details";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.CornflowerBlue;
            label1.Location = new Point(717, 65);
            label1.Name = "label1";
            label1.Size = new Size(149, 28);
            label1.TabIndex = 9;
            label1.Text = "Enter amount- ";
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.CornflowerBlue;
            button4.Location = new Point(957, 316);
            button4.Name = "button4";
            button4.Size = new Size(206, 34);
            button4.TabIndex = 10;
            button4.Text = "Transfer Money";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = Color.CornflowerBlue;
            button5.Location = new Point(957, 377);
            button5.Name = "button5";
            button5.Size = new Size(206, 34);
            button5.TabIndex = 11;
            button5.Text = "Create new account";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 25;
            listBox2.Location = new Point(24, 98);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(519, 129);
            listBox2.TabIndex = 12;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button6.ForeColor = Color.CornflowerBlue;
            button6.Location = new Point(1085, 592);
            button6.Name = "button6";
            button6.Size = new Size(112, 34);
            button6.TabIndex = 13;
            button6.Text = "Back";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1243, 663);
            Controls.Add(button6);
            Controls.Add(listBox2);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(listBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(amountTextBox);
            Controls.Add(infoLabel);
            Controls.Add(labelCustomer);
            Name = "Form1";
            Text = "BankSyatem";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelCustomer;
        private Label infoLabel;
        private TextBox amountTextBox;
        private Button button1;
        private Button button2;
        private Button button3;
        private ListBox listBox1;
        private Label label2;
        private Label label1;
        private Button button4;
        private Button button5;
        private ListBox listBox2;
        private Button button6;
    }
}