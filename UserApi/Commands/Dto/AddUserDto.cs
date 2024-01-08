namespace UserAPI.Commands.Dto
{
    public class AddUserDto
    {
        public AddUserDto(string name, string email, string phone)
        {
            Name = name;
            Email = email;
            Phone = phone;
        }

        public string Name { get; protected set; }
        public string Email { get; protected set; }
        public string Phone { get; protected set; }
    }
}
