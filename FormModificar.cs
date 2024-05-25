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
    public partial class FormModificar : Form
    {
        public FormModificar()
        {
            InitializeComponent();
        }

        private void FormModificar_Load(object sender, EventArgs e)
        {
            cmbMarca.ValueMember = "Id";
            cmbMarca.DisplayMember = "Descripcion";
            cmbMarca.DataSource = Marca.BuscarTodo();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            bool correcto = true;
            int precioCompra, precioVenta,Id;
            if (!int.TryParse(txtId.Text.Trim(),out Id))
            {
                MessageBox.Show("Ingrese la Id del porducto a modificar inconciente");
                correcto = false;
            }
            if (!int.TryParse(txtPrecioCompra.Text.Trim(),out precioCompra))
            {
                MessageBox.Show("Ingrese un precio de compra por fa");
                correcto = false;
            }
            if (!int.TryParse(txtPrecioVenta.Text.Trim(),out precioVenta))
            {
                MessageBox.Show("Ingrese un Precio de venta por fa");
                correcto = false;
            }
            if (txtDescripcion.Text.Trim()=="")
            {
                MessageBox.Show("Ingrese la descripcion por fa");
                correcto = false;
            }
            if (correcto == true)
            {
                Producto modificado = new Producto(Convert.ToInt32(cmbMarca.SelectedValue),txtDescripcion.Text.Trim(),precioCompra,precioVenta);
                if (modificado.Modificar(Id))
                {
                    MessageBox.Show("Modificación realizada con exito");
                    Close();
                }
                else
                {
                    MessageBox.Show("A ocurrido un error al modificar la tabla");
                }
            }
           
        }
    }
}
