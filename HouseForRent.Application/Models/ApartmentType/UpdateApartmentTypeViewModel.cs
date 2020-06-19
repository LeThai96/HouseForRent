using System;
using System.Collections.Generic;
using System.Text;

namespace HouseForRent.Application.Models.ApartmentType
{
    public class UpdateApartmentTypeViewModel
    {
        public Guid Id { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
    }
}
