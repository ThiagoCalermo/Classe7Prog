using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classe7
{
    public partial class FormNuevoMarca : Form
    {
        public FormNuevoMarca()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNuevaMarca_Click(object sender, EventArgs e)
        {
            bool correcto = true;
            if (txtIdMarcaNew.Text.Trim()=="")
            {
                MessageBox.Show("Ingrese la nueva descripción");
                correcto = false;
            }
            if (correcto == true)
            {
                Marca newMarca=new Marca(txtIdMarcaNew.Text.Trim());
                if (newMarca.New())
                {
                    MessageBox.Show("Nueva Marca agregada con exito");
                    Close();
                }
                else
                {
                    MessageBox.Show("Error"); 
                }
            }
        }
    }
}
