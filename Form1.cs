namespace Practica_8_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int edad;
            edad = int.Parse(textBox1.Text);

            if (edad < 12.0) MessageBox.Show(" Nino ");

            else
                if (edad < 18.0) MessageBox.Show(" adolescente ");

            else
                 if (edad < 60.0) MessageBox.Show(" adulto ");

            else
                 if (edad > 60.0) MessageBox.Show(" adulto mayor ");
        }
    }
}