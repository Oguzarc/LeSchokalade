namespace LeSchokalade.User
{
    public class User
    {
        public string Nickname { get; set; }
        public string Password { get; set; }
    }

    public class Session
    {
        private static Session _Instance;

        public static Session Instance
        {
            get
            {
                if(_Instance == null)
                {
                    _Instance = new Session();
                }
                return (_Instance);
            }
        }
        private Session()
        {

        }
        public User user = new User();
        public bool logged
        {
            get
            {
                if (user.Nickname != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

        }

        public void clear()
        {
            user.Nickname = null;
        }
    }
}
