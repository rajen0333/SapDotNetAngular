using System;
using System.Collections.Generic;
using System.Text;

namespace SapDotNetAngular.DBEntity.Model
{
    public class MainCourse
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public decimal Price { get; set; }
    }
}
