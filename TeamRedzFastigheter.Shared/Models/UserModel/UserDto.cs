using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeamRedzFastigheter.Shared.Models.UserModel
{
    public class UserDto
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public double? AverageRating { get; set; }
        public int RealEstates { get; set; }
        public int Comments { get; set; }
    }
}
