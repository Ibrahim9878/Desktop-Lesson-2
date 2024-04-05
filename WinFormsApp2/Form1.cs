using WinFormsApp2.Models;
namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (MaleRadio.Checked == true)
            {
                User u = new(NameText.Text, SurnameText.Text, CountryText.Text, ProfessionText.Text, CityText.Text, PhoneText.Text, DateTime.Parse(dateTimePicker1.Text), MaleRadio.Text);
            Functions.WriteUserToJson(u);
            }
            else if (femaleRadio.Checked == false)
            {
                User u = new(NameText.Text, SurnameText.Text, CountryText.Text, ProfessionText.Text, CityText.Text, PhoneText.Text, DateTime.Parse(dateTimePicker1.Text), femaleRadio.Text);
            Functions.WriteUserToJson(u);
            }
            //NameText.Text = string.Empty;
            //SurnameText.Text = string.Empty;
            //CountryText.Text = string.Empty;
            //CityText.Text = string.Empty;
            //PhoneText.Text = string.Empty;
            //ProfessionText.Text = string.Empty;
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            if(File.Exists(textBox1.Text))
            {
                User u = Functions.ReadUserToJson(textBox1.Text);
                NameText.Text = u.Name;
                SurnameText.Text = u.Surname;
                CountryText.Text = u.Country;
                CityText.Text = u.City;
                PhoneText.Text = u.Phone;
                ProfessionText.Text = u.Profession;
                dateTimePicker1.Text = u.Date.ToString();
            }
        }
    }
}