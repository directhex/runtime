// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace System.Security.Cryptography
{
    public partial class DSA : AsymmetricAlgorithm
    {
        private static DSA CreateCore()
        {
#pragma warning disable CA1416
            return new DSAWrapper(new DSAOpenSsl());
#pragma warning restore CA1416
        }
    }
}
