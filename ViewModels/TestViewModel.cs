using System;
using System.Collections.Generic;
using System.Text;
using NDict.Models;

namespace NDict.ViewModels
{
    public class TestViewModel : BaseViewModel
    {
        #region fields
        private string _testBlock="Ok";
        public string TestBlock { get => _testBlock; set => Set(ref _testBlock, value); }
        #endregion

        public TestViewModel()
        {
           
        }
        

    }


}
