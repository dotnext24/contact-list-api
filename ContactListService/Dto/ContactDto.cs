using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ContactListService.Dto
{
    public class ContactDto
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string JobTitle { get; set; }

        [Required]
        public string CompanyName { get; set; }

        [Required]
        public string Phone { get; set; }
        [Required]
        public string Address { get; set; }

        [Required]
        public string Email { get; set; }
        public string Comments { get; set; }
        public DateTime LastDateContacted { get; set; }
    }
}
