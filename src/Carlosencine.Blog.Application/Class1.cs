using System;

namespace Carlosencine.Blog.Application
{
    public class Class1
    {
        public void Test()
        {
            var myuser = new User()
            {
                Name = "Carlos",
                Email = "contato@carlosencine.com"
            };

            var userAdapted = new UserAdapter();

            userAdapted.Adapt(myuser);
        }
    }
}
