using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace probnik.Data
{
    [Index("postId", IsUnique = false)]
    public class LikesPosts
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }
        [Column("postId")]
        public int postId { get; set; }
        [Column("userName")]
        public string UserName { get; set; }
        [Column("like")]
        public long Like { get; set; }
        [ForeignKey("postId")]
        public Posts Posts { get; set; }
    }
}
