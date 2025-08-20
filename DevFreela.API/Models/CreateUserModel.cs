namespace DevFreela.API.Models
{
    public class CreateUserModel
    {
        public string UserName { get; private set; }
        public string Password { get; private set; }
        public string ConfirmPassword { get; private set; }

        public CreateUserModel(string userName, string password, string confirmPassword)
        {
            UserName = userName;
            Password = password;
            ConfirmPassword = confirmPassword;
        }
    }
}
