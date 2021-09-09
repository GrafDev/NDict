using System;
using System.Collections.Generic;
using System.Text;

namespace NDict.ViewModels
{
    public class AddUserViewModel : BaseViewModel
    {

        private string userName = "Default";
        public string UserName { get => userName; set => Set(ref userName, value); }
        public AddUserViewModel()
        {

        }
    }
}
