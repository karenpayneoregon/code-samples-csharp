using System.ComponentModel.DataAnnotations;
using ValidateLogin.Classes.ValidationRules;

namespace ValidateLogin.Classes
{
    public class CustomerLogin
    {
        /// <summary>
        /// User name
        /// </summary>
        /// <returns>User name for login</returns>
        [Required(ErrorMessage = "{0} is required"), DataType(DataType.Text)]
        [StringLength(10, MinimumLength = 6)]
        public string UserName { get; set; }
        /// <summary>
        /// User password which must match PasswordConfirmation using
        /// PasswordCheck attribute
        /// </summary>
        /// <returns>plain text password</returns>
        [Required(ErrorMessage = "{0} is required"), DataType(DataType.Text)]
        [StringLength(20, MinimumLength = 6)]
        [PasswordCheck(ErrorMessage = "Must include a number and symbol in {0}")]
        public string Password { get; set; }
        /// <summary>
        /// Confirmation of user password
        /// </summary>
        /// <returns>plain text password</returns>
        [Compare("Password", ErrorMessage = "Passwords do not match, please try again"), DataType(DataType.Text)]
        [StringLength(20, MinimumLength = 6)]
        public string PasswordConfirmation { get; set; }
        public override string ToString() => UserName;

    }
}
