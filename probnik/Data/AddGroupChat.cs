using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace probnik.Data
{
    [Index("userId", IsUnique = false)]
    public class AddGroupChat
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }
        [Column("groupId")]
        public long GroupId { get; set; }
        [Column("userId")]
        public string userId { get; set; }
        [Column("role")]
        public string Role { get; set; }
        [Column("photo")]
        public byte[] Photo { get; set; }
        [Column("name")]
        public string Name { get; set; }

        [ForeignKey("userId")]

        public User user { get; set; }
        public GroupChat groupChat { get; set; }


    }
}
