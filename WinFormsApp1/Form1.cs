using System.Data;
using System.DirectoryServices;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public string text = string.Empty;
        public string cpyText { get; set; }
        public Form1()
        {
            InitializeComponent();
            ResultBox.Text = text;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            text = string.Empty;
            ResultBox.Text = text;
        }

        private void buttonBackSpace_Click(object sender, EventArgs e)
        {
            if (ResultBox.Text == null)
            {
                text = string.Empty;
                ResultBox.Text = text;
                return;
            }
            text = text.Substring(0, text.Length - 1);
            ResultBox.Text = text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            text += "1";
            ResultBox.Text = text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            text += "2";
            ResultBox.Text = text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            text += "3";
            ResultBox.Text = text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            text += "4";
            ResultBox.Text = text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            text += "5";
            ResultBox.Text = text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            text += "6";
            ResultBox.Text = text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            text += "7";
            ResultBox.Text = text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            text += "8";
            ResultBox.Text = text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            text += "9";
            ResultBox.Text = text;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            text += "0";
            ResultBox.Text = text;
        }

        private void buttonVergul_Click(object sender, EventArgs e)
        {
            text += ".";
            ResultBox.Text = text;
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            text += "Changed";
            ResultBox.Text = text;
        }

        private void buttonFaiz_Click(object sender, EventArgs e)
        {
            
                text += "/100";
                cpyText += text;
                text = string.Empty;
                ResultBox.Text = text;
        }

        private void buttoBolme_Click(object sender, EventArgs e)
        {
            text += "/";
            cpyText += text;
            text = string.Empty;
            ResultBox.Text = text;
        }

        private void buttonVurma_Click(object sender, EventArgs e)
        {
            text += "*";
            cpyText += text;
            text = string.Empty;
            ResultBox.Text = text;
        }

        private void buttonCixma_Click(object sender, EventArgs e)
        {
            text += "-";
            cpyText += text;
            text = string.Empty;
            ResultBox.Text = text;
        }

        private void buttonToplama_Click(object sender, EventArgs e)
        {
            text += "+";
            cpyText += text;
            text = string.Empty;
            ResultBox.Text = text;
        }

        private void buttonBeraber_Click(object sender, EventArgs e)
        {
            cpyText += text;
            DataTable table = new DataTable();
            double result = Convert.ToDouble(table.Compute(cpyText, ""));
            ResultBox.Text = result.ToString();
            text = string.Empty;
            cpyText = string.Empty;
        }
    }
}