namespace Practica03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string numero = numeroTxt.Text;
            string letra = letraTxt.Text;

            if(string.IsNullOrEmpty(letra) ||
                string.IsNullOrWhiteSpace(letra))
            {
                MessageBox.Show("Escribe un texto");
            }

            if(int.TryParse(numero, out int n))
            {
                MessageBox.Show("Es un numero");
            }
            else
            {
                MessageBox.Show("No es un numero");
            }
        }
    }
}