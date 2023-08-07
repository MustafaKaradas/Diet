using DietProgram.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietProgram.Core.BaseEntities
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public State State { get; set; }
    }
}
