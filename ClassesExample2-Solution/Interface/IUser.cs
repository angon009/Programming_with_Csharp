using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public interface IUser
    {
        void Login(string userName, string password);

        string IdFormat { get; }

    }
}
