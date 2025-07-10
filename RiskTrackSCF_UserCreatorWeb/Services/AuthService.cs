using Microsoft.AspNetCore.Mvc;
using RiskTrackSCF_UserCreatorWeb.Models;

namespace RiskTrackSCF_UserCreatorWeb.Services
{
    public class AuthService
    {
        public UserSession? CurrentUser { get; private set; }

        public bool IsAuthenticated => CurrentUser != null;
        public bool IsAdmin => CurrentUser?.Role == "A";

        public void Login(User user)
        {
            CurrentUser = new UserSession
            {
                UserId = user.UserId,
                Username = user.Username,
                Role = user.Role
            };
        }

        public void Logout()
        {
            CurrentUser = null;
        }
    }
}
