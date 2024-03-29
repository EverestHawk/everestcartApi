﻿namespace Services.ViewModels
{
    public class UserViewModel
    {
        public int Id { get; set; }
        public string IdentityId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Token { get; set; }
        public string AccessToken { get; set; }
        public double ExpiresIn { get; set; }
    }
}
