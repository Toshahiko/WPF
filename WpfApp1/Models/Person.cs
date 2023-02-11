// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace WpfApp1.Models
{
  public class Person : BindableBase
  {

    private string _name;
    public string Name { 
      get => _name;
      //set => _name = value ;
      set => SetProperty(ref _name, value);
    }
    public Person( string name )
    {
      Name = name;
    }
  }
}
