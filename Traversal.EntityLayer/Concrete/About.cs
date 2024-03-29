﻿using Traversal.EntityLayer.Abstract;

namespace Traversal.EntityLayer.Concrete
{
    public class About : BaseEntity, IEntity
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Image { get; set; }
        public string? Title2 { get; set; }
        public string? Description2 { get; set; }
    }
}