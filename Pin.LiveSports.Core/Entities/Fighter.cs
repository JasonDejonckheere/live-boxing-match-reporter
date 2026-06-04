using Pin.LiveSports.Core.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pin.LiveSports.Core.Entities
{
    public class Fighter
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "First name is required")]
        [MinLength(2)]
        public string Firstname { get; set; }

        [Required(ErrorMessage = "Last name is required")]
        [MinLength(2)]
        public string Lastname { get; set; }

        [Required(ErrorMessage = "Last name is required")]
        public WeightType WeightClass { get; set; }
    }
}
