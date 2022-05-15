namespace string_handling
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
            this.txtboxInput = new System.Windows.Forms.TextBox();
            this.btnCharacters = new System.Windows.Forms.Button();
            this.btnPalindrome = new System.Windows.Forms.Button();
            this.btnWords = new System.Windows.Forms.Button();
            this.btnReverse = new System.Windows.Forms.Button();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.btnASCII = new System.Windows.Forms.Button();
            this.btnLetter = new System.Windows.Forms.Button();
            this.btnEachline = new System.Windows.Forms.Button();
            this.BtnWarning = new System.Windows.Forms.Button();
            this.richOutput = new System.Windows.Forms.RichTextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtboxInput
            // 
            this.txtboxInput.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtboxInput.Location = new System.Drawing.Point(351, 70);
            this.txtboxInput.Name = "txtboxInput";
            this.txtboxInput.PlaceholderText = "Type here";
            this.txtboxInput.Size = new System.Drawing.Size(230, 36);
            this.txtboxInput.TabIndex = 0;
            this.txtboxInput.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnCharacters
            // 
            this.btnCharacters.Location = new System.Drawing.Point(49, 139);
            this.btnCharacters.Name = "btnCharacters";
            this.btnCharacters.Size = new System.Drawing.Size(123, 39);
            this.btnCharacters.TabIndex = 1;
            this.btnCharacters.Text = "Count characters";
            this.btnCharacters.UseVisualStyleBackColor = true;
            this.btnCharacters.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPalindrome
            // 
            this.btnPalindrome.Location = new System.Drawing.Point(218, 139);
            this.btnPalindrome.Name = "btnPalindrome";
            this.btnPalindrome.Size = new System.Drawing.Size(123, 39);
            this.btnPalindrome.TabIndex = 2;
            this.btnPalindrome.Text = "palindrome?";
            this.btnPalindrome.UseVisualStyleBackColor = true;
            this.btnPalindrome.Click += new System.EventHandler(this.btnPalindrome_Click);
            // 
            // btnWords
            // 
            this.btnWords.Location = new System.Drawing.Point(382, 139);
            this.btnWords.Name = "btnWords";
            this.btnWords.Size = new System.Drawing.Size(123, 39);
            this.btnWords.TabIndex = 3;
            this.btnWords.Text = "Count words";
            this.btnWords.UseVisualStyleBackColor = true;
            this.btnWords.Click += new System.EventHandler(this.btnWords_Click);
            // 
            // btnReverse
            // 
            this.btnReverse.Location = new System.Drawing.Point(548, 139);
            this.btnReverse.Name = "btnReverse";
            this.btnReverse.Size = new System.Drawing.Size(123, 39);
            this.btnReverse.TabIndex = 4;
            this.btnReverse.Text = "Reverse Words";
            this.btnReverse.UseVisualStyleBackColor = true;
            this.btnReverse.Click += new System.EventHandler(this.btnReverse_Click);
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(716, 139);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(123, 39);
            this.btnEncrypt.TabIndex = 5;
            this.btnEncrypt.Text = "Encrypt text";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(49, 220);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(123, 39);
            this.btnDecrypt.TabIndex = 6;
            this.btnDecrypt.Text = "Decrypt text";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // btnASCII
            // 
            this.btnASCII.Location = new System.Drawing.Point(218, 220);
            this.btnASCII.Name = "btnASCII";
            this.btnASCII.Size = new System.Drawing.Size(123, 39);
            this.btnASCII.TabIndex = 7;
            this.btnASCII.Text = "letters to numbers";
            this.btnASCII.UseVisualStyleBackColor = true;
            this.btnASCII.Click += new System.EventHandler(this.btnASCII_Click);
            // 
            // btnLetter
            // 
            this.btnLetter.Location = new System.Drawing.Point(382, 220);
            this.btnLetter.Name = "btnLetter";
            this.btnLetter.Size = new System.Drawing.Size(123, 39);
            this.btnLetter.TabIndex = 8;
            this.btnLetter.Text = "A number to letter";
            this.btnLetter.UseVisualStyleBackColor = true;
            this.btnLetter.Click += new System.EventHandler(this.btnLetter_Click);
            // 
            // btnEachline
            // 
            this.btnEachline.Location = new System.Drawing.Point(548, 220);
            this.btnEachline.Name = "btnEachline";
            this.btnEachline.Size = new System.Drawing.Size(123, 39);
            this.btnEachline.TabIndex = 9;
            this.btnEachline.Text = "Letters on each line";
            this.btnEachline.UseVisualStyleBackColor = true;
            this.btnEachline.Click += new System.EventHandler(this.btnEachline_Click);
            // 
            // BtnWarning
            // 
            this.BtnWarning.Location = new System.Drawing.Point(716, 220);
            this.BtnWarning.Name = "BtnWarning";
            this.BtnWarning.Size = new System.Drawing.Size(123, 39);
            this.BtnWarning.TabIndex = 10;
            this.BtnWarning.Text = "Do Not Press!";
            this.BtnWarning.UseVisualStyleBackColor = true;
            this.BtnWarning.Click += new System.EventHandler(this.BtnWarning_Click);
            // 
            // richOutput
            // 
            this.richOutput.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.richOutput.Location = new System.Drawing.Point(193, 288);
            this.richOutput.Name = "richOutput";
            this.richOutput.Size = new System.Drawing.Size(517, 140);
            this.richOutput.TabIndex = 11;
            this.richOutput.Text = "";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl1.Location = new System.Drawing.Point(393, 21);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(162, 30);
            this.lbl1.TabIndex = 12;
            this.lbl1.Text = "String Handling";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 450);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.richOutput);
            this.Controls.Add(this.BtnWarning);
            this.Controls.Add(this.btnEachline);
            this.Controls.Add(this.btnLetter);
            this.Controls.Add(this.btnASCII);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.btnReverse);
            this.Controls.Add(this.btnWords);
            this.Controls.Add(this.btnPalindrome);
            this.Controls.Add(this.btnCharacters);
            this.Controls.Add(this.txtboxInput);
            this.Name = "Form1";
            this.Text = "String handling";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtboxInput;
        private Button btnCharacters;
        private Button btnPalindrome;
        private Button btnWords;
        private Button btnReverse;
        private Button btnEncrypt;
        private Button btnDecrypt;
        private Button btnASCII;
        private Button btnLetter;
        private Button btnEachline;
        private Button BtnWarning;
        private RichTextBox richOutput;
        private Label lbl1;
    }
}