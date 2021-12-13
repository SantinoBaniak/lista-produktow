using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;
using System.Windows.Data;

namespace lista_produktow
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
   
    {
        private ObservableCollection<Produkt> ListaProduktow = null;
        public MainWindow()
        {
            InitializeComponent();
            PrzygotujWizanie();
        }
        
        private void PrzygotujWizanie()
        {
            ListaProduktow = new ObservableCollection<Produkt>();
            ListaProduktow.Add(new Produkt("01-11", "olowek", 8, "Karowice 1"));
            ListaProduktow.Add(new Produkt("PW-20", "pioro wieczne", 75, "Katowice 2"));
            ListaProduktow.Add(new Produkt("DZ-10", "dlugopis zelowy", 1121, "Katowice 1"));
            ListaProduktow.Add(new Produkt("DZ-12", "Dlugopis kulkowy", 280, "Katowice 2"));
            lstProdukty.ItemsSource = ListaProduktow;

            CollectionView widok = (CollectionView)CollectionViewSource.GetDefaultView(lstProdukty.ItemsSource);
            widok.SortDescriptions.Add(new SortDescription("Magazyn", ListSortDirection.Descending));
        }

        private void lstProdukty_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {

        }
    }
}
       
        
         
