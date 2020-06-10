using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace Ferreteria
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string> HMano = new List<string>();
        List<string> HSujecion = new List<string>();

        public MainWindow()
        {
            InitializeComponent();
            Metodo_de_prueba();
        }

        private void MiDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        //DE ACA HACIA ABAJO TODO TESTING

        public void Metodo_de_prueba()
        {
            Cargo_Combo();
            CargoCategorias();
        }

       

        private void bindlist(List<string> MiLista )
        {
            //creo lista de imagenes para colocar las imagenes
            List<imgs> listr = new List<imgs>();

            //agrego la ruta de la primer imagen de la lista
            foreach (string elemento in MiLista)
            {
                listr.Add(new imgs() { ImageSource = "C:\\Users\\hofer.javier\\source\\repos\\Ferreteria\\Ferreteria\\imag\\"+elemento+".png" });
            }
            

            //agrego al listview la lista creada arriba
            ImageListView.ItemsSource = listr;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Press Click");
        }

        private void CargoCategorias()
        {

            HMano.Add("Alicates");
            HMano.Add("Cutters");
            HMano.Add("Destornilladores");
            HMano.Add("Llaves allen");
            HMano.Add("Llaves Francesa");


            HSujecion.Add("Bridas de sujeción");
            HSujecion.Add("Mordazas");
            HSujecion.Add("Tornillos de apriete o sargentos");
            HSujecion.Add("Tornillos de banco");
            HSujecion.Add("Otras herramientas de sujeción");

        }

        private void Cargo_Combo()
        {
            ComboCategoria.Items.Add("Herramientas de mano");
            ComboCategoria.Items.Add("Herramientas de sujecion");
        }

        private void ComboCategoria_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int selectedIndex = ComboCategoria.SelectedIndex;
            //para herramientas de mano
            if (selectedIndex == 0)
            {
                bindlist(HMano);
            }
            //para herramientas de sujecion
            if (selectedIndex == 1)
            {
                
            }
            
        }

        private void Nombre_Herramienta(object sender, TextChangedEventArgs e)
        {
            
        }
    }

    /// <summary>
    /// clase donde se van a guardar las rutas de las imagenes
    /// </summary>
    public class imgs
    {
        public string ImageSource { get; set; }
    }
}
