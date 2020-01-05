# FNV-1a
FNV-1a hash algorithm in C#

This small project is an implementation of the FNV-1a hash algorithm for 32-, 64-, 128-, 256-, 512- and 1024-bit variants.
All implemented classes descend from the CLR's HashAlgotithm, which should make for easy adoption.

Example:

```cs
namespace Fnv1aTest
{
    using System;
    using System.Globalization;
    using System.Security.Cryptography;
    
    using Fnv1a;
    
    public static class Program
    {
        public static void Main()
        {
            using (HashAlgorithm alg = new Fnv1a64())
            {
                Console.WriteLine(((ulong)BitConverter.ToInt64(alg.ComputeHash(Encoding.UTF8.GetBytes("foobar")), 0)).ToString("X8", CultureInfo.InvariantCulture));
            }
        }
    }
}
```

This will output 85944171F73967E8 as the FNV-1A 64-bit hash of the string "foobar".
