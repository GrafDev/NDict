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
using NDict.ViewModels;
using NDict.Models;
using NDict.Services;
using NDict.Views.Windows;

namespace NDict
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {                       
            InitializeComponent();
        }
        private void titleBar_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        public void SetAligmentContentPlayButton(string _aligment)
        {
            if (_aligment == "Right")
            {
                this.Button_Play.HorizontalContentAlignment = HorizontalAlignment.Right;
            }
            else
            {
                this.Button_Play.HorizontalContentAlignment = HorizontalAlignment.Center;
            }
            
        }
    }
}