using Reactive.Bindings;
using Reactive.Bindings.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TranferData2Form2.Model;

namespace TranferData2Form2.ViewModel
{
  public class UserViewModel
  {
    public ReactiveProperty<string> fSize { get; set; } = new ReactiveProperty<string>();
    public ReactiveProperty<string> Text { get; set; } = new ReactiveProperty<string>();
    int i = 0;
    public UserViewModel(DataModel model)
    {
      fSize = model.ToReactivePropertyAsSynchronized(
             m => m.X,
             x => x.ToString(),
             s => s,
             ReactivePropertyMode.DistinctUntilChanged
                 | ReactivePropertyMode.RaiseLatestValueOnSubscribe,
             true)
             .SetValidateAttribute(() => fSize);
      if (i==0)
      {
        Text.Value = "ABC";
      }
    }
  }
}
