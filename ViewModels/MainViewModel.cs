using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;

namespace HelloWPF.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private string _message = "Hello, WPF!";

        public string Message
        {
            get => _message;
            set
            {
                if (_message != value)
                {
                    _message = value;
                    OnPropertyChanged();
                }
            }
        }

        public ICommand ShowMessageCommand { get; }

        public MainViewModel()
        {
            ShowMessageCommand = new RelayCommand(_ => ShowMessage());
        }

        private void ShowMessage()
        {
            MessageBox.Show(Message);
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
