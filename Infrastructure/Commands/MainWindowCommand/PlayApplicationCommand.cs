using System;
using System.Collections.Generic;
using System.Text;
using NDict.Infrastructure.Commands.Base;
using NDict.Views;
using NDict.Views.Windows;
using NDict.Models;

namespace NDict.Infrastructure.Commands.MainWindowCommand

{
    class PlayApplicationCommand : Command
    {
        TestWindow testWindow;
        public override bool CanExecute(object parameter) => true;

        public override void Execute(object parameter)
        {
            testWindow = new TestWindow();
            testWindow.Show();
            testWindow.Activate();
            _Test();
        }
        void _Test()

        {

            NDictionary.Loaded();
            //////Knobs.Loaded();
            //App.TestVM.TestBlock = "sdfsd";
            //App.TestVM.TestBlock = NDictionary.Words[0].Language01.ToString();
            ////TODO: неободимо решить как связать тестовое поле с другими данными (service)
            ////testViewModel.TestBlock = Dictionary.Words.Count.ToString();

        }

    }
}
