using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace polyMorphisamStateAndExpressionTree.FactoryPattern
{
    public class serviceLocator : IserviceLocator
    {
        private static serviceLocator _current = new serviceLocator();
        public static serviceLocator current { get { return _current; } }
        Dictionary<Type, object> Services = new Dictionary<Type, object>();
        public bool Contain<T>()
        {
            return Services.ContainsKey(typeof(T));
        }

        public T GetService<T>() where T : class
        {

            if (Services.ContainsKey(typeof(T))) {
                return (T)Services[typeof(T)];
            }
            return null;
        }
        public object GetService(Type type) 
        {

            if (Services.ContainsKey(type))
            {
                return Services[type];
            }
            return null;
        }
        public void Register<T>(T services)
        {
            Services[typeof(T)] = Services;
         }
        public void Register(Type t, object services) {
            Services[t] = services;
        }


        public void Reset()
        {
            Services.Clear();
        }
    }
}
