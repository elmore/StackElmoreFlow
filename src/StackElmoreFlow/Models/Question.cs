using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StackElmoreFlow.Models
{
    public class Question
    {
        public virtual int QuestionId { get; set; }
        public virtual string Title { get; set; }
        public virtual string Body { get; set; }
    }
}