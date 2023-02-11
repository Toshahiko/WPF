using System.Windows;
using WpfApp1.ViewModels;

namespace WpfApp1.Views
{
  /// <summary>
  /// Window1.xaml の相互作用ロジック
  /// </summary>
  public partial class TestDialog : Window
  {
    public TestDialog( TestViewModel viewModel)
    {
      DataContext = viewModel;
      InitializeComponent();
    }
  }
}
