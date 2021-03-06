using System;
using System.Collections.Generic;
using System.Text;

using BackendDemoForAGame.Abstract;

namespace BackendDemoForAGame.Concrete
{
    public class Player : IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string TCKN { get; set; }
    }
}
