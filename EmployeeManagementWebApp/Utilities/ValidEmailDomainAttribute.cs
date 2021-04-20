using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementWebApp.Utilities
{
    public class ValidEmailDomainAttribute: ValidationAttribute
    {
        private readonly string allowedDomain;

        //This class allows to implement custom validation
        //The rule is set in method IsValid
        //Attribute is set to the RegisterViewmodel

        public ValidEmailDomainAttribute(string allowedDomain)
        {
            this.allowedDomain = allowedDomain;
        }

        public override bool IsValid(object value)
        {
            string [] strings = value.ToString().Split('@');
            return strings[1].ToLower() == allowedDomain.ToLower();
            //return base.IsValid(value);
        }
    }
}
