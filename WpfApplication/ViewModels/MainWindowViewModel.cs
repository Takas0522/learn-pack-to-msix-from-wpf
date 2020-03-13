using System;
using System.Collections.Generic;
using System.Text;
using WpfApplication.Models;
using WpfApplication.Util;

namespace WpfApplication.ViewModels
{
    public class MainWindowViewModel: ViewModelBase
    {
        public MainWindowViewModel()
        {
            Data = new MainWindowModel();
            WireCommands();
        }

        private void WireCommands()
        {
            SubmitCommand = new RelayCommand(Submit);
        }

        // Property
        private MainWindowModel _data = null;
        public MainWindowModel Data
        {
            get { return _data; }
            set
            {
                if (_data != null && _data.Equals(value)) { return; }
                _data = value;
                OnPropertyChanged(nameof(Data));
            }
        }


        // Command
        public RelayCommand SubmitCommand
        {
            get;
            private set;
        }

        public delegate void SubmitEventHandler(object sender, SubmitEventArgs e);
        public event SubmitEventHandler SubmitDialog;

        public void Submit()
        {
            SubmitEventArgs ret = new SubmitEventArgs { InputText = "HOGE" };
            SubmitDialog(this, ret);
        }
    }
}
