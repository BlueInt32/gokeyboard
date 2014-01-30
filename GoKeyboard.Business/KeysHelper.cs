using GoKeyboard.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoKeyboard.Business
{
    public static class KeysHelper
    {
        public static string GkToString(this ICollection<GkKey> gkkeysList)
        {
            return gkkeysList.Aggregate(string.Empty, (a, b) => string.Concat(a, b.Print));
        }
    }
}
