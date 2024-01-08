namespace UserAPI.Commands.Dto
{
    public class UserDto
    {
        public UserDto(int id, string name, string email, string phone)
        {
            Id = id;
            Name = name;
            Email = email;
            Phone = phone;
        }

        public int Id { get; protected set; }
        public string Name { get; protected set; }
        public string Email { get; protected set; }
        public string Phone { get; protected set; }
    }
}
