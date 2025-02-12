﻿using backend_hector.Controllers;

namespace backend_hector.Services
{
    public class PeopleService2 : IPeopleService
    {
        public bool Validate(People people) {
            if (string.IsNullOrEmpty(people.Name) || 
                people.Name.Length > 100 || people.Name.Length < 3) {
                return false;
            }
            return true;
        }
    }
}
