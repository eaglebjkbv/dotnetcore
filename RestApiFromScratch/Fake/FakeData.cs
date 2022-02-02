using Bogus; // Fake Data üretmek için kullanılan Nuget Paketi 
// "dotnet add package Bogus"     ile eklenecek
using System.Collections.Generic;
using RestApiFromScratch.Models;

namespace RestApiFromScratch.Fake
{
    public static class FakeData
    {
        private static List<User> _users;

        public static List<User> GetUsers(int number){
            
            if(_users==null){
                _users = new Faker<User>()
                .RuleFor(u => u.id, f => f.IndexFaker + 1)
                .RuleFor(u => u.FirstName, f => f.Name.FirstName())
                .RuleFor(u => u.LastName, f => f.Name.LastName())
                .RuleFor(u=>u.Adress,f=>f.Address.FullAddress())
                .Generate(number);
            
            }
            
            return _users;
        }
    }
}