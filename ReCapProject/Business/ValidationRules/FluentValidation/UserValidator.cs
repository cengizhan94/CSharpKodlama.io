﻿using Core.Entities.Concrete;
using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;


namespace Business.ValidationRules.FluentValidation
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(u => u.Email).MinimumLength(11);
            RuleFor(u=>u.FirstName).MinimumLength(2);
            RuleFor(u=>u.LastName).MinimumLength(2);
        }
    }
}
