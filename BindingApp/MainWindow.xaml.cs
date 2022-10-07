﻿using System;
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

namespace BindingApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {

        public string Message { get; set; }

        private string _randomNumber;
        public string RandomNumber
        {
            get
            {
                return _randomNumber;
            }
            set
            {
                _randomNumber = value;
                OnPropertyChanged("RandomNumber");
            }
        
        }

        public MainWindow()
        {
            InitializeComponent();
        }
        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged (string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

        private void TextBoxValue_TextChanged(object sender, TextChangedEventArgs e)
        {
            textBlockValue.Text = textBoxValue.Text;
            buttonValue.Content = textBoxValue.Text;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(Message);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int randomNumber = new Random().Next();
            RandomNumber = randomNumber.ToString();
            
        }
    }
}
