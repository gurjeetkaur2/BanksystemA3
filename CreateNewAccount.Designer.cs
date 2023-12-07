namespace BankSystem
{
    partial class CreateNewAccount
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
            label1 = new Label();
            label2 = new Label();
            CreateNewAccountButton = new Button();
            comboBox2 = new ComboBox();
            textBox2 = new TextBox();
            label3 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(221, 226);
            label1.Name = "label1";
            label1.Size = new Size(212, 25);
            label1.TabIndex = 0;
            label1.Text = "Enter Name for Account";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(221, 331);
            label2.Name = "label2";
            label2.Size = new Size(301, 25);
            label2.TabIndex = 1;
            label2.Text = "Enter the opening Balance amount";
            // 
            // CreateNewAccountButton
            // 
            CreateNewAccountButton.BackColor = Color.CornflowerBlue;
            CreateNewAccountButton.ForeColor = Color.White;
            CreateNewAccountButton.Location = new Point(404, 444);
            CreateNewAccountButton.Name = "CreateNewAccountButton";
            CreateNewAccountButton.Size = new Size(261, 55);
            CreateNewAccountButton.TabIndex = 2;
            CreateNewAccountButton.Text = "Create New Account";
            CreateNewAccountButton.UseVisualStyleBackColor = false;
            CreateNewAccountButton.Click += CreateNewAccountButton_Click;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(571, 226);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(267, 33);
            comboBox2.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(583, 331);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(267, 31);
            textBox2.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 61);
            label3.Name = "label3";
            label3.Size = new Size(522, 25);
            label3.TabIndex = 5;
            label3.Text = "Create new account in just 2 steps. Fill the information below";
            // 
            // button1
            // 
            button1.Location = new Point(1067, 565);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 6;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // CreateNewAccount
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1243, 663);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(comboBox2);
            Controls.Add(CreateNewAccountButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = Color.CornflowerBlue;
            Name = "CreateNewAccount";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CreateNewAccount";
            Load += CreateNewAccount_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button CreateNewAccountButton;
        private ComboBox comboBox2;
        private TextBox textBox2;
        private Label label3;
        private Button button1;
    }
}