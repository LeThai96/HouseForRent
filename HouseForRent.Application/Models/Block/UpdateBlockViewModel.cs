using System;
using System.Collections.Generic;
using System.Text;

namespace HouseForRent.Application.Models.Block
{
    public class UpdateBlockViewModel
    {
        public Guid Id { get; set; }
        public string BlockName { get; set; }
        public string Description { get; set; }
    }
}
