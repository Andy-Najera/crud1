using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Clase;

namespace WindowsFormsApp1
{

    public partial class Form1 : Form
    {
        crud miCrud = new crud();
        public Form1()
        {
            InitializeComponent();
        }

        private void cnet_Click(object sender, EventArgs e) 
        {

        }

        private void btonsaludar_Click(object sender, EventArgs e) //boton tocame 
        {
            MessageBox.Show("Feliz semana santa inge (〃￣︶￣)人(￣︶￣〃) ");
        }

        private void buttonbscar_Click(object sender, EventArgs e)
        {
            textBoxNmbre.Text = miCrud.MostrarAlumno(textBoxCnet.Text);
        }

        private void buttonRgistrar_Click(object sender, EventArgs e)
        {
            string nombre = textBoxNmbre.Text;
            string carnet = textBoxCnet.Text;
            string email = textBoxCrreo.Text;
            string seccion = comboBoxSccion.Text;
            string respuesta = miCrud.AgregarAlumno(carnet, nombre, email, seccion);
            MessageBox.Show(respuesta);
        }

        
    }
}

