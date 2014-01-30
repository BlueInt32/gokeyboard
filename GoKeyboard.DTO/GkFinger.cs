using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoKeyboard.DTO
{
    public class GkFinger
    {   
        [Key, StringLength(2)]
        public string Code { get; set; }
        [StringLength(18)]
        public string Name { get; set; }

        //public string Keys { get; set; }
        public virtual ICollection<GkKey> Keys { get; set; }
    }
}
