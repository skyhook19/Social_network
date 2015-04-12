using Books_01.Models.UserLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Books_01.Models.Message
{
    public class Message
    {
        public int Id { get; private set; }
        public DateTime Date { get; set; }
        public string Content { get; set; }



        public int ApplicationUserId { get; private set; }
        [ForeignKey("ApplicationUserId")]
        public virtual ApplicationUser User { get; private set; }


        public int RecipientId { get; private set; }
        [ForeignKey("RecipientId")]
        public virtual ApplicationUser Recipient { get; private set; }


        public Message()
        {
            Date = DateTime.Now;
        }
    }
}