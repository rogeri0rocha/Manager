using System;
using System.Collections.Generic;
using Manager.Domain.Validators;
using Manage.Core;
using Manage.Core.Exceptions;

namespace Manager.Domain.Entities
{

    public class User : Base
    {
      
        public string Name { get;  private set; }
        public string Email { get; private set; }

        public string Password { get; private set; }

        protected User() { }
        public User(string name, string email, string password)
        {
            Name = name;
            Email = email;
            Password = password;
        }

        public void ChangeName(string name)
        {
            Name = name;
            Validate();
            _errors = new List<string>();
        }
        public void PassWord(string password)
        {
            Password = password;
            Validate();
        }

        public void EMail(string email)
        {
            Email = email;
            Validate();
        }

        public override bool Validate()
        {
            var validator = new UserValidator();
            var validation = validator.Validate(this);
            if (!validation.IsValid)
            {
                foreach(var error in validation.Errors)
                    _errors.Add(error.ErrorMessage);
                throw new DomainException("Alguns campos estão invalidos, corrija-os"+ _errors[0]);
            }
            return true;
            
        }
    }
}
