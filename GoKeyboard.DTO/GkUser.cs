using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoKeyboard.DTO
{
    public class GkUser
    {
        public int Id { get; set; }
        public string Login { get; set; }

        public string Email { get; set; }
    }
}
