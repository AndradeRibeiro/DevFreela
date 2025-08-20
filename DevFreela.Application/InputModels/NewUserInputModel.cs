namespace DevFreela.Application.InputModels
{
    public class NewUserInputModel
    {
        public string FullName { get; private set; }
        public string Password { get; private set; }
        public string Email { get; private set; }
        public DateTime BirthDate { get; private set; }

        public NewUserInputModel(string fullName, string password, string email, DateTime birthDate)
        {
            FullName = fullName;
            Password = password;
            Email = email;
            BirthDate = birthDate;
        }
    }
}
