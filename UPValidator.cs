using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IdentityModel.Selectors;

namespace BasicAuthWCF
{
    public class UPValidator : UserNamePasswordValidator
    {
        public override void Validate(string userName, string password)
        {
            if (!string.IsNullOrEmpty(userName))
                return;
        }
    }
}