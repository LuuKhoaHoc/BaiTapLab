using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Bài_4
{
    class SortByMark : IComparer<Student>
    {
      public int Compare([AllowNull] Student x, [AllowNull] Student y)
        {
            return x.get_mark().CompareTo(y.get_mark());
            
        }
    }
}