using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe7
{
    internal class Marca
    {
        private int id;
        private string descripcion;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        public Marca()
        {

        }
        public Marca(string pDescripcion) 
        {
            Descripcion = pDescripcion;
        }
        public static DataTable BuscarTodo() 
        {
            DataTable dt = new DataTable();
            string consulta = $"SELECT Marcas.Id, Marcas.Descripcion FROM Marcas ";
            dt = BaseDatos.Search(consulta);
            return dt;
        }
        public bool New()
        {
            bool correcto = true;
            string consulta = $"INSERT INTO Marcas (Descripcion)" +
                $" VALUES ('{descripcion}')";
            correcto = BaseDatos.EjecutarConsulta(consulta);
            return correcto;
        }
        public bool Modificar(int id)
        {
            bool correcto = true;
            string consulta = $"UPDATE Marcas SET Descripcion='{Descripcion}'" +
                $" WHERE Id ={id}";
            correcto = BaseDatos.EjecutarConsulta(consulta);
            return correcto;
        }
        static public bool borrar(int id)
        {
            bool correcto = true;
            string consulta = $"DELETE FROM Marcas WHERE Id={id}";
            correcto = BaseDatos.EjecutarConsulta(consulta);
            return correcto;
        }
        static public DataTable BuscarPorId(int id)
        {
            DataTable dt = new DataTable();
            string consulta = $"SELECT Marcas.Id, Marcas.Descripcion FROM Marcas" +
                $" WHERE Marcas.Id={id}";
            dt = BaseDatos.Search(consulta);
            return dt;
        }
        static public DataTable BuscarPorDescripcion(string texto)
        {
            DataTable dt = new DataTable();
            string consulta = $"SELECT Marcas.Id, Marcas.Descripcion FROM Marcas" +
                $" WHERE Marcas.Descripcion LIKE '%{texto}%'";
            dt=BaseDatos.Search(consulta);
            return dt;
        }
    }
}

