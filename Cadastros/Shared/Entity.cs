using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public class Entity
    {
        public Entity()
        {

        }

        protected Entity(Int64 id)
        {
            Id = id;
        }

        public Int64 Id { get; protected set; }
    }
}
