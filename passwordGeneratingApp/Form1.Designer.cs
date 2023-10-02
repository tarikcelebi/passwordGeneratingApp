namespace passwordGeneratingApp
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
            groupBox1 = new GroupBox();
            listBox1 = new ListBox();
            chcLowerLetter = new CheckBox();
            chcUpperLetter = new CheckBox();
            chcSpecialCharacter = new CheckBox();
            chcNumber = new CheckBox();
            label1 = new Label();
            label2 = new Label();
            btnGenerating = new Button();
            numericPasswordNumber = new NumericUpDown();
            numericPasswordLength = new NumericUpDown();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericPasswordNumber).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericPasswordLength).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(numericPasswordLength);
            groupBox1.Controls.Add(numericPasswordNumber);
            groupBox1.Controls.Add(btnGenerating);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(chcNumber);
            groupBox1.Controls.Add(chcSpecialCharacter);
            groupBox1.Controls.Add(chcUpperLetter);
            groupBox1.Controls.Add(chcLowerLetter);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(321, 398);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "PARAMETRELER";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(327, 10);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(340, 379);
            listBox1.TabIndex = 0;
            // 
            // chcLowerLetter
            // 
            chcLowerLetter.AutoSize = true;
            chcLowerLetter.Location = new Point(105, 54);
            chcLowerLetter.Name = "chcLowerLetter";
            chcLowerLetter.Size = new Size(85, 19);
            chcLowerLetter.TabIndex = 0;
            chcLowerLetter.Text = "Küçük Harf";
            chcLowerLetter.UseVisualStyleBackColor = true;
            // 
            // chcUpperLetter
            // 
            chcUpperLetter.AutoSize = true;
            chcUpperLetter.Location = new Point(19, 104);
            chcUpperLetter.Name = "chcUpperLetter";
            chcUpperLetter.Size = new Size(85, 19);
            chcUpperLetter.TabIndex = 1;
            chcUpperLetter.Text = "Büyük Harf";
            chcUpperLetter.UseVisualStyleBackColor = true;
            // 
            // chcSpecialCharacter
            // 
            chcSpecialCharacter.AutoSize = true;
            chcSpecialCharacter.Location = new Point(105, 152);
            chcSpecialCharacter.Name = "chcSpecialCharacter";
            chcSpecialCharacter.Size = new Size(95, 19);
            chcSpecialCharacter.TabIndex = 2;
            chcSpecialCharacter.Text = "Özel Karakter";
            chcSpecialCharacter.UseVisualStyleBackColor = true;
            // 
            // chcNumber
            // 
            chcNumber.AutoSize = true;
            chcNumber.Location = new Point(19, 204);
            chcNumber.Name = "chcNumber";
            chcNumber.Size = new Size(62, 19);
            chcNumber.TabIndex = 3;
            chcNumber.Text = "Rakam";
            chcNumber.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 265);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 6;
            label1.Text = "Şifre Sayısı : ";

            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 318);
            label2.Name = "label2";
            label2.Size = new Size(90, 15);
            label2.TabIndex = 7;
            label2.Text = "Şifre Uzunluğu :";
            // 
            // btnGenerating
            // 
            btnGenerating.Location = new Point(105, 356);
            btnGenerating.Name = "btnGenerating";
            btnGenerating.Size = new Size(75, 33);
            btnGenerating.TabIndex = 8;
            btnGenerating.Text = "Oluştur";
            btnGenerating.UseVisualStyleBackColor = true;
            btnGenerating.Click += btnGenerating_Click;
            // 
            // numericPasswordNumber
            // 
            numericPasswordNumber.Location = new Point(96, 263);
            numericPasswordNumber.Name = "numericPasswordNumber";
            numericPasswordNumber.Size = new Size(139, 23);
            numericPasswordNumber.TabIndex = 9;
            // 
            // numericPasswordLength
            // 
            numericPasswordLength.Location = new Point(115, 310);
            numericPasswordLength.Name = "numericPasswordLength";
            numericPasswordLength.Size = new Size(143, 23);
            numericPasswordLength.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(679, 401);
            Controls.Add(listBox1);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericPasswordNumber).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericPasswordLength).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private CheckBox chcNumber;
        private CheckBox chcSpecialCharacter;
        private CheckBox chcUpperLetter;
        private CheckBox chcLowerLetter;
        private ListBox listBox1;
        private Button btnGenerating;
        private NumericUpDown numericPasswordLength;
        private NumericUpDown numericPasswordNumber;
    }
}