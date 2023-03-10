// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.ComponentModel;
using System.Reactive.Linq;
using Reactive.Bindings;
using WpfApp1.Models;

namespace WpfApp1.ViewModels
{
  public class CharacterAdditionViewModel
  {
    public ReadOnlyReactiveCollection<BindableItem<ICharacter>> Characters { get; }
    public ReactiveCommand AddCommand { get; }
    private CharacterAdditionModel _model;

    public CharacterAdditionViewModel( CharacterAdditionModel model )
    {
      _model = model;
      Characters = _model.Characters.ToReadOnlyReactiveCollection();
      AddCommand = new ReactiveCommand();
      AddCommand.Subscribe( _ => _model.Characters.Add( new BindableItem<ICharacter>( new Warior( "Yamosu") )));
    }

    public void EditItem( int index )
    {
      if (_model.Characters[index].Value is Warior )
      {
        _model.Characters[index].Value = new Wizard("Buhin");
      } else
      {
        _model.Characters[index].Value = new Warior("Yamosu");

      }
    }
  }
}
