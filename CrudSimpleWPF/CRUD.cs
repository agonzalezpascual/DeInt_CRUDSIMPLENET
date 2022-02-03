using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CrudSimpleWPF
{
    internal class CRUD
    {
        private String conexion = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=crudnet;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public List<Persona> listPer { get; set; }

        // Método insertar
        public void insertar(string textoNom, string textoApe, string genero) {

            // Creamos la conexión y hacemos la consulta
            try
            {
                SqlConnection con = new SqlConnection(conexion);
                con.Open();
                SqlCommand command = new SqlCommand("INSERT INTO Personas(nombre, apellido, genero) " +
                    "VALUES ('"+textoNom+"', '"+textoApe+ "', '" + genero + "');", con);
                command.ExecuteNonQuery();
                MessageBox.Show("Insertado correctamente.");
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR " + ex.Message, "Error al insertar los datos.", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        // Método actualizar
        public void actualizar(string textoNom, string textoApe, string genero, int id) {
            try
            {
                SqlConnection con = new SqlConnection(conexion);
                con.Open();
                SqlCommand command = new SqlCommand("UPDATE Personas SET " +
                    "Nombre = '" + textoNom + "', Apellido = '" + textoApe + "', Genero = '" + genero + "' WHERE id = " + id+";", con);
                command.ExecuteNonQuery();
                MessageBox.Show("Insertado correctamente.");
                con.Close();

            }
            // Creamos la conexión y hacemos la consulta
            catch (Exception ex)
            {
                MessageBox.Show("ERROR " + ex.Message, "Error al insertar los datos.", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        // Método borrar
        public void borrar(int id) {
            try
            {
                // Creamos la conexión y hacemos la consulta
                SqlConnection con = new SqlConnection(conexion);
                con.Open();
                SqlCommand command = new SqlCommand("DELETE FROM Personas WHERE id = " + id + ";", con);
                command.ExecuteNonQuery();
                MessageBox.Show("Insertado correctamente.");
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR " + ex.Message, "Error al insertar los datos.", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }
        // Método buscar
        public DataTable buscar(string textoBuscar)
        {
            DataTable dt = null;
            // Creamos la conexión y hacemos la consulta
            try
            {
                SqlConnection con = new SqlConnection(conexion);
                con.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM Personas WHERE nombre = '" + textoBuscar + "';", con);
                SqlDataAdapter sda = new SqlDataAdapter(command);
                dt = new DataTable("PersonaSelect");
                sda.Fill(dt);
                // Retornamos un dataset
                return dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR " + ex.Message, "Error al insertar los datos.", MessageBoxButton.OK, MessageBoxImage.Error);
                // Retornamos un dataset
                return dt;
            }
        }

    }
}
