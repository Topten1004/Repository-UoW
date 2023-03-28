using System;

namespace Sample.Domain.Entities
{
    public interface IBaseEntity<T>
    {
        public T Id { get; set; }
        public DateTime CreateAt { get; set; }
    }

    public class BaseEntity : IBaseEntity<int>
    {
        public int Id { get; set; }
        public DateTime CreateAt { get; set; }
    }
}