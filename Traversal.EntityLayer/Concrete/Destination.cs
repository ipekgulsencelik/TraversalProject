﻿using Traversal.EntityLayer.Abstract;

namespace Traversal.EntityLayer.Concrete
{
    public class Destination : BaseEntity, IEntity
    {
        public string? City { get; set; }
        public string? DayNight { get; set; }
        public double Price { get; set; }
        public string? Image { get; set; }
        public string? Description { get; set; }
        public int Capacity { get; set; }
    }
}