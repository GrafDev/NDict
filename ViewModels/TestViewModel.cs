using System;
using System.Collections.Generic;
using System.Text;

namespace NDict.ViewModels
{
    public class TestViewModel : BaseViewModel
    {
        private string _testBlock = "Ok";
        public string TestBlock { get => _testBlock; set => Set(ref _testBlock, value); }
    }
}
