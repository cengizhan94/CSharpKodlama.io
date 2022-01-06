using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;

namespace Entities.Concrete
{
    public class Brand : IEntity
    {
        public int ID { get; set; }
        public int BrandId { get; set; }
        public string BrandName { get; set; }
    }
}
