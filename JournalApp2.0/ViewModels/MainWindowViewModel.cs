using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media.Animation;
using JournalApp2._0.Infrastructure.Commands;
using JournalApp2._0.ViewModels.Base;


namespace JournalApp2._0.ViewModels
{
    internal class MainWindowViewModel: ViewModel
    {
        private string title = "Окно";

        public string Title
        {
            get => title;
            set { Set(ref title, value); }
        }


        #region Команды

        #region CloseApplicationCommand
        public ICommand CloseApplicationCommand { get;  }

        
        private void OnCloseApplicationCommandExecuted(object p)
        {
            Application.Current.Shutdown();
        }


        private bool CanCloseApplicationCommandExecuted(object p) => true;
        #endregion

        #endregion

        public MainWindowViewModel()
        {
            #region Команды

            CloseApplicationCommand = new LambdaCommand(OnCloseApplicationCommandExecuted, CanCloseApplicationCommandExecuted);

            #endregion

        }
    }
   
}
