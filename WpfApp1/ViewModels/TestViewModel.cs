// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Reactive.Bindings;
using Reactive.Bindings.Extensions;
using WpfApp1.Models;

namespace WpfApp1.ViewModels
{
  public class TestViewModel
  {
    public Person Person { get; }
    public ReactiveProperty<string> Name { get; set; }
    public TestViewModel(Person person)
    {
      Person = person;
      Name = person.ToReactivePropertyAsSynchronized(m => m.Name);
    }
  }
}
