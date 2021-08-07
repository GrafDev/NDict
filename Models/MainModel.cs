using System;
using System.Collections.Generic;
using System.Text;
using NDict.Models;
using NDict.Views;
using NDict.ViewModels;
using NDict.ViewModels.Tests;

namespace NDict.Models
{
    class MainModel
    {
       
        internal void ReadTwoWindow()
        {
            var dBTestView = new DBTest();
            var dBTestViewModel = new DBTestViewModel();
            DataReader.GetResouce();
            dBTestViewModel.DataDBText = DataReader.text;

        }
    }
}
