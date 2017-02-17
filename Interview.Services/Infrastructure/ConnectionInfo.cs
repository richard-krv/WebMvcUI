using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Services.Infrastructure
{
    public class ConnectionInfo
    {
        public readonly string ConnectionString;
        public ConnectionInfo(string connectionString)
        {
            ConnectionString = connectionString;
        }
    }
}
