using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics.Eventing.Reader;

namespace Classe7
{
    internal class Producto
    {
        private int id;
        private int idMarca;
        private string descripcion;
        private int precioVenta;
        private int precioCompra;
        public int Id{ get { return id; } set {  id = value; } }
        public int IdMarca { get { return idMarca; } set { idMarca = value; } }
        public string Descripcion { get { return descripcion; } set { descripcion = value; } }
        public int PrecioCompra { get { return precioCompra; } set { precioCompra = value; } }
        public int PrecioVenta { get { return precioVenta; } set { precioVenta = value; } }

        public Producto() 
        {

        }
        public Producto(int pIdMarca,string pDescripcion,int pPrecioCompra,int pPrecioVenta)
        {
            Descripcion= pDescripcion;
            PrecioVenta = pPrecioCompra;
            PrecioCompra = pPrecioCompra;
            IdMarca = pIdMarca;
        }
        public bool New()
        {
            bool correcto = false;
            string consulta = $"INSERT INTO Productos (IdMarca, Descripcion, PrecioCompra, PrecioVenta)" +
                   $"VALUES  ({IdMarca},'{Descripcion}',{PrecioCompra},{PrecioVenta})";
            correcto = BaseDatos.EjecutarConsulta(consulta);
            return correcto;
        }
        public bool Modificar(int id)
        {
            bool correcto = false;
            string consulta = $"UPDATE Productos SET IdMarca ={IdMarca},Descripcion='{Descripcion}',PrecioCompra={PrecioCompra},PrecioVenta={PrecioVenta}"+
                $"WHERE Id={id}";
            correcto = BaseDatos.EjecutarConsulta(consulta);
            return correcto;
        }
        static public bool Eliminar(int IdSeleccionado)
        {
            bool correcto = false;
            string consulta = $"DELETE FROM Productos WHERE Id={IdSeleccionado}";
            correcto = BaseDatos.EjecutarConsulta(consulta);
            return correcto;
        }
        static public DataTable BuscarTodo()
        {
            DataTable dt = new DataTable();
            string consulta = $"SELECT Productos.Id,Productos.IdMarca,Marcas.Descripcion AS Marcas,Productos.Descripcion,Productos.PrecioCompra,Productos.PrecioVenta" +
                $" FROM Productos INNER JOIN Marcas ON Productos.IdMarca= Marcas.Id";
            dt = BaseDatos.Search(consulta);
            return dt;
        }
        static public DataTable BuscarPorId(int IdSeleccionado)
        {
            DataTable dt =new DataTable();
            string consulta= $"SELECT Productos.Id,Productos.IdMarca,Marcas.Descripcion AS Marcas,Productos.Descripcion,Productos.PrecioCompra,Productos.PrecioVenta" +
                $" FROM Productos INNER JOIN Marcas ON Productos.IdMarca= Marcas.Id" +
                $" WHERE Productos.Id={IdSeleccionado}";
            dt=BaseDatos.Search(consulta);
            return dt;
        }
        static public DataTable BuscarPorMarca(string marcaBuscar)
        {
            DataTable dt = new DataTable();
            string consulta = $"SELECT Productos.Id,Productos.IdMarca,Marcas.Descripcion AS Marcas,Productos.Descripcion,Productos.PrecioCompra,Productos.PrecioVenta" +
                $" FROM Productos INNER JOIN Marcas ON Productos.IdMarca= Marcas.Id" +
                $" WHERE Productos.Descripcion = '{marcaBuscar}'";
            dt = BaseDatos.Search(consulta);
            return dt;
        }
        static public DataTable BuscarPorDescripcion(string descripcionBuscar)
        {
            DataTable dt = new DataTable();
            string consulta = $"SELECT Productos.Id,Productos.IdMarca,Marcas.Descripcion AS Marcas,Productos.Descripcion,Productos.PrecioCompra,Productos.PrecioVenta" +
                $" FROM Productos INNER JOIN Marcas ON Productos.IdMarca= Marcas.Id" +
                $" WHERE Productos.Descripcion LIKE '%{descripcionBuscar}%'";
            dt = BaseDatos.Search(consulta);
            return dt;
        }
    
    }
}
