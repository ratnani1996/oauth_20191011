﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Try2.Entities
{
    public class UsersEntityModel
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "varchar(30)")]
        public string Name { get; set; }
        [Column(TypeName = "varchar(30)")]
        public string Username { get; set; }
        [Column(TypeName = "varchar(30)")]
        public string Password { get; set; }
    }
}
