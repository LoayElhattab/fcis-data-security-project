﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityLibrary.RC4
{
    /// <summary>
    /// If the string starts with 0x.... then it's Hexadecimal not string
    /// </summary>
    public class RC4 : CryptographicTechnique
    {
        private byte[] S;
        private byte[] K;
        public override string Decrypt(string cipherText, string key)
        {
            throw new NotImplementedException();
        }

        public override  string Encrypt(string plainText, string key)
        {
            throw new NotImplementedException();
        }
    }
}
