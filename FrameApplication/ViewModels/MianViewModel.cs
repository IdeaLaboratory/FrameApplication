using Caliburn.Micro;
using System.Diagnostics;

namespace FrameApplication.ViewModels
{
    public partial class MainViewModel : Screen //: Screen (opening closing events are already available) OR
    {
        private string _text = "Default text";
        public string AppTitle { get; set; } = "FrameApplication";
        public string Text
        {
            get
            {
                return _text;
            }
            set
            {
                _text = value;
                NotifyOfPropertyChange(() => Text);
            }
        }

        public void Execute()
        {
            Trace.WriteLine("Execute command");
        }
    }
}