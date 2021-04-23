namespace OpenVPN
{
    public class User
    {
        public string name;
        public string pass;

        public User(string name, string pass)
        {
            this.name = name;
            this.pass = pass;
        }
    }
}