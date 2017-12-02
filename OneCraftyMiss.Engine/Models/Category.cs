using System;

namespace OneCraftyMiss.Engine
{
    public class Category
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public bool CanUserDelete { get; set; }
        public bool CanUserEdit { get; set; }
        public bool IsParent { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
    }
}