using Seo.Domain.WebContext.ValueObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Seo.Domain.Entities
{
    [Table("User")]
    public class User : Entity
    {
        public User()
        {
        }

        public User(Name name, Email email, string passwordHash)
        {
            Name = name;
            Email = email;
            PasswordHash = passwordHash;
            CreationDate = DateTime.Now;
        }

        public Name Name { get; private set; }
        public Email Email { get; private set; }
        public string PasswordHash { get; private set; }
        public IList<string> OnGoingCourses { get; private set; } = new List<string>();
        public DateTime CreationDate { get; private set; }
        public void AddCourse() //Deve retornar lista de string cursos
        {

        }
    }
}
