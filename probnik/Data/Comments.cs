using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace probnik.Data
{
    [Index("postId", IsUnique = false)]
    public class Comments
    {
        [Key]
        [Column("id")]
        public int Id { get; set; } // имя пользователя
        [Column("name")]
        public string Name { get; set; }
        [Column("body")]
        public string Body{ get; set; }
        
        public DateTime Data { get; set; }
        [Column("photo")]
        public byte[] Photo { get; set; }
        [Column("video")]
        public byte[] Video { get; set; }
        [Column("music")]
        public byte[] Music { get; set; }
        [Column("postId")]
        public int postId { get; set; }
        [ForeignKey("postId")]
        public Posts Posts{ get; set; }
    }
    public class CommentsViewModels
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Body { get; set; }
        public int postId { get; set; }
        public DateTime Data { get; set; }
        public IFormFile Photo { get; set; }
        public IFormFile Video { get; set; }
        public IFormFile Music { get; set; }
    }
}