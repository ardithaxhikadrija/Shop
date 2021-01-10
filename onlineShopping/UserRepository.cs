using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace onlineShopping
{
    public class UserRepository : IUserRepository
    {
        public async Task<bool> Insert(User user)
        {
            using (IDbConnection db = new SqlConnection(AppHelper.ConnectionString)) 
            {
                var result = await db.ExecuteAsync(onlineShopping.Properties.Resources.InsertUser, new { UserName = user.UserName, FullName = user.FullName, Email = user.Email, Password = user.Password });
                return result > 0;
            }
        }
    }
}
