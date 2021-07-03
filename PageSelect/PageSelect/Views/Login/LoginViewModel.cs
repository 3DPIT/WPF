using PageSelect.FrameWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageSelect.Views.Login
{
    public partial class LoginViewModel:ViewModelBase
    {
        private MainViewModel _mainViewModel;
        public LoginViewModel(MainViewModel mainViewModel)
        {
            _mainViewModel = mainViewModel;
            Login = new CommandBase(OnLogin);
        }
    }
}
