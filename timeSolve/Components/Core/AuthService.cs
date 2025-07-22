using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace timeSolve.Components.Core
{
    public class AuthService
    {
        private bool _isLoggedIn;

        public bool IsLoggedIn => _isLoggedIn;

        public Task<bool> LoginAsync(string username, string password)
        {
            if (username == "admin" && password == "1234")
            {
                _isLoggedIn = true;
                return Task.FromResult(true);
            }

            return Task.FromResult(false);
        }

        public void Logout()
        {
            _isLoggedIn = false;
        }
    }

}
