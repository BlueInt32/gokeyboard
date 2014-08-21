using GoKeyboard.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoKeyboard.Business
{
    public class GkKeyEqualityComparer : IEqualityComparer<Key>
    {

        bool IEqualityComparer<Key>.Equals(Key x, Key y)
        {
            return x.Id == y.Id;
        }

        int IEqualityComparer<Key>.GetHashCode(Key obj)
        {
            return obj.Token.GetHashCode();
        }
    }
}
