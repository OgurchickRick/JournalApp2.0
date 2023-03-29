using JournalApp2._0.Infrastructure.Commands.Base;
using JournalApp2._0.Views.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace JournalApp2._0.Infrastructure.Commands
{
    internal class BackToHomeCommand : Command
    {

        public override bool CanExecute(object parameter) => true;

        public override void Execute(object parameter) 
        {
            var home = new MainWindow();

            home.Show();

            var window = Application.Current.Windows[0];
            if (window != null)
            {
                window.Close();
            }
        }
    }
}
