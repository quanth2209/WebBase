using System;

namespace WebBase.Entities.Base
{
    public class BaseIdEntity
    {
        public long Id { get; set; }

        public DateTime CreationDate { get; set; }

        public DateTime? ModificationDate { get; set; }
    }
}
