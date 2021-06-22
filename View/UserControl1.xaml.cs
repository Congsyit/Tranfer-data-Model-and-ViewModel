using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TranferData2Form2.Model;
using TranferData2Form2.ViewModel;

namespace TranferData2Form2.View
{
  /// <summary>
  /// UserControl1.xaml の相互作用ロジック
  /// </summary>
  public partial class UserControl1 : UserControl
  {
    public UserControl1(DataModel model)
    {
      InitializeComponent();
      DataContext = new UserViewModel(model);
    }
  }
}
