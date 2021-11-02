using System;

namespace CommuZen0._01.Domain.Models
{
    public class EntityNotFoundException : Exception
    {
        public EntityNotFoundException(string message = "Entity not found") : base(message)
        {
        }
    }
}