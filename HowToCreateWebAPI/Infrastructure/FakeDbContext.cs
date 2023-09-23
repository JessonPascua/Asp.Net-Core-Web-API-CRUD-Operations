using HowToCreateWebAPI.Model;
using System.Collections.Generic;

namespace HowToCreateWebAPI.Infrastructure
{
    public class FakeDbContext
    {
        public FakeDbContext()
        {
            Users = new List<UserViewModel>();
        }
        public List<UserViewModel> Users { get; set; }
    }
}
