using Reactive.Bindings;
using Reactive.Bindings.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using TranferData2Form2.Model;
using TranferData2Form2.View;

namespace TranferData2Form2.ViewModel
{
  public class MainViewModel
  {
    DataModel _model = new DataModel();
    public ReactiveProperty<string> fSize { get; set; }
    public ReactiveProperty<object> UserCon { get; set; } = new ReactiveProperty<object>();

    public MainViewModel()
    {
      UserCon.Value = new UserControl1(_model);

      fSize = _model.ToReactivePropertyAsSynchronized(
       m => m.X,
       x => x.ToString(),
       s => s,
       ReactivePropertyMode.DistinctUntilChanged
           | ReactivePropertyMode.RaiseLatestValueOnSubscribe,
       true)
       .SetValidateAttribute(() => fSize);
    }
  
    //private void OnPropertyChanged([CallerMemberName] string propertyName = "")
    //{
    //  if (PropertyChanged != null)
    //  {
    //    PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
    //  }
    //}
    //private DataModel _FontSize;
    //public DataModel FontSize
    //{
    //  get { return _FontSize; }
    //  set
    //  {
    //    _FontSize = value;
    //    OnPropertyChanged();
    //  }
    //}

    //protected void myModel_PropertyChanged(object sender, PropertyChangedEventArgs e)
    //{
    //  if (e.PropertyName == "fontSize")
    //  {
    //    FontSize = _FontSize;
    //  }
    //}
  }
}
