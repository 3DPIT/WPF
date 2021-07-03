using PageSelect.Views.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PageSelect.Views.Login
{
    public partial class LoginViewModel //Command
    {
        public ICommand Login { get; }
        private void OnLogin(object parameter)
        {
            _mainViewModel.SelectedViewModel = new HomeViewModel(_mainViewModel);
        }
    }
}
