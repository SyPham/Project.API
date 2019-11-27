using System;

namespace Project.API.Dtos
{
    public class UserForListDto
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public DateTime CreatedTime { get; set; }

    }
}