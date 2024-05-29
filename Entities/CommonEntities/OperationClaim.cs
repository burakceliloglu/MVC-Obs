using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Repositories.CommonInterfaces;

namespace Entities.CommonEntities
{
    public class OperationClaim:IEntityBase
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }


    }
}
