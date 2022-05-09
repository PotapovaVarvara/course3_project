using System;

namespace DAL.Models
{
    public class UserRecord
    {
        public Guid Id { set; get; }

        public Guid UserId { set; get; }

        public string BodyPart { set; get; }

        public DateTime RecordDate { set; get; }

        public string FileName { set; get; }

        public string Note { set; get; }
    }
}

