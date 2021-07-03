using PageSelect.FrameWork;
using PageSelect.Views.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PageSelect.Views.Home
{
    public class HomeViewModel : ViewModelBase
    {
        public ICommand Logout { get; }

        private MainViewModel _mainViewModel;

        public HomeViewModel(MainViewModel mainViewModel)
        {
            _mainViewModel = mainViewModel;

            Logout = new CommandBase(OnLogout);
        }

        private void OnLogout(object parameter)
        {
            _mainViewModel.SelectedViewModel = new LoginViewModel(_mainViewModel);
        }
    }
}
