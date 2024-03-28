using System;
using System.Text.RegularExpressions;

namespace Domain.Entities
{
    public class User
    {
        public int Id { get; set; }
        private string _Name;

        public string Name
        {
            get { return _Name; }
            set
            {
                ValidateName(value); _Name = value;
            }
        }
        
        private string _Email { get; set; }
        public string Email
        {
            get { return _Email; }
            set
            {
                ValidateEmail(value); _Email = value;
            }
        }
        private string _Password { get; set; }
        public string Password
        {
            get { return _Password; }
            set
            {
                ValidatePassword(value); _Password = value;
            }
        }

        #region Validations

        private void ValidateEmail(string Email)
        {
            // Simple regex for email validation
            if (!Regex.IsMatch(Email, @"^\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}$"))
            {
                throw new Exception("Please, inform a valid email.");
            }
        }

        private void ValidatePassword(string Password)
        {
            // Checks for minimum length of 8 and at least one number
            if (Password.Length < 8 && !Regex.IsMatch(Password, @"\d+"))
            {
                throw new Exception("Please, inform a valid password.");
            }
        }

        private void ValidateName(string Name)
        {
            if (string.IsNullOrWhiteSpace(Name))
                throw new Exception("Please, inform a name.");

            if (Name.Length <= 3)
                throw new Exception("Name should have at least 3 chars.");

            if (Name.Length >= 100)
                throw new Exception("Name should have no more than 100 chars.");
        }
        #endregion
    }
}
