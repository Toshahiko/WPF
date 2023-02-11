﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Models
{
  public class Wizard : BindableBase, ICharacter
  {
    private string _name;

    public Wizard(string name)
    {
      _name = name;
    }

    private string _job => nameof(Wizard);

    public string Name { get => _name; private set => _name = value; }

    public string Job { get => _job; }
    public bool IsEnable { get; set; } = false;
  }
}