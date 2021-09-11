using System;
using System.Windows.Forms;

namespace BASIC_COCOMO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox5.Text))
            {
                MessageBox.Show("Enter KLOC and Select project type", "Missing input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (int.TryParse(textBox5.Text, out int KLOC)){
                BaseTypes currentType = null;

                switch (comboBox1.SelectedIndex)
                {
                    case 0:
                        currentType = new OrganicType(KLOC);
                        break;

                    case 1:
                        currentType = new SemiDetachedType(KLOC);
                        break;

                    case 2:
                        currentType = new EmbeddedType(KLOC);
                        break;

                    default:
                        MessageBox.Show("Please select a COCOMO mode", "Mode not selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                }

                Result res = currentType.CalculateResults();

                textBox1.Text = res.getEffort().ToString();
                textBox2.Text = res.getTimeOfDevelopment().ToString();
                textBox3.Text = res.getProductivity().ToString();
                textBox4.Text = res.getStaffingSize().ToString();


            }
            else{
                MessageBox.Show($"Check KLOC input type.\nCurrent type: {textBox1.Text.GetType()}", "Parsing Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

       
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
