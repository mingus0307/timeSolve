using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace timeSolve.Components.Core
{
    public class AuthService
    {   //TODO: Build a proper Authentification with .NET Identity 
        public bool IsLoggedIn { get; private set; } = false;

        public event Action? OnChange;

        public void Login()
        {
            IsLoggedIn = true;
            OnChange?.Invoke();
        }

        public void Logout()
        {
            IsLoggedIn = false;
            OnChange?.Invoke();
        }
    }
}
