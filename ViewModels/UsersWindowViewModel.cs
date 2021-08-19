using System;
using System.Collections.Generic;
using System.Text;
using NDict.Services;

namespace NDict.ViewModels
{
    class UsersWindowViewModel
    {
        ApplicationContext db;

        public UsersWindowViewModel() 
        {
            db = new ApplicationContext();
        }

    }
}
