using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace probnik.Data
{
    [Index("userId", IsUnique = false)]
    [Index("groupChatId", IsUnique = false)]
    public class GroupChat
    {
        [Key]
        [Column("id")]
        public string id { get; set; }
        [Column("userId")]
        public string userId { get; set; }
        [Column("groupChatId")]
        public long groupId { get; set; }
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

        [ForeignKey("userId")]

        public User user { get; set; }
        [ForeignKey("groupChatId")]
        public AddGroupChat addGroupChat {get; set; }


    }
}