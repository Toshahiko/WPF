// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Models
{
  public class Wizard : ICharacter
  {
    private string _name;
    private bool _isEnable = false;
    public Wizard(string name)
    {
      _name = name;
    }

    private string _job => nameof(Wizard);
    public string Job { get => _job; }

    //public string Name { get => _name; set => SetProperty(ref _name, value); }
    public string Name { get => _name; set => _name = value; }

    //public bool IsEnable { get => _isEnable; set => SetProperty(ref _isEnable, value); }

    public bool IsEnable { get => _isEnable; set => _isEnable = value; }

  }
}
