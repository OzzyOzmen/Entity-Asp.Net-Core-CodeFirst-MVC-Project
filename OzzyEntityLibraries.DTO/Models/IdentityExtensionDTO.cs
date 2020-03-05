using System;
using System.Security.Claims;
using System.Security.Principal;

namespace OzzyEntityLibraries.DTO.Models
{
    public static class IdentityExtensionDTO
    {
        public static int GetUserId(this IIdentity identity)
        {
            ClaimsIdentity claimsIdentity = identity as ClaimsIdentity;

            var value = claimsIdentity.FindFirst("UserId").Value;

            return Convert.ToInt32(value);
        }
        public static string GetUserName(this IIdentity identity)
        {
            ClaimsIdentity claimsIdentity = identity as ClaimsIdentity;

            var value = claimsIdentity.FindFirst("UserName").Value;

            return value;
        }
        public static string GetPassword(this IIdentity identity)
        {
            ClaimsIdentity claimsIdentity = identity as ClaimsIdentity;

            var value = claimsIdentity.FindFirst("Password").Value;

            return value;
        }
        public static string GetNameSurname(this IIdentity identity)
        {
            ClaimsIdentity claimsIdentity = identity as ClaimsIdentity;

            var value = claimsIdentity.FindFirst("NameSurname").Value;

            return value;
        }
        public static string GetUserRole(this IIdentity identity)
        {
            ClaimsIdentity claimsIdentity = identity as ClaimsIdentity;

            var value = claimsIdentity.FindFirst(ClaimTypes.Role).Value;

            return value;
        }
        public static string GetUserPhoto(this IIdentity identity)
        {
            ClaimsIdentity claimsIdentity = identity as ClaimsIdentity;

            var value = claimsIdentity.FindFirst("UserPhoto").Value;

            return value;
        }
    }
}