using System.Security.Cryptography;

namespace ElementaryMaths
{
    public partial class frmAllInOne : Form
    {
        public frmAllInOne()
        {
            InitializeComponent();
        }

        private void GenerateValues()
        {
            Random rdm = new Random();
            int intNumber1 = rdm.Next(1, 10);
            int intNumber2 = rdm.Next(1, 10);

            textBox1.Text = intNumber1.ToString();
            textBox2.Text = intNumber2.ToString();

            textBox3.Text = string.Empty;

        }
        private void frmAllInOne_Load(object sender, EventArgs e)
        {
            try
            {
                GenerateValues();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(textBox1.Text) + int.Parse(textBox2.Text) == int.Parse(textBox3.Text) )
                    MessageBox.Show("Good...", "Result");
                else
                    MessageBox.Show("Wrong...","Result");

                GenerateValues();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}