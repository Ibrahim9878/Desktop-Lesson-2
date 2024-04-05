namespace WinFormsApp1
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
            ResultBox = new TextBox();
            buttonClear = new Button();
            buttonBackSpace = new Button();
            button1 = new Button();
            buttonFaiz = new Button();
            buttoBolme = new Button();
            buttonVurma = new Button();
            buttonCixma = new Button();
            buttonToplama = new Button();
            buttonBeraber = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button9 = new Button();
            button0 = new Button();
            buttonVergul = new Button();
            buttonChange = new Button();
            SuspendLayout();
            // 
            // ResultBox
            // 
            ResultBox.Font = new Font("Segoe UI", 19F, FontStyle.Regular, GraphicsUnit.Point);
            ResultBox.Location = new Point(-1, 45);
            ResultBox.Name = "ResultBox";
            ResultBox.RightToLeft = RightToLeft.Yes;
            ResultBox.Size = new Size(236, 41);
            ResultBox.TabIndex = 0;
            // 
            // buttonClear
            // 
            buttonClear.BackColor = Color.FromArgb(255, 128, 0);
            buttonClear.ForeColor = SystemColors.ControlText;
            buttonClear.Location = new Point(6, 92);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(41, 37);
            buttonClear.TabIndex = 1;
            buttonClear.Text = "AC";
            buttonClear.UseVisualStyleBackColor = false;
            buttonClear.Click += buttonClear_Click;
            // 
            // buttonBackSpace
            // 
            buttonBackSpace.BackColor = Color.FromArgb(255, 128, 0);
            buttonBackSpace.BackgroundImage = Properties.Resources.left_arrow;
            buttonBackSpace.BackgroundImageLayout = ImageLayout.Zoom;
            buttonBackSpace.ForeColor = SystemColors.ControlText;
            buttonBackSpace.Location = new Point(53, 92);
            buttonBackSpace.Name = "buttonBackSpace";
            buttonBackSpace.Size = new Size(43, 37);
            buttonBackSpace.TabIndex = 2;
            buttonBackSpace.UseVisualStyleBackColor = false;
            buttonBackSpace.Click += buttonBackSpace_Click;
            // 
            // button1
            // 
            button1.Location = new Point(6, 135);
            button1.Name = "button1";
            button1.Size = new Size(41, 41);
            button1.TabIndex = 3;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // buttonFaiz
            // 
            buttonFaiz.BackColor = Color.FromArgb(255, 128, 0);
            buttonFaiz.ForeColor = SystemColors.ControlText;
            buttonFaiz.Location = new Point(97, 92);
            buttonFaiz.Name = "buttonFaiz";
            buttonFaiz.Size = new Size(43, 37);
            buttonFaiz.TabIndex = 7;
            buttonFaiz.Text = "%";
            buttonFaiz.UseVisualStyleBackColor = false;
            buttonFaiz.Click += buttonFaiz_Click;
            // 
            // buttoBolme
            // 
            buttoBolme.BackColor = Color.FromArgb(255, 128, 0);
            buttoBolme.ForeColor = SystemColors.ControlText;
            buttoBolme.Location = new Point(141, 92);
            buttoBolme.Name = "buttoBolme";
            buttoBolme.Size = new Size(44, 37);
            buttoBolme.TabIndex = 8;
            buttoBolme.Text = "/";
            buttoBolme.UseVisualStyleBackColor = false;
            buttoBolme.Click += buttoBolme_Click;
            // 
            // buttonVurma
            // 
            buttonVurma.BackColor = Color.FromArgb(255, 128, 0);
            buttonVurma.ForeColor = SystemColors.ControlText;
            buttonVurma.Location = new Point(189, 92);
            buttonVurma.Name = "buttonVurma";
            buttonVurma.Size = new Size(44, 37);
            buttonVurma.TabIndex = 9;
            buttonVurma.Text = "X";
            buttonVurma.UseVisualStyleBackColor = false;
            buttonVurma.Click += buttonVurma_Click;
            // 
            // buttonCixma
            // 
            buttonCixma.BackColor = Color.FromArgb(255, 128, 0);
            buttonCixma.ForeColor = SystemColors.ControlText;
            buttonCixma.Location = new Point(189, 135);
            buttonCixma.Name = "buttonCixma";
            buttonCixma.Size = new Size(45, 37);
            buttonCixma.TabIndex = 10;
            buttonCixma.Text = "━";
            buttonCixma.UseVisualStyleBackColor = false;
            buttonCixma.Click += buttonCixma_Click;
            // 
            // buttonToplama
            // 
            buttonToplama.BackColor = Color.FromArgb(255, 128, 0);
            buttonToplama.ForeColor = SystemColors.ControlText;
            buttonToplama.Location = new Point(190, 184);
            buttonToplama.Name = "buttonToplama";
            buttonToplama.Size = new Size(45, 37);
            buttonToplama.TabIndex = 11;
            buttonToplama.Text = "+";
            buttonToplama.UseVisualStyleBackColor = false;
            buttonToplama.Click += buttonToplama_Click;
            // 
            // buttonBeraber
            // 
            buttonBeraber.BackColor = Color.FromArgb(255, 128, 0);
            buttonBeraber.ForeColor = SystemColors.ControlText;
            buttonBeraber.Location = new Point(189, 231);
            buttonBeraber.Name = "buttonBeraber";
            buttonBeraber.Size = new Size(46, 37);
            buttonBeraber.TabIndex = 12;
            buttonBeraber.Text = "=";
            buttonBeraber.UseVisualStyleBackColor = false;
            buttonBeraber.Click += buttonBeraber_Click;
            // 
            // button2
            // 
            button2.Location = new Point(53, 135);
            button2.Name = "button2";
            button2.Size = new Size(43, 41);
            button2.TabIndex = 13;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(97, 135);
            button3.Name = "button3";
            button3.Size = new Size(43, 41);
            button3.TabIndex = 14;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(141, 135);
            button4.Name = "button4";
            button4.Size = new Size(43, 41);
            button4.TabIndex = 15;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button8
            // 
            button8.Location = new Point(141, 182);
            button8.Name = "button8";
            button8.Size = new Size(43, 41);
            button8.TabIndex = 19;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button7
            // 
            button7.Location = new Point(97, 182);
            button7.Name = "button7";
            button7.Size = new Size(43, 41);
            button7.TabIndex = 18;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.Location = new Point(53, 182);
            button6.Name = "button6";
            button6.Size = new Size(43, 41);
            button6.TabIndex = 17;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.Location = new Point(6, 182);
            button5.Name = "button5";
            button5.Size = new Size(41, 41);
            button5.TabIndex = 16;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button9
            // 
            button9.Location = new Point(6, 229);
            button9.Name = "button9";
            button9.Size = new Size(43, 41);
            button9.TabIndex = 20;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button0
            // 
            button0.Location = new Point(53, 229);
            button0.Name = "button0";
            button0.Size = new Size(43, 41);
            button0.TabIndex = 21;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = true;
            button0.Click += button0_Click;
            // 
            // buttonVergul
            // 
            buttonVergul.Location = new Point(97, 229);
            buttonVergul.Name = "buttonVergul";
            buttonVergul.Size = new Size(43, 41);
            buttonVergul.TabIndex = 22;
            buttonVergul.Text = ",";
            buttonVergul.UseVisualStyleBackColor = true;
            buttonVergul.Click += buttonVergul_Click;
            // 
            // buttonChange
            // 
            buttonChange.Location = new Point(141, 227);
            buttonChange.Name = "buttonChange";
            buttonChange.Size = new Size(43, 41);
            buttonChange.TabIndex = 23;
            buttonChange.Text = "CH";
            buttonChange.UseVisualStyleBackColor = true;
            buttonChange.Click += buttonChange_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(239, 280);
            Controls.Add(buttonChange);
            Controls.Add(buttonVergul);
            Controls.Add(button0);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(buttonBeraber);
            Controls.Add(buttonToplama);
            Controls.Add(buttonCixma);
            Controls.Add(buttonVurma);
            Controls.Add(buttoBolme);
            Controls.Add(buttonFaiz);
            Controls.Add(button1);
            Controls.Add(buttonBackSpace);
            Controls.Add(buttonClear);
            Controls.Add(ResultBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox ResultBox;
        private Button buttonClear;
        private Button buttonBackSpace;
        private Button button1;
        private Button buttonFaiz;
        private Button buttoBolme;
        private Button buttonVurma;
        private Button buttonCixma;
        private Button buttonToplama;
        private Button buttonBeraber;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button9;
        private Button button0;
        private Button buttonVergul;
        private Button buttonChange;
    }
}