using Database;

namespace Practica4POE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeHorariosComboBox();
        }

        public void InitializeHorariosComboBox()
        {
            foreach(int i in Enum.GetValues(typeof(Horas)))
            {
                horaInicioComboBox.Items.Add(i);
            }
            foreach (int i in Enum.GetValues(typeof(Horas)))
            {
                horaFinComboBox.Items.Add(i);
            }

            ampmComboBox.Items.AddRange(Enum.GetNames(typeof(Horario)));
            horaInicioComboBox.SelectedIndex = 0;
            horaFinComboBox.SelectedIndex = 0;
            ampmComboBox.SelectedIndex = 0;
        }

        private void guardarButton_Click(object sender, EventArgs e)
        {
            string materia, inicio, fin, horario, mensaje;
            materia = nombreMateriaTextBox.Text;
            inicio = horaInicioComboBox.Text;
            fin = horaFinComboBox.Text;
            horario = ampmComboBox.Text;

            if (string.IsNullOrEmpty (materia) || string.IsNullOrWhiteSpace(materia))
            {
                MessageBox.Show("Escribe una materia");
                return;
            }
            mensaje = $"Materia: {materia}, Hora de inicio. {inicio}, Hora fin{fin}, Horario: {horario}";
            listaHorario.Items.Add(mensaje);
            nombreMateriaTextBox.Clear();
        }
    }
}