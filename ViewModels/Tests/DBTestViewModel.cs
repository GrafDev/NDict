using System;
using System.Collections.Generic;
using System.Text;

namespace NDict.ViewModels.Tests
{
    class DBTestViewModel:BaseViewModel
    {
        string _Title;

        public string Title { get => _Title; set => Set(ref _Title, value);}

        string _DataDBText;

        public string DataDBText { get => _DataDBText; set => Set(ref _DataDBText, value); }

    }
}
