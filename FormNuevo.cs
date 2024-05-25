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
    public partial class FormNuevo : Form
    {
        public FormNuevo()
        {
            InitializeComponent();
        }

        private void FormNuevo_Load(object sender, EventArgs e)
        {
            cmbMarca.ValueMember = "Id";
            cmbMarca.DisplayMember = "Descripcion";
            cmbMarca.DataSource = Marca.BuscarTodo();
        }

        private void BTNGuardar_Click(object sender, EventArgs e)
        {
            bool correcto = true;
            int precioCompra;
            int precioVenta;
            if (textDescripcion.Text.Trim() == ""){
                MessageBox.Show("La descripción es obligatoria");
                correcto = false;
            }
            if (!int.TryParse(textPrecioVent.Text.Trim(),out precioVenta))
            {
                MessageBox.Show("Ingrese un precio de venta");
                correcto = false;
            }
            if(!int.TryParse(textPrecioCom.Text.Trim(), out precioCompra))
            {
                MessageBox.Show("Ingrese un precio de compra");
                correcto = false;
            }
            if (correcto)
            {
                Producto nuevo = new Producto(Convert.ToInt32(cmbMarca.SelectedValue),textDescripcion.Text.Trim(), precioCompra, precioVenta);
                if (nuevo.New())
                {
                    MessageBox.Show("Datos guardados correctamente");
                    Close();
                }
                else
                {
                    MessageBox.Show("ocurrio un error al guardar el producto");
                    Close();
                }

            }
        }

        private void BTNCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
