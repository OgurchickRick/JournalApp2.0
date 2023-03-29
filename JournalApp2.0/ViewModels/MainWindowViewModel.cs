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
using JournalApp2._0.Views.Windows;

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

        #region SwithToSecondWindowComand

        public ICommand SwithToSecondWindowComand { get; }


        private void OnSwithToSecondWindowComandExecuted(object p)
        {
            var domashkaWindow = new DomashkaWindow();

            domashkaWindow.Show();

            var window = Application.Current.Windows[0];
            if (window != null)
            {
                window.Close();
            }
        }


        private bool CanSwithToSecondWindowComandExecuted(object p) => true;


        #endregion

        #region SwithToDsWindowComand

        public ICommand SwithToDsWindowComand { get; }


        private void OnSwithToDsWindowComandExecuted(object p)
        {
            var dsWindow = new DsWindow();

            dsWindow.Show();

            var window = Application.Current.Windows[0];
            if (window != null)
            {
                window.Close();
            }
        }


        private bool CanSwithToDsWindowComandExecuted(object p) => true;


        #endregion

        #endregion

        public MainWindowViewModel()
        {
            #region Команды

            CloseApplicationCommand = new LambdaCommand(OnCloseApplicationCommandExecuted, CanCloseApplicationCommandExecuted);
            SwithToSecondWindowComand = new LambdaCommand(OnSwithToSecondWindowComandExecuted, CanSwithToSecondWindowComandExecuted);
            SwithToDsWindowComand = new LambdaCommand(OnSwithToDsWindowComandExecuted, CanSwithToDsWindowComandExecuted);

            #endregion

        }
    }
   
}
