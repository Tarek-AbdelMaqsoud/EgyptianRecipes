using EgyptianRecipes.Data;
using EgyptianRecipes.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;

namespace EgyptianRecipes.Roles
{
    public class ManageRoles : RoleProvider
    {
        private EgyptianRecipesContext db = new EgyptianRecipesContext();

        public override void AddUsersToRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        public override string ApplicationName
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public override void CreateRole(string roleName)
        {
            throw new NotImplementedException();
        }

        public override bool DeleteRole(string roleName, bool throwOnPopulatedRole)
        {
            throw new NotImplementedException();
        }

        public override string[] FindUsersInRole(string roleName, string usernameToMatch)
        {
            throw new NotImplementedException();
        }

        public override string[] GetAllRoles()
        {
            throw new NotImplementedException();
        }

        public override string[] GetRolesForUser(string username)
        {
            username = UserManager.UserManager.RemoveDomainGetUsernameWithoutDomain(username);
            User user = new User();
            String[] userRoles = null;
            try
            {
                user = db.Users.Where(cu => cu.UserName == username).SingleOrDefault();
                if (user != null && user.Active)
                {
                    List<Int64> rolesID = db.UsersRoles.Where(ur => ur.UserID == user.UserID).Select(ur => ur.RoleId).ToList();
                    userRoles = db.Roles.Where(r => rolesID.Contains(r.RolesID)).Select(r => r.Roles).ToArray();
                }
                return ((userRoles == null) ? new List<String>().ToArray() : userRoles);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override string[] GetUsersInRole(string roleName)
        {
            throw new NotImplementedException();
        }

        public override bool IsUserInRole(string username, string roleName)
        {
            username = UserManager.UserManager.RemoveDomainGetUsernameWithoutDomain(username);
            User user = db.Users.Where(cu => cu.UserName == username && cu.Active && !cu.IsRemoved).FirstOrDefault();
            Role roleID = db.Roles.FirstOrDefault(r => r.Roles == roleName);
            if ((user != null) && (roleID != null))
            {
                UserRole UserRole = db.UsersRoles.FirstOrDefault(ur => ur.RoleId == roleID.RolesID && ur.UserID == user.UserID);
                if (UserRole != null)
                    return true;
                else
                    return false;
            }
            else
                return false;
        }

        public override void RemoveUsersFromRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        public override bool RoleExists(string roleName)
        {
            throw new NotImplementedException();
        }
    }
}
