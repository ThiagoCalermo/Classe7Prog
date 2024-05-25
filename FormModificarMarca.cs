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
    public partial class FormModificarMarca : Form
    {
        public FormModificarMarca()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnModificarMarca_Click(object sender, EventArgs e)
        {
            bool correcto = true;
            int nro;
            if (!int.TryParse(txtIdMarca.Text.Trim(),out nro))
            {
                MessageBox.Show("Ingrese el Id de la marca a modificar");
                correcto = false;
            }
            if (txtNewDescripcion.Text.Trim()=="")
            {
                MessageBox.Show("Ingrese la descripción nueva");
                correcto = false;
            }
            if (correcto==true) 
            {
                Marca dt = new Marca(txtNewDescripcion.Text.Trim());
                if (dt.Modificar(nro))
                {
                    MessageBox.Show("Marca modificada con exito");
                    Close();
                }
                else
                {
                    MessageBox.Show("Error al modificar");
                }
            }
        }
    }
}
