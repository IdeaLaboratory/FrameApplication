using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameApplication.ViewModels
{
    public partial class MianWindowViewModel : ViewModelBase
    {
        public string AppTitle { get; set; } = "FrameApplication";

        public bool CanExecute { get; set; } = true;

        public void Execute()
        {
            Console.WriteLine("Execute command");
        }
    }
}