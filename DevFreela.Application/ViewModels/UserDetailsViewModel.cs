namespace DevFreela.Application.ViewModels
{
    public class UserDetailsViewModel
    {
        public int Id { get; private set; }
        public string FullName { get; private set; }
        public string Email { get; private set; }
        public DateTime BirthDate { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public bool Active { get; set; }

        public UserDetailsViewModel(int id, string fullName, string email, DateTime birthDate, DateTime createdAt, bool active)
        {
            Id = id;
            FullName = fullName;
            Email = email;
            BirthDate = birthDate;
            CreatedAt = createdAt;
            Active = active;
        }
    }
}
