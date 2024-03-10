using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maths
{
    public class Series<T>
    {
        private T[] _series;

        public T FirstItem
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
        public T LastItem
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public int Count => throw new NotImplementedException();

        public Series(T[] inputs)
        {
            _series = inputs;
        }

        public override string ToString()
        {
            StringBuilder s = new StringBuilder();
            foreach (var item in _series)
            {
                s.Append(item);
            }
            return s.ToString();
        }

    }
}
