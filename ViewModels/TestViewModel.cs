using System;
using System.Collections.Generic;
using System.Text;
using NDict.Models;
using NDict.Views.Windows;

namespace NDict.ViewModels
{
    public class TestViewModel : BaseViewModel
    {
        #region fields
        private string _testBlock="1";
        private bool FlagShowWindow = false;
        private string TestBlock { get => _testBlock; set => Set(ref _testBlock, value); }
        #endregion

        public TestViewModel()
        {
        }

        public void ShowTestWindow<T>(T elem)
        {
            
            if (!FlagShowWindow)
            {
                var testWindow = new TestWindow();
                testWindow.Activate();
                testWindow.Show();
                FlagShowWindow = true;
            }
            TestBlock = TestBlock + elem.ToString() + "\n";
        }

    }


}
