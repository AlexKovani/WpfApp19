using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfApp19.Models;

namespace WpfApp19.ViewModels
{
    public class MainWindowViewsModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged(string PropertyName=null)
        {
            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }

        private int number1;
        public int Number1
        {
            get => number1;
            set
            {
                number1 = value;
                OnPropertyChanged();
            }
        }

        private int number2;
        public int Number2
        {
            get => number2;
            set
            {
                number2 = value;
                OnPropertyChanged();
            }
        }

        public ICommand AddCommand { get; }
        private void OnAddCommandExecute(object p)
        {
            Number2 = Arif.Add(Number1);
        }
        private bool CanOnAddCommandExecute(object p)
        {
            if (Number1 !=0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public MainWindowViewsModel()
        {
            AddCommand = new RelayCommand(OnAddCommandExecute, CanOnAddCommandExecute);
        }

    }

}
