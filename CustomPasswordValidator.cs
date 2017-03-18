using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using Microsoft.Owin.Security;
namespace SinExWebApp20316792.Models
{
    public class CustomPasswordValidator : PasswordValidator
    {
        public int RequiredMaxLength { set; get; }

        public int RequiredNonAlphaNumericNumber { set; get; }
        public override Task<IdentityResult> ValidateAsync(string item)
        {
            if (String.IsNullOrEmpty(item) || item.Length < RequiredLength || item.Length > RequiredMaxLength)
            {
                return Task.FromResult(IdentityResult.Failed(String.Format("Password length should be between {0} and {1}.", RequiredLength, RequiredMaxLength)));
            }
            int nonAlphaNumericCount = 0;
            foreach (char c in item)
            {
                if (!IsLetterOrDigit(c))
                    nonAlphaNumericCount++;
            }
            if (nonAlphaNumericCount < RequiredNonAlphaNumericNumber)
            {
                return Task.FromResult(IdentityResult.Failed(String.Format("The password should contain at least {0} non-alphanumeric characters.", RequiredNonAlphaNumericNumber)));
            }
            return Task.FromResult(IdentityResult.Success);
        }
    }
}