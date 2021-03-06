﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HouseForRent.DomainEntities.BaseEntity.BaseStatusEntity
{
    public class BaseUpdateStatusEntityCommand
    {
        public Guid Id { get; set; }
        public string Status { get; set; }
        public string Description { get; set; }
    }
}
