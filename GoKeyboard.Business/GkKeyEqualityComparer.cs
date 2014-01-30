using GoKeyboard.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoKeyboard.Business
{
    public class GkKeyEqualityComparer : IEqualityComparer<GkKey>
    {

        bool IEqualityComparer<GkKey>.Equals(GkKey x, GkKey y)
        {
            return x.Id == y.Id;
        }

        int IEqualityComparer<GkKey>.GetHashCode(GkKey obj)
        {
            return obj.Token.GetHashCode();
        }
    }
}
