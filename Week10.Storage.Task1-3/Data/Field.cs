using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week10.Storage.Task1_3.Data
{
    public class Field<T>
    {
        public T Value { get; set; }
        public bool IsReadOnly { get; set; }
    }
}
