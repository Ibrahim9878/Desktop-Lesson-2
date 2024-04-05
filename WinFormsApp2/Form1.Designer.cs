namespace WinFormsApp2
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
            textBox1 = new TextBox();
            buttonLoad = new Button();
            LabelName = new Label();
            LabelSurname = new Label();
            labelProfession = new Label();
            labelCountry = new Label();
            NameText = new TextBox();
            SurnameText = new TextBox();
            ProfessionText = new TextBox();
            CountryText = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            labelDate = new Label();
            MaleRadio = new RadioButton();
            femaleRadio = new RadioButton();
            labelGender = new Label();
            CityText = new TextBox();
            labelSeher = new Label();
            PhoneText = new TextBox();
            labelPhone = new Label();
            buttonSave = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(9, 24);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Name";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            // 
            // buttonLoad
            // 
            buttonLoad.BackColor = Color.Teal;
            buttonLoad.Location = new Point(181, 15);
            buttonLoad.Name = "buttonLoad";
            buttonLoad.Size = new Size(92, 36);
            buttonLoad.TabIndex = 1;
            buttonLoad.Text = "Load";
            buttonLoad.UseVisualStyleBackColor = false;
            buttonLoad.Click += buttonLoad_Click;
            // 
            // LabelName
            // 
            LabelName.AutoSize = true;
            LabelName.Location = new Point(9, 86);
            LabelName.Name = "LabelName";
            LabelName.Size = new Size(25, 15);
            LabelName.TabIndex = 2;
            LabelName.Text = "Ad:";
            // 
            // LabelSurname
            // 
            LabelSurname.AutoSize = true;
            LabelSurname.Location = new Point(9, 112);
            LabelSurname.Name = "LabelSurname";
            LabelSurname.Size = new Size(45, 15);
            LabelSurname.TabIndex = 3;
            LabelSurname.Text = "Soyad: ";
            // 
            // labelProfession
            // 
            labelProfession.AutoSize = true;
            labelProfession.Location = new Point(9, 136);
            labelProfession.Name = "labelProfession";
            labelProfession.Size = new Size(34, 15);
            labelProfession.TabIndex = 4;
            labelProfession.Text = "Pese:";
            // 
            // labelCountry
            // 
            labelCountry.AutoSize = true;
            labelCountry.Location = new Point(9, 178);
            labelCountry.Name = "labelCountry";
            labelCountry.Size = new Size(37, 15);
            labelCountry.TabIndex = 5;
            labelCountry.Text = "Olke: ";
            // 
            // NameText
            // 
            NameText.BorderStyle = BorderStyle.FixedSingle;
            NameText.Location = new Point(73, 78);
            NameText.Name = "NameText";
            NameText.PlaceholderText = "Name";
            NameText.Size = new Size(183, 23);
            NameText.TabIndex = 6;
            // 
            // SurnameText
            // 
            SurnameText.BorderStyle = BorderStyle.FixedSingle;
            SurnameText.Location = new Point(73, 104);
            SurnameText.Name = "SurnameText";
            SurnameText.PlaceholderText = "Surname";
            SurnameText.Size = new Size(183, 23);
            SurnameText.TabIndex = 7;
            // 
            // ProfessionText
            // 
            ProfessionText.BorderStyle = BorderStyle.FixedSingle;
            ProfessionText.Location = new Point(73, 133);
            ProfessionText.Name = "ProfessionText";
            ProfessionText.PlaceholderText = "Profession";
            ProfessionText.Size = new Size(183, 23);
            ProfessionText.TabIndex = 8;
            // 
            // CountryText
            // 
            CountryText.BorderStyle = BorderStyle.FixedSingle;
            CountryText.Location = new Point(73, 170);
            CountryText.Name = "CountryText";
            CountryText.PlaceholderText = "Country";
            CountryText.Size = new Size(183, 23);
            CountryText.TabIndex = 9;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(73, 275);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 10;
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Location = new Point(14, 275);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(34, 15);
            labelDate.TabIndex = 11;
            labelDate.Text = "Date:";
            // 
            // MaleRadio
            // 
            MaleRadio.AutoSize = true;
            MaleRadio.Location = new Point(73, 315);
            MaleRadio.Name = "MaleRadio";
            MaleRadio.Size = new Size(51, 19);
            MaleRadio.TabIndex = 12;
            MaleRadio.TabStop = true;
            MaleRadio.Text = "Male";
            MaleRadio.UseVisualStyleBackColor = true;
            // 
            // femaleRadio
            // 
            femaleRadio.AutoSize = true;
            femaleRadio.Location = new Point(146, 315);
            femaleRadio.Name = "femaleRadio";
            femaleRadio.Size = new Size(63, 19);
            femaleRadio.TabIndex = 13;
            femaleRadio.TabStop = true;
            femaleRadio.Text = "Female";
            femaleRadio.UseVisualStyleBackColor = true;
            // 
            // labelGender
            // 
            labelGender.AutoSize = true;
            labelGender.Location = new Point(15, 317);
            labelGender.Name = "labelGender";
            labelGender.Size = new Size(33, 15);
            labelGender.TabIndex = 14;
            labelGender.Text = "Cins:";
            // 
            // CityText
            // 
            CityText.BorderStyle = BorderStyle.FixedSingle;
            CityText.Location = new Point(73, 198);
            CityText.Name = "CityText";
            CityText.PlaceholderText = "City";
            CityText.Size = new Size(183, 23);
            CityText.TabIndex = 16;
            // 
            // labelSeher
            // 
            labelSeher.AutoSize = true;
            labelSeher.Location = new Point(9, 207);
            labelSeher.Name = "labelSeher";
            labelSeher.Size = new Size(39, 15);
            labelSeher.TabIndex = 15;
            labelSeher.Text = "Seher:";
            // 
            // PhoneText
            // 
            PhoneText.BorderStyle = BorderStyle.FixedSingle;
            PhoneText.Location = new Point(73, 227);
            PhoneText.Name = "PhoneText";
            PhoneText.PlaceholderText = "Phone";
            PhoneText.Size = new Size(183, 23);
            PhoneText.TabIndex = 18;
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.Location = new Point(9, 235);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(48, 15);
            labelPhone.TabIndex = 17;
            labelPhone.Text = "Telefon:";
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.Teal;
            buttonSave.Location = new Point(95, 347);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(95, 35);
            buttonSave.TabIndex = 19;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(280, 394);
            Controls.Add(buttonSave);
            Controls.Add(PhoneText);
            Controls.Add(labelPhone);
            Controls.Add(CityText);
            Controls.Add(labelSeher);
            Controls.Add(labelGender);
            Controls.Add(femaleRadio);
            Controls.Add(MaleRadio);
            Controls.Add(labelDate);
            Controls.Add(dateTimePicker1);
            Controls.Add(CountryText);
            Controls.Add(ProfessionText);
            Controls.Add(SurnameText);
            Controls.Add(NameText);
            Controls.Add(labelCountry);
            Controls.Add(labelProfession);
            Controls.Add(LabelSurname);
            Controls.Add(LabelName);
            Controls.Add(buttonLoad);
            Controls.Add(textBox1);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Form1";
            WindowState = FormWindowState.Minimized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button buttonLoad;
        private Label LabelName;
        private Label LabelSurname;
        private Label labelProfession;
        private Label labelCountry;
        private TextBox NameText;
        private TextBox SurnameText;
        private TextBox ProfessionText;
        private TextBox CountryText;
        private DateTimePicker dateTimePicker1;
        private Label labelDate;
        private RadioButton MaleRadio;
        private RadioButton femaleRadio;
        private Label labelGender;
        private TextBox CityText;
        private Label labelSeher;
        private TextBox PhoneText;
        private Label labelPhone;
        private Button buttonSave;
    }
}