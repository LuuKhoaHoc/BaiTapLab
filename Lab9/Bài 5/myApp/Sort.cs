using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Bài_5
{
    class Sort : IComparer<Product>
    {
      public int Compare([AllowNull] Product x, [AllowNull] Product y)
        {
            return y.get_price().CompareTo(x.get_price());            
        }
    }
}