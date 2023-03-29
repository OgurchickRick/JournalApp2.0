using JournalApp2._0.Infrastructure.Commands;
using JournalApp2._0.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace JournalApp2._0.ViewModels
{
    internal class DsWindowViewModel : ViewModel
    {
        private int x1 = 0;
        private int y1 = 0;
        private int x2 = 0;
        private int y2 = 0;
        private int x3 = 0;
        private int y3 = 0;
        private int x4 = 0;
        private int y4 = 0;
        private int x5 = 0;
        private int y5 = 0;

        public int X1
        {
            get => x1;
            set { Set(ref x1, value); }
        }

        public int Y1
        {
            get => y1;
            set { Set(ref y1, value); }
        }

        public int X2
        {
            get => x2; 
            set{Set(ref x2, value); }
        }

        public int Y2
        {
            get => y2;
            set { Set(ref y2, value); }
        }

        public int X3
        {
            get => x3;
            set { Set(ref x3, value); }
        }

        public int Y3
        {
            get => y3;
            set { Set(ref y3, value); }
        }

        public int X4
        {
            get => x4;
            set { Set(ref x4, value); }
        }

        public int Y4
        {
            get => y4;
            set { Set(ref y4, value); }
        }

        public int X5
        {
            get => x5;
            set { Set(ref x5, value); }
        }

        public int Y5
        {
            get => y5;
            set { Set(ref y5, value); }
        }


        private int s1 = 0;
        private int s2 = 0;
        private int s3 = 0;

        private int s = 0;
        public int S
        {
            get => s;
            set { Set(ref s, value); }
        }

        #region Команды

        #region ResultCommand
        public ICommand ResultCommand { get; }


        private void OnResultCommandExecuted(object p)
        {
            s1 = Math.Abs((X2 - X1) * (Y5 - Y1) - (X5 - X1) * (Y2 - Y1)) / 2;
            s2 = Math.Abs((X2 - X5) * (Y3 - Y5) - (X3 - X5) * (Y2 - Y5)) / 2;
            s3 = Math.Abs((X4 - X5) * (Y3 - Y5) - (X3 - X5) * (Y4 - Y5)) / 2;
            S = s1 + s2 + s3;
        }


        private bool CanResultCommandExecuted(object p) => true;
        #endregion
        #endregion


        public DsWindowViewModel()
        {
            #region Команды

            ResultCommand = new LambdaCommand(OnResultCommandExecuted, CanResultCommandExecuted);

            #endregion
        }
    }
}
