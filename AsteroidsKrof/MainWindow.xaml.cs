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
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Text.RegularExpressions;
using System.Collections.ObjectModel;

namespace AsteroidsKrof
{
    /// <summary>
    /// Interakční logika pro MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static RootObject AsteroidData;

        static API_Data info;

        public static ObservableCollection<Asteroid> AsteroidsO { get; set; }

        //Omlouvám se, že program není funkční. Spolupracoval jsem s kolegou Mihalovičem, ale i přesto se nám nepodařilo program zprovoznit.

        public MainWindow()
        {
            InitializeComponent();
            GetData();
        }

        private async void GetData()
        {
            string API_KEY = "fJs7EBzFWHxyYAN4PA8CMaAEWcYRzbTVyqfsqf1z";
            DateTime n = DateTime.Now;
            string odkaz = $"https://api.nasa.gov/neo/rest/v1/feed?start_date={n.Year}-{n.Month}-{n.Day}&end_date={n.Year}-{n.Month}-{n.Day}&api_key={API_KEY}";

            if (System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable() == true)
            {

                info = await APICaller.Get(odkaz);

                if (info.Data != null && info.Data != "")
                {
                    Regex reg = new Regex(@"\d{4}[-]\d{2}[-]\d{2}");
                    string database = reg.Replace(info.Data, "date", 1, 500);

                    AsteroidData = JsonConvert.DeserializeObject<RootObject>(database);
                    AsteroidsO = new ObservableCollection<Asteroid>(AsteroidData.near_earth_objects.asteroids);
                }

            }

        }
        private void Asteroid_List_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

        }

        private void Asteroid_List_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            InfoBox ib = new InfoBox();
            ib.ShowDialog();
        }
    }       
}
