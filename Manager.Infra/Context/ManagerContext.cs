

using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Manager.Infra.Context
{
    internal class ManagerContext : DbContext
    {
        internal IEnumerable<object> Users;

        public ManagerContext()
        {

        }
    }
}
