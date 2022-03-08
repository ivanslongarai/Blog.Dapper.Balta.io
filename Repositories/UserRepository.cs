using System.Collections.Generic;
using System.Linq;
using Blog.Models;
using Dapper;
using Microsoft.Data.SqlClient;

namespace BlogDapper.Repositories
{
    public class UserRepository : Repository<User>
    {
        private readonly SqlConnection _connection;

        public UserRepository()
        {
            _connection = Database.connection;
        }

        public List<User> GetWithRoles()
        {
            var query =
                @"
                SELECT 
                        [User].*,
                        [Role].*						
                FROM 
                    [User]
                    LEFT JOIN [UserRole] ON [UserRole].[UserId] = [User].[Id]
                    
                    LEFT JOIN [Role] ON [Role].[Id] = [UserRole].[RoleId]";

            var users = new List<User>();

            _connection
                .Query<User, Role, User>(query,
                (user, role) =>
                {
                    var usr = users.FirstOrDefault(x => x.Id == user.Id);
                    if (usr == null)
                    {
                        usr = user;
                        if (role != null) usr.Roles.Add(role);
                        users.Add (usr);
                    }
                    else
                    {
                        usr.Roles.Add (role);
                    }
                    return user;
                },
                splitOn: "Id");

            return users;
        }

        public void LinkUserWithRole(int userId, int roleId)
        {
            var insertSQL =
                @"INSERT INTO [UserRole]                         
                        VALUES 
                        (
                                @UserId,
                                @RoleId
                        )";

            _connection
                .Execute(insertSQL, new { UserId = userId, RoleId = roleId });
        }
    }
}
