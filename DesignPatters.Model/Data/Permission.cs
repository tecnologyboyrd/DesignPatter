﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DesignPatters.Model.Data
{
    public partial class Permission
    {
        public int AutoSec { get; set; }
        [Key]
        public Guid PermissionId { get; set; }
        [Required]
        [StringLength(100)]
        [Unicode(false)]
        public string Desciption { get; set; }
    }
}