using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polyMorphisamStateAndExpressionTree.FactoryPattern
{
    public interface IserviceLocator
    {
        void Register<T>(T type);
        T GetService<T>() where T:class;
        void Reset();
        bool Contain<T>();
    }
}
