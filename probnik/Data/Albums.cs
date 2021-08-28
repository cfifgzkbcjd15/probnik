using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace probnik.Data
{
    
    public class Albums
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("userid")]
        public string UserId { get; set; } // имя пользователя
        [Column("title")]
        public string Title { get; set; }
        [Column("data")]
        public DateTime Data { get; set; }
        public Photos Photos { get; set; }
        
    }
}