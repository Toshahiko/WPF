using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

public class BindableBase : INotifyPropertyChanged
{
  public event PropertyChangedEventHandler PropertyChanged;

  protected void RaisePropertyChanged([CallerMemberName] string propertyName = null) =>
      PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

  protected void SetProperty<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
  {

    field = value;
    RaisePropertyChanged(propertyName);
  }
}
