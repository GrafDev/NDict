﻿using System;
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
using NDict.Infrastructure.Commands.Base;
using NDict.Views;
using NDict.Views.Windows;
using NDict.Models;
using System.Linq;
using NDict.Infrastructure.Commands.AddUserCommand;

namespace NDict.Views.Windows
{
    /// <summary>
    /// Логика взаимодействия для AddUserWindow.xaml
    /// </summary>
    public partial class AddUserWindow : Window
    {
        public AddUserWindow()
        {
            InitializeComponent();
            
            
        }
        private void titleBar_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }
         private void TextBox_KeyEnterUpdate(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                TextBox tBox = (TextBox)sender;
                DependencyProperty prop = TextBox.TextProperty;

                BindingExpression binding = BindingOperations.GetBindingExpression(tBox, prop);
                if (binding != null) { binding.UpdateSource(); }

                var commandOk = new OkAddUserCommand();
                commandOk.Action();
            }

            if (e.Key == Key.Escape)
            {
                var commandCancel = new CancelAddUserCommand();
                commandCancel.Action();
            }
        }

    }

}
