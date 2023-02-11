// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;
using Reactive.Bindings;
using Reactive.Bindings.Extensions;
using WpfApp1.Models;

namespace WpfApp1.ViewModels
{
  public class CharacterAdditionViewModel
  {
    public ReadOnlyReactiveCollection<ICharacter> Characters { get; }
    public ReactiveCommand AddCommand { get; }
    private CharacterAdditionModel _model;

    public CharacterAdditionViewModel( CharacterAdditionModel model )
    {
      _model = model;
      Characters = _model.Characters.ToReadOnlyReactiveCollection();
      AddCommand = new ReactiveCommand();
      AddCommand.Subscribe( _ => _model.Characters.Add( new Warior( "name ")));
    }
  }
}
