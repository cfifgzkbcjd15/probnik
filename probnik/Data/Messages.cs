using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace probnik.Data
{
    [Index("id", IsUnique = false)]
    public class Messages
    {
        [Column("id")]
        public string id { get; set; }
        [Key]
        [Column("prostoId")]
        public int ProstoId { get; set; }
        [Column("message")]
        public string Message { get; set; }
        [Column("photo")]
        public byte[] Photo { get; set; }
        [Column("video")]
        public byte[] Video { get; set; }
        [Column("fromm")]
        public string Fromm { get; set; }
        [Column("date")]
        public DateTime Date { get; set; }

        [ForeignKey("id")]

        public User user { get; set; }


    }
    public class MessagesViewModel
    {
        public string id { get; set; }
        public IFormFile Photo { get; set; }
        public IFormFile Video { get; set; }
        public string Message { get; set; }
        public string Fromm { get; set; }
        public DateTime Date { get; set; }
        public User user { get; set; }
    }
}
