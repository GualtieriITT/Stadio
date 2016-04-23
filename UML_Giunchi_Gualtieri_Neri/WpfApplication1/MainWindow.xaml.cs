using System;
using System.Collections.Generic;
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

namespace WpfApplication1
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string [] TipoPartita = {"Campionato", "Normale di Champions", "Finale di Champions", "Normale di Europa League", "Finale di Europa League" };
        string [] Settore = { "Tribuna", "Curva", "Distinti" };
        string [] Tribuna = { "Vip", "Normale" };
        string [] Curva = { "Locale", "Ospite" };
        string [] Distinti = { "Laterale superiore", "Laterale inferiore", "Centrale superiore", "Centrale inferiore" };
        public MainWindow()
        {
            InitializeComponent();
            cmbTipoPartita.ItemsSource = TipoPartita; //Carico nella comboBox il contenuto del vettore TipoPartita
            cmbSettore.ItemsSource = Settore;
            cmbFila.ItemsSource = Enumerable.Range(1, 20);
            cmbPosto.ItemsSource = Enumerable.Range(1, 100);
            cmbGiorno.ItemsSource = Enumerable.Range(1, 31);
            cmbMese.ItemsSource = Enumerable.Range(1, 12);
            cmbAnno.ItemsSource = Enumerable.Range(1900, 116);
        }

        private void cmbSettore_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cmbSettore.SelectedItem == "Tribuna")
                cmbSpecifica.ItemsSource = Tribuna;
            if (cmbSettore.SelectedItem == "Curva")
                cmbSpecifica.ItemsSource = Curva;
            if (cmbSettore.SelectedItem == "Distinti")
                cmbSpecifica.ItemsSource = Distinti;
        }
    }
}
