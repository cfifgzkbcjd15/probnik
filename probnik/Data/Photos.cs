using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace probnik.Data
{
    [Index("albumId", IsUnique = false)]
    public class Photos
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("title")]
        public string Title { get; set; }
        [Column("photo")]
        public byte[] Photo{ get; set; }
        [Column("data")]
        public DateTime Data { get; set; }
        [Column("albumId")]

        public int albumId { get; set; }
        [ForeignKey("albumId")]

        public Albums albums { get; set; }
    }
    public class PhotosViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public IFormFile Photo { get; set; }
        public DateTime Data { get; set; }

        public int albumId { get; set; }
    }
}