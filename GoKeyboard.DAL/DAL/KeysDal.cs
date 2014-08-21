using GoKeyboard.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoKeyboard.DAL
{
    public class KeysDal
    {
        public List<Key> GetKeys()
        {
            using (GoKeyboardDbContext context = new GoKeyboardDbContext())
            {
                return context.Keys.ToList();
            }

        }
    }
}
