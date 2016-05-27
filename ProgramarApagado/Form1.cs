using System;
using System.Windows.Forms;

namespace ProgramarApagado
{
    public partial class ventanaPrincipal : Form
    {
        public ventanaPrincipal()
        {
            InitializeComponent();
            botonApagar.Enabled = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void horas_SelectedItemChanged(object sender, EventArgs e)
        {
            
        }

        private void minutos_SelectedItemChanged(object sender, EventArgs e)
        {
            
        }

        private void segundos_SelectedItemChanged(object sender, EventArgs e)
        {
            
        }

        private void botonApagar_Click(object sender, EventArgs e)
        {
            if(tiempo(horas.Value, minutos.Value, segundos.Value) == 0)
            {
                MessageBox.Show("Ingrese un tiempo mayor a 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ComandosCMD.ProgramarApagado(tiempo(horas.Value, minutos.Value, segundos.Value));
                Close();
            }
        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            ComandosCMD.CancelarApagado();
            Close();
        }

        private static decimal tiempo(decimal horas, decimal minutos, decimal segundos)
        {
            decimal tiempoEnSegundos = segundos + minutos * 60 + horas * 3600;
            return tiempoEnSegundos;
        }

        private void horas_ValueChanged(object sender, EventArgs e)
        {
            botonApagar.Enabled = true;
        }

        private void minutos_ValueChanged(object sender, EventArgs e)
        {
            botonApagar.Enabled = true;
        }

        private void segundos_ValueChanged(object sender, EventArgs e)
        {
            botonApagar.Enabled = true;
        }

        private void valorCambiado(object sender, EventArgs e)
        {
            if(horas.Value > 0 || minutos.Value > 0 || segundos.Value > 0)
            {
                botonApagar.Enabled = true;
            }else
            {
                botonApagar.Enabled = false;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
