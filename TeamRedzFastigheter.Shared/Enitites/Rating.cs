using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using TeamRedzFastigheter.Shared.Models.UserModel;

namespace TeamRedzFastigheter.Shared.Enitites
{
    public class Rating
    {
        [Required]
        [Range(1, 5)]
        public int Value { get; set; }
        public string UserName { get; set; }
        [ForeignKey("UserId")]
        public int UserId { get; set; }
    }
}
