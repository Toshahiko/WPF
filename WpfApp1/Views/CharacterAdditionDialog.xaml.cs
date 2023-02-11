// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WpfApp1.ViewModels;

namespace WpfApp1.Views
{
  /// <summary>
  /// CharacterAdditionDialog.xaml の相互作用ロジック
  /// </summary>
  public partial class CharacterAdditionDialog : Window
  {
    public CharacterAdditionDialog( CharacterAdditionViewModel vm )
    {
      DataContext = vm;
      InitializeComponent();
    }

    private void OnEditButton_Click(object sender, RoutedEventArgs e)
    {
      var index = DataGrid1.Items.IndexOf(DataGrid1.CurrentItem);

      var vm = (CharacterAdditionViewModel)DataContext;
      vm.EditItem(index);
    }
  }
}
