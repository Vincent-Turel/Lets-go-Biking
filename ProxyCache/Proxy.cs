﻿using System.Threading.Tasks;

namespace ProxyCache
{
    public class Proxy : IProxy
    {
        public Task<string> GetAllStation() => JCDecauxAPI.GetAllStationsAsync();

        public Task<string> GetStation(string key) => JCDecauxAPI.GetStationsAsync(key);
    }
}
    