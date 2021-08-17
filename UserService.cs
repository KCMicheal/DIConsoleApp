using System;
using System.Collections.Generic;
using System.Text;

namespace DIConsoleApp
{
        interface IUserService
        {
            List<string> GetUsers();
            void AddUser(string name);

        }

        class UserService: IUserService
        {
            private List<string> users = new List<string>();
            public List<string> GetUsers()
            {
                return users;
            }

            public void AddUser(string name)
            {
                users.Add(name);
            }
        }


        class UserApplication
        {
            IUserService _service;
            public UserApplication(IUserService service)
            {
                _service = service;
            }

            public List<string> GetUsers()
            {
                return _service.GetUsers();
            }

            public void AddUser(string name)
            {
                _service.AddUser(name);
            }
        }
}
