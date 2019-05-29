using FrameApplication.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FrameApplication.ViewModels
{
    public partial class MianWindowViewModel : ViewModelBase
    {
        private ICommand _doSomething;
        public ICommand DoSomethingCommand
        {
            get
            {
                if (_doSomething == null)
                {
                    _doSomething = new CommonCommand(
                        p => CanExecute,
                        p => Execute());
                }
                return _doSomething;
            }
        }
    }
}
