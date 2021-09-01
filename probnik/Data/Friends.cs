using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace probnik.Data
{
    public class Friends
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }
        [Column("sender")]
        //отправитель
        public string Sender { get; set; }
        [Column("recipient")]
        //получатель
        public string Recipient { get; set; }
        [Column("confirmation")]
        public string Confirmation { get; set; }


    }
}