namespace EntityFramework.Extension.Tests
{
    public class RepositoryTests
    {
        readonly IRepository<User> _userRepository;

        public RepositoryTests(IRepository<User> userRepository)
        {
            this._userRepository = userRepository;
        }

        public void Query()
        {
            var users = _userRepository.GetAll();
        }
    }
}
