using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Classe7
{
    static internal class BaseDatos
    {
        static SqlConnection conn = new SqlConnection();
        static bool Connetion()
        {
            try 
            {
                conn.ConnectionString = @"Data Source=LAPTOP-6F0U2DCR;Initial Catalog=sistema;Integrated Security=True";
                conn.Open();
                return true;
            }catch (Exception ex)
            {
                return false;
            }
        }
        static void Disconet()
        {
            conn.Close();
        }
        public static bool EjecutarConsulta (string CadenaSQL)
        {
            bool correcto = false;
            try
            {
                Connetion();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(CadenaSQL, conn);
                da.Fill(dt);
                correcto = true;
            }catch (Exception ex)
            {
                correcto = false;
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Disconet();
            }
            return correcto;
        }
        public static DataTable Search(string CadenaSQL)
        {
            DataTable dt = new DataTable();
            try
            {
                Connetion(); 
                SqlDataAdapter da =new SqlDataAdapter(CadenaSQL,conn);
                da.Fill(dt);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                dt= null;
            }
            finally
            {
                Disconet();
            }
            return dt;
        }
    }
   
}
