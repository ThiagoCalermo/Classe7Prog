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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
        private void LlenarGrilla(DataTable dt)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = dt;
        }
        private void BTNBuscarId_Click(object sender, EventArgs e)
        {
            int codigoBuscado;
            if(!int.TryParse(TXTBBuscarID.Text.Trim(),out codigoBuscado))
            {
                MessageBox.Show("El código ingresado no es valido");
            }
            else
            {
               DataTable dt = Producto.BuscarPorId(codigoBuscado);
                LlenarGrilla(dt);
            }
            
            
        }

        private void btnBuscarTodo_Click(object sender, EventArgs e)
        {
            DataTable dt = Producto.BuscarTodo();
            LlenarGrilla(dt);
        }

        private void BTNBuscarMarca_Click(object sender, EventArgs e)
        {
            DataTable dt = Producto.BuscarPorMarca(TXTBBuscarMarca.Text.Trim());
            LlenarGrilla(dt);
        }

        private void BTNBuscarDescripcion_Click(object sender, EventArgs e)
        {
            DataTable dt = Producto.BuscarPorDescripcion(TXTBBuscarDescripcion.Text.Trim());
            LlenarGrilla(dt);
        }

        private void BTNEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count>0)
            {
                int id;
                id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                DialogResult borra = MessageBox.Show("¿Está seguro que desea eliminar el producto?",
                    "Advertencia",MessageBoxButtons.YesNo);
                if(borra== DialogResult.Yes)
                {
                    Producto.Eliminar(id);
                }
            }
            else { MessageBox.Show("Seleccione un producto"); }
        }

        private void BTNNuevo_Click(object sender, EventArgs e)
        {
            FormNuevo formNew = new FormNuevo();
            formNew.ShowDialog();
        }

        private void BTNModificar_Click(object sender, EventArgs e)
        {

            FormModificar formNew = new FormModificar();
            formNew.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataTable dt = Marca.BuscarTodo();
            LlenarGrilla(dt);
        }

        private void btnIdMarca_Click(object sender, EventArgs e)
        {
            int codigo;
            if (!int.TryParse(txtIdMarca.Text.Trim(), out codigo))
            {
                MessageBox.Show("valor ingresado incorrecto");
            }
            else
            {
                DataTable dt = Marca.BuscarPorId(codigo);
                LlenarGrilla(dt);
            }
        }

        private void btnDescripcionMarca_Click(object sender, EventArgs e)
        {
            if (txtDescripcionMarca.Text.Trim()=="")
            {
                MessageBox.Show("Ingrese una descripción para buascar");
            }
            else
            {
                DataTable dt = Marca.BuscarPorDescripcion(txtDescripcionMarca.Text.Trim());
                LlenarGrilla(dt);
            }
        }

        private void btnEliminarMarca_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int id;
                id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                DialogResult borrar = MessageBox.Show("¿Estás seguro de borrar esta marca?","Advertencia",MessageBoxButtons.YesNo);
                if (borrar==DialogResult.Yes)
                {
                    Marca.borrar(id);
                }
            }    
        }

        private void btnNuevaMarca_Click(object sender, EventArgs e)
        {
            FormNuevoMarca newForm =new FormNuevoMarca();
            newForm.ShowDialog();
        }

        private void btnModificarMarca_Click(object sender, EventArgs e)
        {
            FormModificarMarca modificacion=new FormModificarMarca();
            modificacion.ShowDialog();
        }
    }
}