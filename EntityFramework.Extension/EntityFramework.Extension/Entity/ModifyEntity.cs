using System;

namespace EntityFramework.Extension.Entity
{
    public class ModifyEntity : IModifyEntity
    {
        public DateTime LastModificationTime { get; set; }
        public string LastModifierUserId { get; set; }
    }
}
