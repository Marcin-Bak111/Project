using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace ComboBoxProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public List<string> listOfItems { get; set; }

        public List<OwnColor> ListOfOwnColors { get; set; }
        
        public MainWindow()
        {
            ListOfOwnColors = new List<OwnColor>();
            ListOfOwnColors.Add(new OwnColor()
            {
                NameOfColor_Pol = "Zielony",
                NameOfColor_Eng = "Green"
            });

            ListOfOwnColors.Add(new OwnColor()
            {
                NameOfColor_Pol = "Złoty",
                NameOfColor_Eng = "Gold"
            });

            ListOfOwnColors.Add(new OwnColor()
            {
                NameOfColor_Pol = "Czerwony",
                NameOfColor_Eng = "Red"
            });
            InitializeComponent();
            listOfItems = new List<string>();
            listOfItems.Add("Pozycja bindowania 0");
            listOfItems.Add("Pozycja bindowania 1");
            listOfItems.Add("Pozycja bindowania 2");
            OnPropertyChanged(nameof(listOfItems));


        }
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
