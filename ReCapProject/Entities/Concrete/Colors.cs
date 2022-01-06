using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;

namespace Entities.Concrete
{
    public class Colors : IEntity
    {
        public int ID { get; set; }
        public int ColorId { get; set; }
        public string ColorName { get; set; }
    }
}
