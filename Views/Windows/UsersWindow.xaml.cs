using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using NDict.Infrastructure.Commands.ChoiseProfileCommand;

namespace NDict.Views.Windows
{
    /// <summary>
    /// Логика взаимодействия для UsersWindow.xaml
    /// </summary>
    public partial class UsersWindow : Window
    {
        public UsersWindow()
        {
            InitializeComponent();
            this.PreviewKeyDown += new KeyEventHandler(OnKeyDownHandler);
        }
        private void titleBar_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void OnKeyDownHandler(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                var commandOk = new OkProfileCommand();
                commandOk.Action(true);
            }

            if (e.Key == Key.Escape)
            {
                var commandCancel = new OkProfileCommand();
                commandCancel.Action(false);
            }
        }
    }
}
