using System;
using System.Collections.Generic;

namespace Quality.Infrastructure.Cache
{
    public interface ICacheClient
    {
        bool Add<T>(string key, T value);
        bool Add<T>(string key, T value, TimeSpan expiresIn);
        bool Add<T>(string key, T value, DateTime expiresAt);
        long Decrement(string key, uint amount);
        void Dispose();
        void FlushAll();
        T Get<T>(string key);
        IDictionary<string, T> GetAll<T>(IEnumerable<string> keys);
        long Increment(string key, uint amount);
        bool Remove(string key);
        void RemoveAll(IEnumerable<string> keys);
        bool Replace<T>(string key, T value);
        bool Replace<T>(string key, T value, TimeSpan expiresIn);
        bool Replace<T>(string key, T value, DateTime expiresAt);
        bool Set<T>(string key, T value);
        bool Set<T>(string key, T value, TimeSpan expiresIn);
        bool Set<T>(string key, T value, DateTime expiresAt);
        void SetAll<T>(IDictionary<string, T> values);
    }
}