using System;

namespace Phf.Net
{
    public struct PhfKey
    {
        public ReadOnlyMemory<Byte> Key;
        
        public uint G; /* result of g(k) % r */
        
        //public unsafe uint* N; /* number of keys in bucket g */ =>
    }
}