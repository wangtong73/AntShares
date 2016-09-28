﻿using AntShares.IO;
using System.IO;

namespace AntShares.Network.Payloads
{
    internal class FilterAddPayload : ISerializable
    {
        public byte[] Data;

        void ISerializable.Deserialize(BinaryReader reader)
        {
            Data = reader.ReadVarBytes(520);
        }

        void ISerializable.Serialize(BinaryWriter writer)
        {
            writer.WriteVarBytes(Data);
        }
    }
}
