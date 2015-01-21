using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Windows.Input;
using Microsoft.Practices.Prism.Commands;

namespace FirstModule.ViewModel
{
   public class TheFirstViewModel : INotifyPropertyChanged
    {
        public ICommand OkCommand
        {
            get;
            private set;
        }
        public ICommand OkWithParamCommand
        {
            get;
            private set;
        }
        public event PropertyChangedEventHandler PropertyChanged;

        private string _myProperty;
        public string MyProperty
        {
            get
            {
                return _myProperty;
            }
            private set
            {
                _myProperty=value;
                NotifyPropertyChange("MyProperty");
            }
        }

        private void NotifyPropertyChange(string p)
        {
           PropertyChanged(this, new PropertyChangedEventArgs(p));
        }

        public TheFirstViewModel()
        {
            OkWithParamCommand = new DelegateCommand<string>(ExecuteOkWithParam, CanExecuteOkWithParam);
            OkCommand = new DelegateCommand(ExecuteOk, CanExecuteOk);
        }


        public void ExecuteOkWithParam(string message)
        {
            if (message == "From_Button")
                MyProperty = "Hi there, from parameterized command!!";
        }

        public bool CanExecuteOkWithParam(string message)
        {
            return true;
        }

        public void ExecuteOk()
        {
            MyProperty = "Hi there, from command!!";
        }

        public bool CanExecuteOk()
        {
            return true;
        }
    }
}
