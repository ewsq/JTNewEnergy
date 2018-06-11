﻿using GBNewEnergy.Protocol.Extensions;
using GBNewEnergy.Protocol.NEEncrypts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEEncryptsNET45.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            NEAES128EncryptImpl nE_AES128EncryptImpl = new NEAES128EncryptImpl(
            new GBNewEnergy.Protocol.NEGlobalConfigs()
            {
                NEEncryptKey = "smallchi"
            });
            string str = "aaasssddd123";
            var bytes = Encoding.UTF8.GetBytes(str);
            var encrypt = nE_AES128EncryptImpl.Encrypt(bytes);
            Console.WriteLine("原数据:" + str);
            Console.WriteLine("加密后:" + encrypt.ToHexString());
            Console.WriteLine("解密后:" + Encoding.UTF8.GetString(nE_AES128EncryptImpl.Decrypt(encrypt)));
            Console.ReadKey();
        }
    }
}