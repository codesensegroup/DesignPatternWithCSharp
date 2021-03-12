using System;
using System.Collections.Generic;

namespace Proxy.AOP_DispatchProxy
{
    public class LoggerRepository<T> : IRepository<T>
    {
        private readonly IRepository<T> _decorated;
        public LoggerRepository(IRepository<T> decorated)
        {
            _decorated = decorated;
        }
        private void Log(string msg, object arg = null)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(msg, arg);
            Console.ResetColor();
        }
        public void Add(T entity)
        {
            Log("In decorator - Before Adding {0}", entity);
            _decorated.Add(entity);
            Log("In decorator - After Adding {0}", entity);
        }
        public void Delete(T entity)
        {
            Log("In decorator - Before Deleting {0}", entity);
            _decorated.Delete(entity);
            Log("In decorator - After Deleting {0}", entity);
        }
        public void Update(T entity)
        {
            Log("In decorator - Before Updating {0}", entity);
            _decorated.Update(entity);
            Log("In decorator - After Updating {0}", entity);
        }
        public IEnumerable<T> GetAll()
        {
            Log("In decorator - Before Getting Entities");
            var result = _decorated.GetAll();
            Log("In decorator - After Getting Entities");
            return result;
        }
        public T GetById(int id)
        {
            Log("In decorator - Before Getting Entity {0}", id);
            var result = _decorated.GetById(id);
            Log("In decorator - After Getting Entity {0}", id);
            return result;
        }
    }
}
