using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array.Contracts
{
    public interface IArray<T>
    {
        int Length { get; }
        T GetItem(int index);
        void SetItem(int index, T value);
    }
}
