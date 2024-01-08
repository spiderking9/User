namespace UserDomain.AggregateModels
{
    public class User
    {
        public User(string name, string email, string phone, bool status, DateTime dateTime)
        {
            Name = name;
            Email = email;
            Phone = phone;
            Status = status;
            DateTime = dateTime;
        }
        public User(string name, string email, string phone)
        {
            Name = name;
            Email = email;
            Phone = phone;
            Status = true;
            DateTime = DateTime.Now;
        }

        public int Id { get; protected set; }
        public string Name { get; protected set; }
        public string Email { get; protected set; }
        public string Phone { get; protected set; }
        public bool Status { get; protected set; }
        public DateTime DateTime { get; protected set; }

        public User Update(string? name = null, string? email = null, string? phone = null)
        {
            if (!string.IsNullOrEmpty(name)) Name = name;
            if (!string.IsNullOrEmpty(email)) Email = email;
            if (!string.IsNullOrEmpty(phone)) Phone = phone;

            return this;
        }
    }
}
