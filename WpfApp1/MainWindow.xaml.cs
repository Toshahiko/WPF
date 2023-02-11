using System;
using System.Windows;
using WpfApp1.Models;
using WpfApp1.ViewModels;
using WpfApp1.Views;

namespace WpfApp1
{
  /// <summary>
  /// MainWindow.xaml の相互作用ロジック
  /// </summary>
  public partial class MainWindow : Window
  {
    public MainWindow()
    {
      InitializeComponent();
    }


    private void MenuItem_Click11(object sender, RoutedEventArgs e)
    {
      var person = new Person("Buhin");
      var viewModel = new TestViewModel(person);
      var dialog = new TestDialog(viewModel);
      dialog.ShowDialog();

    }

    private void MenuItem_Click12(object sender, RoutedEventArgs e)
    {
      var model = new CharacterAdditionModel();
      var vm = new CharacterAdditionViewModel(model);
      var dialog = new CharacterAdditionDialog(vm);
      dialog.ShowDialog();


      foreach( var chara in model.Characters )
      {
        Console.WriteLine( chara );
      }
    }

  }
}
