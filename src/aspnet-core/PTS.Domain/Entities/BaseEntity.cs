﻿
namespace PTS.Domain.Entities
{
   public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime? CreationTime { get; set; } = DateTime.Now;
        public bool IsDeleted { get; set; } = false;
        public int? Status { get; set; } = 1;
    }
}
