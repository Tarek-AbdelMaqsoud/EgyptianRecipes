using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.DirectoryServices.AccountManagement;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgyptianRecipes.UserManager
{
    public class UserManager
    {
        private static string Domain = "OTVENTURES";
        public static string GetThumbnailPhoto(string userName)
        {
            userName = (userName.Contains(Domain) ? userName.Split(new string[] { "\\" }, StringSplitOptions.None)[1] : userName);
            using (PrincipalContext principalContext = new PrincipalContext(ContextType.Domain, Domain))
            {
                using (UserPrincipal userPrincipal = new UserPrincipal(principalContext))
                {
                    userPrincipal.SamAccountName = userName;
                    using (PrincipalSearcher principalSearcher = new PrincipalSearcher())
                    {
                        principalSearcher.QueryFilter = userPrincipal;
                        Principal principal = principalSearcher.FindOne();
                        if (principal != null)
                        {
                            DirectoryEntry directoryEntry = (DirectoryEntry)principal.GetUnderlyingObject();
                            PropertyValueCollection collection = directoryEntry.Properties["thumbnailPhoto"];

                            if (collection.Value != null && collection.Value is byte[])
                            {
                                byte[] thumbnailInBytes = (byte[])collection.Value;
                                return Convert.ToBase64String(thumbnailInBytes);
                            }
                        }
                        return null;
                    }
                }
            }
        }
        public static string GetUserFullName(string userName)
        {
            userName = (userName.Contains(Domain) ? userName.Split(new string[] { "\\" }, StringSplitOptions.None)[1] : userName);
            return userName.Replace(".", " ");
        }
        public static string RemoveDomainGetUsernameWithoutDomain(string userName)
        {
            return (userName.Contains(Domain) ? userName.Split(new string[] { "\\" }, StringSplitOptions.None)[1] : userName);
        }
    }
}
