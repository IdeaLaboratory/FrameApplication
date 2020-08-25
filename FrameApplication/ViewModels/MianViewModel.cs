using Caliburn.Micro;
using System.Diagnostics;

namespace FrameApplication.ViewModels
{
    public partial class MainViewModel : Screen //: Screen (opening closing events are already available) OR 
    {
        public string AppTitle { get; set; } = "FrameApplication";

        public void Execute()
        {
            Trace.WriteLine("Execute command");
        }
    }
}