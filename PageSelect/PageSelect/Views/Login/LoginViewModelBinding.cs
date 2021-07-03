using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageSelect.Views.Login
{
    public partial class LoginViewModel//Binding
    {
        private string _id;
        public string Id
        {
            get { return _id; }
            set
            {
                _id= value;
                OnPropertyChanged();
            }
        }
        private string _password;
        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
                OnPropertyChanged();
            }
        }
    }
}
