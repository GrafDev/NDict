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
        private string _testBlock;
        private bool FlagShowWindow = false;
        private string TestBlock { get => _testBlock; set => Set(ref _testBlock, value); }
        #endregion

        public TestViewModel()
        {
        }



        public void ShowTestWindow<T>(T elem)
        {
            TestBlock = TestBlock + elem.ToString()+"\n";
            if (!FlagShowWindow)
            {
                var testWindow = new TestWindow();
                testWindow.Activate();
                testWindow.Show();
                FlagShowWindow = true;
            }

        }

    }


}
