using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace probnik.Data
{
    public class Posts
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("userid")]
        public string UserId { get; set; } // имя пользователя
        [Column("body")]
        public string Body { get; set; }
        [Column("to")]
        public string To { get; set; }
        [Column("data")]
        public DateTime Data { get; set; }
        [Column("photo")]
        public byte[] Photo { get; set; }
        [Column("video")]
        public byte[] Video { get; set; }
        [Column("likes")]
        public long Likes { get; set; }
        [Column("music")]
        public byte[] Music { get; set; }
        public Comments Comments { get; set; }
        

    }
    public class PostsViewModel
    {
        public int Id { get; set; }
        public string UserId { get; set; } // имя пользователя
        public string Body { get; set; }
        public string To { get; set; }
        public DateTime Data { get; set; }
        public IFormFile Photo { get; set; }
        public IFormFile Video { get; set; }
        public IFormFile Music { get; set; }
    }
}