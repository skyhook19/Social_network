using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Books_01.Models.Message
{
    public class MessageContext : DbContext
    {
        public DbSet<Message> Messages { get; set; }
    }
}