using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace probnik.Data
{
    [Index("addGroupChatId", IsUnique = false)]
    public class GroupChat
    {
        [Key]
        [Column("Id")]
        public long Id { get; set; }
        [Column("addGroupChatId")]
        public long addGroupChatId { get; set; }
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

        [ForeignKey("addGroupChatId")]
        public AddGroupChat addGroupChat {get; set; }
        


    }
}