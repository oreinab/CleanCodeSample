using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Management_Domain.Common
{
    public abstract class BaseDomainEntity
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }
        public string CreatedDateBy { get; set; }
        public string LastModifiedDateBy { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
    }
}
