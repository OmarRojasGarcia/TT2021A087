using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TT2021A087.Logica;
using TT2021A087.Datos;
namespace TT2021A087.Presentacion.CorreoBase
{
    public partial class ConfigurarCorreo : Form
    {
        public ConfigurarCorreo()
        {
            InitializeComponent();
        }

        private void btnsincronizar_Click(object sender, EventArgs e)
        {
            bool estado;
            estado= Bases.enviarCorreo(TXTCORREO.Text, txtpass.Text, "Sincronizacion creada Correctamente", "Sincronizacion",TXTCORREO.Text, "");
            if (estado ==true)
            {
                editarCorreo();
                MessageBox.Show("Sincronizacion Creada Correctamente", "Sincronizacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
              
                Dispose();
            }
            else
            {
                MessageBox.Show("Sincronizacion Fallida", "Sincronizacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
        public void editarCorreo()
        {
            Lcorreo parametros = new Lcorreo();
            Editar_datos funcion = new Editar_datos();
            parametros.Correo = Bases.Encriptar ( TXTCORREO.Text);
            parametros.Password = Bases.Encriptar(txtpass.Text);
            parametros.Estado = Bases.Encriptar("Sincronizado");
            funcion.editarCorreobase(parametros);
        }
        private void PictureBox1_Click(object sender, EventArgs e)
        {
          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Panel6_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
