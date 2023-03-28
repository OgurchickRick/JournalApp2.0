using JournalApp2._0.Infrastructure.Commands;
using JournalApp2._0.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace JournalApp2._0.ViewModels
{
    internal class DomashkaWindowViewModel : ViewModel
    {
        private int a = 0;
        public int A
        {
            get => a;
            set { Set(ref a, value); }
        }
        private int b = 0;
        public int B
        {
            get => b;
            set { Set(ref b, value); }
        }
        private int c = 0;
        public int C
        {
            get => c;
            set { Set(ref c, value); }
        }
        private int d = 0;
        public int D
        {
            get => d;
            set { Set(ref d, value); }
        }
        private int e = 0;
        public int E
        {
            get => e;
            set { Set(ref e, value); }
        }
        private int f = 0;
        public int F
        {
            get => f;
            set { Set(ref f, value); }
        }
        private int g = 0;
        public int G
        {
            get => g;
            set { Set(ref g, value); }
        }
        private int s1 = 0;

        private int p1 = 0;

        private int s2 = 0;

        private int p2 = 0;

        private int s3 = 0;

        private int p3 = 0;

        private int s = 0;
        public int S
        {
            get => s;
            set { Set(ref s, value);}
        }



        #region Команды

        #region ResultCommand
        public ICommand ResultCommand { get; }


        private void OnResultCommandExecuted(object p)
        {
            p1 = (A + B + G) / 2;
            p2 = (G + C + F) / 2;
            p3 = (F + E + D) / 2;
            s1 = (int)Math.Sqrt(p1*(p1-A)*(p1-B)*(p1-G));
            s2 = (int)Math.Sqrt(p2 * (p2 - G) * (p2 - C) * (p2 - F));
            s3 = (int)Math.Sqrt(p3 * (p3 - F) * (p3 - E) * (p3 - D));
            S = s1 + s2 + s3;
        }


        private bool CanResultCommandExecuted(object p) => true;
        #endregion
        #endregion


        public DomashkaWindowViewModel()
        {
            #region Команды

            ResultCommand = new LambdaCommand(OnResultCommandExecuted, CanResultCommandExecuted);

            #endregion
        }
    }
}
