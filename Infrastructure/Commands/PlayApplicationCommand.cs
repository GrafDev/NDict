using System;
using System.Collections.Generic;
using System.Text;
using NDict.Models;
using NDict.Infrastructure.Commands.Base;
using NDict.Infrastructure;
using System.Windows;


namespace NDict.Infrastructure.Commands
{
    class PlayApplicationCommand: Command
    {
        public override bool CanExecute(object parameter) => true;
        public override void Execute(object parameter) => DataReader.GetResouce();
    }
}
