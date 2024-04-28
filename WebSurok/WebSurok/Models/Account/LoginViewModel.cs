﻿namespace WebSurok.Models.Account
{
    public class LoginViewModel
    {
        /// <summary>
        /// Логін користувача
        /// </summary>
        /// <example>admin@gmail.com</example>
        public string Email { get; set; }
        /// <summary>
        /// Логін користувача
        /// </summary>
        /// <example>123456</example>
        public string Password { get; set; }
    }
}
