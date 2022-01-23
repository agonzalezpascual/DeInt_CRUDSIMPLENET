using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CrudSimpleWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private String conexion = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=crudnet;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public List<Persona> listPer { get; set; }
        CRUD c = new CRUD();
        int idSelect;
        public MainWindow()
        {
            InitializeComponent();

            //Poblamos la tabla
            pueblaTabla();

        }

        public void pueblaTabla() {
            using (crudnetContext _context = new crudnetContext())
            {
                listPer = _context.Personas.ToList();

                tabla.ItemsSource = listPer;

                //Calcula el numero de filas

                int numFilas = listPer.Count;
                filas.Content = numFilas;

            }
        }

        private void botonInsertar_Click(object sender, RoutedEventArgs e)
        {
            c.insertar(textoNom.Text, textoApe.Text, comboGenero.Text);
            pueblaTabla();
        }

        private void botonActualizar_Click(object sender, RoutedEventArgs e)
        {
            c.actualizar(textoNom.Text, textoApe.Text, comboGenero.Text, idSelect);
            pueblaTabla();
        }

        private void botonBuscar_Click(object sender, RoutedEventArgs e)
        {
            DataTable dt = c.buscar(textoBuscar.Text);
            if (textoBuscar.Text == "")
            {
                pueblaTabla();
            }
            else {
                
                tabla.ItemsSource = dt.DefaultView;
            }
            
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void tabla_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Persona p = (Persona)tabla.SelectedItem;

            idSelect = p.Id;
            textoNom.Text = p.Nombre.ToString();
            textoApe.Text = p.Apellido.ToString();
            comboGenero.Text = p.Genero.ToString();

        }

        private void botonBorrar_Click(object sender, RoutedEventArgs e)
        {
            c.borrar(idSelect);
            pueblaTabla();
        }
    }
}
