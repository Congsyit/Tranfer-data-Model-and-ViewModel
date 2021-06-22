using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranferData2Form2.Model
{
  public class DataModel : BindableBase
  {
    private string _x = "";
    public string X
    {
      get { return _x; }
      set { SetProperty(ref _x, value); }
    }
  }
}
