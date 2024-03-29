﻿namespace Traversal.EntityLayer.Abstract
{
    public class BaseEntity
    {
        public virtual int Id { get; set; }
        public virtual DateTime CreatedDate { get; set; } = DateTime.Now;
        public virtual DateTime ModifiedDate { get; set; } = DateTime.Now;
        public virtual bool IsDeleted { get; set; } = false;
        public virtual bool IsActive { get; set; } = true;
        public virtual bool Visible { get; set; } = true;
        public virtual string? CreatedByName { get; set; } //= "Admin"; //Olusturan kullanici degilse admin olarak default deger atanacak
        public virtual string? ModifiedByName { get; set; } //= "Admin";
        public virtual string? Note { get; set; }
    }
}
