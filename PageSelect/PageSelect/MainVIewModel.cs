using PageSelect.FrameWork;
using PageSelect.Views.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageSelect
{
    public class MainViewModel : ViewModelBase
    {
        private ViewModelBase _selectedViewModel;
        public ViewModelBase SelectedViewModel
        {
            get { return _selectedViewModel; }
            set
            {
                _selectedViewModel = value;
                OnPropertyChanged();
            }
        }
        public MainViewModel()
        {
            SelectedViewModel = new LoginViewModel(this);
        }
    }
}
