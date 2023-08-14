namespace Practica01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttCalcular_Click(object sender, EventArgs e)
        {
            double montoInicial, porcentaje, resultado;
            montoInicial = Convert.ToDouble(txtMonto.Text);
            porcentaje = Convert.ToDouble(txtPorcentaje.Text);
            resultado = montoInicial + (montoInicial * (porcentaje / 100));

            lblMensaje.Text = "El interes compuesto es: " + resultado.ToString();
        }


    }
}