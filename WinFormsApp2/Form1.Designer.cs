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
            textBox1.Location = new Point(246, 41);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            // 
            // buttonLoad
            // 
            buttonLoad.Location = new Point(444, 40);
            buttonLoad.Name = "buttonLoad";
            buttonLoad.Size = new Size(75, 23);
            buttonLoad.TabIndex = 1;
            buttonLoad.Text = "Load";
            buttonLoad.UseVisualStyleBackColor = true;
            buttonLoad.Click += buttonLoad_Click;
            // 
            // LabelName
            // 
            LabelName.AutoSize = true;
            LabelName.Location = new Point(161, 119);
            LabelName.Name = "LabelName";
            LabelName.Size = new Size(25, 15);
            LabelName.TabIndex = 2;
            LabelName.Text = "Ad:";
            // 
            // LabelSurname
            // 
            LabelSurname.AutoSize = true;
            LabelSurname.Location = new Point(161, 158);
            LabelSurname.Name = "LabelSurname";
            LabelSurname.Size = new Size(45, 15);
            LabelSurname.TabIndex = 3;
            LabelSurname.Text = "Soyad: ";
            // 
            // labelProfession
            // 
            labelProfession.AutoSize = true;
            labelProfession.Location = new Point(161, 197);
            labelProfession.Name = "labelProfession";
            labelProfession.Size = new Size(34, 15);
            labelProfession.TabIndex = 4;
            labelProfession.Text = "Pese:";
            // 
            // labelCountry
            // 
            labelCountry.AutoSize = true;
            labelCountry.Location = new Point(161, 239);
            labelCountry.Name = "labelCountry";
            labelCountry.Size = new Size(37, 15);
            labelCountry.TabIndex = 5;
            labelCountry.Text = "Olke: ";
            // 
            // NameText
            // 
            NameText.Location = new Point(246, 111);
            NameText.Name = "NameText";
            NameText.PlaceholderText = "Name";
            NameText.Size = new Size(100, 23);
            NameText.TabIndex = 6;
            // 
            // SurnameText
            // 
            SurnameText.Location = new Point(246, 158);
            SurnameText.Name = "SurnameText";
            SurnameText.PlaceholderText = "Surname";
            SurnameText.Size = new Size(100, 23);
            SurnameText.TabIndex = 7;
            // 
            // ProfessionText
            // 
            ProfessionText.Location = new Point(246, 194);
            ProfessionText.Name = "ProfessionText";
            ProfessionText.PlaceholderText = "Profession";
            ProfessionText.Size = new Size(100, 23);
            ProfessionText.TabIndex = 8;
            // 
            // CountryText
            // 
            CountryText.Location = new Point(246, 231);
            CountryText.Name = "CountryText";
            CountryText.PlaceholderText = "Country";
            CountryText.Size = new Size(100, 23);
            CountryText.TabIndex = 9;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(246, 357);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 10;
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Location = new Point(161, 365);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(34, 15);
            labelDate.TabIndex = 11;
            labelDate.Text = "Date:";
            // 
            // MaleRadio
            // 
            MaleRadio.AutoSize = true;
            MaleRadio.Location = new Point(246, 415);
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
            femaleRadio.Location = new Point(323, 413);
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
            labelGender.Location = new Point(161, 417);
            labelGender.Name = "labelGender";
            labelGender.Size = new Size(33, 15);
            labelGender.TabIndex = 14;
            labelGender.Text = "Cins:";
            // 
            // CityText
            // 
            CityText.Location = new Point(246, 260);
            CityText.Name = "CityText";
            CityText.PlaceholderText = "City";
            CityText.Size = new Size(100, 23);
            CityText.TabIndex = 16;
            // 
            // labelSeher
            // 
            labelSeher.AutoSize = true;
            labelSeher.Location = new Point(161, 268);
            labelSeher.Name = "labelSeher";
            labelSeher.Size = new Size(39, 15);
            labelSeher.TabIndex = 15;
            labelSeher.Text = "Seher:";
            // 
            // PhoneText
            // 
            PhoneText.Location = new Point(246, 301);
            PhoneText.Name = "PhoneText";
            PhoneText.PlaceholderText = "Phone";
            PhoneText.Size = new Size(100, 23);
            PhoneText.TabIndex = 18;
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.Location = new Point(161, 309);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(48, 15);
            labelPhone.TabIndex = 17;
            labelPhone.Text = "Telefon:";
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(12, 357);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 23);
            buttonSave.TabIndex = 19;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
            Name = "Form1";
            Text = "Form1";
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