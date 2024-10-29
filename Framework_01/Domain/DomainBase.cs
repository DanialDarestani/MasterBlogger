using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework_01.Domain
{
    public class DomainBase<T>
    {
        public T Id { get; set; }
        public DateTime CreationTime { get; set; }

        public DomainBase()
        {
            CreationTime = DateTime.Now;
        }
    }
}
