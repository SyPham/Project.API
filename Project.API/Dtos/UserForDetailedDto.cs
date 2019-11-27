using System;
using System.Collections.Generic;
using Project.API.Models;

namespace Project.API.Dtos
{
    public class UserForDetailedDto
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public DateTime CreatedTime { get; set; }
    }
}