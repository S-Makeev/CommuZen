using System;

namespace CommuZen0._01.DataAccess.Entities
{
    public class NewMethodAttribute : Attribute
    {
        public string Name { get; set; }
        public NewMethodAttribute()
        {
            
        }
    }
}