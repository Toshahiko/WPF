// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reactive.Bindings;

namespace WpfApp1.Models
{
  public class CharacterAdditionModel
  {
    public ObservableCollection<BindableItem<ICharacter>> Characters { get; } = new ObservableCollection<BindableItem<ICharacter>>();

    public CharacterAdditionModel()
    {

    }
  }
}
