using System;
using System.Collections.Generic;
using System.Text;
using NDict.Infrastructure.Commands.Base;
using NDict.Infrastructure;
using System.Windows;

namespace NDict.Infrastructure.Commands.ChoiseProfileWindow
{
    class AddProfileCommand : Command
    {
        public override bool CanExecute(object parameter) => true;
        public override void Execute(object parameter)
        {

            //ЗАписать все изменения в базу данных юзеров

        }
    }
}
