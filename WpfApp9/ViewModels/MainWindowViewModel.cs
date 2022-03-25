using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using WpfApp9.Models;

namespace WpfApp9.ViewModels
{
    internal class MainWindowViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged([CallerMemberName] string PropertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }

        private double number1;
        public double Number1
        {
            get => number1;
            set
            {
                number1 = value;
                OnPropertyChanged();
            }
        }

        private double number3;
        public double Number3
        {
            get => number3;
            set
            {
                number3 = value;
                OnPropertyChanged();
            }
        }

        public ICommand CircumferenceLengthCommand { get; }

        private void OnCircumferenceLengthCommandExecute(object p)
        {
            Number3 = Ariph.CircumferenceLength(Number1);
        }

        private bool CanCircumferenceLengthCommandExecuted(object p)
        {
            //if (Number1 != 0)
            //    return true;
            //else
            //    return false;
            return true;
        }

        public MainWindowViewModel()
        {
            CircumferenceLengthCommand = new RelayCommand(OnCircumferenceLengthCommandExecute, CanCircumferenceLengthCommandExecuted);
        }
    }
}
