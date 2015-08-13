using ContosoUniversity.Helpers;
using System.Data.Entity;
using System.Data.Entity.SqlServer;

namespace ContosoUniversity.DAL
{
    public class SchoolConfiguration : DbConfiguration
    {
        public SchoolConfiguration()
        {
            AddInterceptor(new SoftDeleteInterceptor());
        }
    }
}