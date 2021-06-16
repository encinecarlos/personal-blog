namespace Carlosencine.Blog.Application
{
    public class UserAdapter
    {
        public CustomUser Adapt(User input)
        {
            return new CustomUser()
            {
                Name = input.Name,
                Email = input.Email,
                Address = "meu endereço",
                Phone = "123456789"
            };
        }
    }
}