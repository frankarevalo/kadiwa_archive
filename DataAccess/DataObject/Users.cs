using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Utilities;

namespace DataObject
{
    public class Users
    {
        public string username { get; set; }
        public string password { get; set; }
    }

    public class UsersOutput
    {
        public string status { get; set; }
        public string message { get; set; }
        public ResponseCodes responsecode { get; set; }
    }
}
