using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace WpfApp1 {
  public class ViewModel : INotifyPropertyChanged, ICommand {
    public string? info;
    public string Info {
      get => info;
      set {
        info = value;
        OnPropertyChanged("Info");
      }
    }

    public void Execute(object parameter) => Info = UserControlB.InfoB;

    public bool CanExecute(object parameter) => true;

    public event PropertyChangedEventHandler? PropertyChanged;

    public event EventHandler CanExecuteChanged;

    private void OnPropertyChanged([CallerMemberName] string propName = "") =>
      PropertyChanged(this, new PropertyChangedEventArgs(propName));
  }
}
