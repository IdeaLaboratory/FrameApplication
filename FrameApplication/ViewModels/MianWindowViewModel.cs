using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrameApplication.ViewModels
{
    public partial class MianWindowViewModel : ViewModelBase
    {
        public string AppTitle { get; set; } = "FrameApplication";

        public void Execute()
        {
            MessageBox.Show("hii");
            Trace.WriteLine("Execute command");
        }
    }
}