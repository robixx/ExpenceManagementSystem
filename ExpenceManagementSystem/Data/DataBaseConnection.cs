using Microsoft.EntityFrameworkCore;

namespace ExpenceManagementSystem.Data
{
    public class DataBaseConnection:DbContext
    {
        public DataBaseConnection(DbContextOptions<DataBaseConnection> options) : base(options)
        {
        }
    }
}
