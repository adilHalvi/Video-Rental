﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Vidly_1.Models;
using System.Linq;
using System.Web;

namespace Vidly_1.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter customer's name.")]
        [StringLength(255)]
        public string Name { get; set; }

        public bool IsSubscribedToNewsletter { get; set; }

        public byte MembershipTypeId { get; set; }

        //[Min18YearsIfAMember]
        public DateTime? Birthdate { get; set; }
    }
}