﻿using Traversal.EntityLayer.Abstract;

namespace Traversal.EntityLayer.Concrete
{
    public class Contact : BaseEntity, IEntity
    {
        public string? Description { get; set; }
        public string? Mail { get; set; }
        public string? Address { get; set; }
        public string? Phone { get; set; }
        public string? MapLocation { get; set; }
    }
}