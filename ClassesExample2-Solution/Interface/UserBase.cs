using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public abstract class UserBase : IUser
    {
        public abstract void Register(string userName , string password);
        public void Login(string userName, string password)
        {
            throw new NotImplementedException();
        }

        private int _count;

        public abstract string IdFormat { get; } //Still Undefined

        public UserBase()
        {

        }
    }
}
