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
        public string TitleBlock { get => _testBlock; set => Set(ref _testBlock, value); }
        #endregion

        private List<Word> listOfWordsLerning = new List<Word>();
        public List<Word> ListOfWordsLearning { get => listOfWordsLerning; set => Set(ref listOfWordsLerning, value); }

        private string _test2;
        public string Test2 { get => _test2; set => Set(ref _test2, value); }

        public TestViewModel()
        {
           
        }
        

    }


}
