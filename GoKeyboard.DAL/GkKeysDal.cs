using GoKeyboard.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoKeyboard.DAL
{
    public class GkKeysDal
    {
        public List<GkKey> GetKeys()
        {
            using (DataContext context = new DataContext())
            {
                return context.GkKeys.ToList();
            }

        }
    }
}
