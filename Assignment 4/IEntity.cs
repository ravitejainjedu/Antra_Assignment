using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    // marker interface for entities with an Id
    public interface IEntity
    {
        int Id { get; set; }
    }
}
