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
using Newtonsoft.Json;

namespace AsteroidsKrof
{
    /// <summary>
    /// Interakční logika pro MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Omlouvám se, že jsem projekt nedokončil, bohužel jsem po usilovném zkoušení nedokázal přijít na to, jak implementovat API do mého programu.
        public MainWindow()
        {
            InitializeComponent();
            string API_Key = "fJs7EBzFWHxyYAN4PA8CMaAEWcYRzbTVyqfsqf1z";
            DateTime n = DateTime.Now;
            string link = $"https://api.nasa.gov/neo/rest/v1/feed?start_date={n.Year}-{n.Month}-{n.Day}&end_date={n.Year}-{n.Month}-{n.Day}&api_key={API_Key}";          
        }

        private void Asteroid_List_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

        }

        private void Asteroid_List_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
