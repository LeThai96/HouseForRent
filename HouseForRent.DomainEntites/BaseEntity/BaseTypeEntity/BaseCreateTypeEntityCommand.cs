using System;
using System.Collections.Generic;
using System.Text;

namespace HouseForRent.DomainEntities.BaseEntity.BaseTypeEntity
{
    public class BaseCreateTypeEntityCommand
    {
        public Guid Id { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
    }
}
