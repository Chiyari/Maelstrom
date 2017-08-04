﻿using System.IO;
using Shared.Network;
using WorldServer.Game.Entity;

namespace WorldServer.Network.Message
{
    [SubPacket(SubPacketOpcode.ServerContainerSetup, SubPacketDirection.Server)]
    public class ServerContainerSetup : SubPacket
    {
        public uint Index;
        public uint ItemCount;
        public ContainerType Type;
        
        public override void Write(BinaryWriter writer)
        {
            writer.Write(Index);
            writer.Write(ItemCount);
            writer.Write((ushort)Type);
            writer.Write((ushort)0);
            writer.Write(0u);
        }
    }
}