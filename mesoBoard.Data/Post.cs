//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace mesoBoard.Data
{
    using System;
    using System.Collections.Generic;

    public partial class Post
    {
        public Post()
        {
            this.Attachments = new HashSet<Attachment>();
        }

        public int PostID { get; set; }

        public int ThreadID { get; set; }

        public int UserID { get; set; }

        public string Text { get; set; }

        public System.DateTime Date { get; set; }

        public bool UseSignature { get; set; }

        public string ParsedText { get; set; }

        public string TextOnly { get; set; }

        public virtual ICollection<Attachment> Attachments { get; set; }

        public virtual ReportedPost ReportedPost { get; set; }

        public virtual User User { get; set; }

        public virtual Thread Thread { get; set; }
    }
}