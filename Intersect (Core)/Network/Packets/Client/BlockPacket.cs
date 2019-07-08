﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intersect.Network.Packets.Client
{
    public class BlockPacket : CerasPacket
    {
        public bool Blocking { get; set; }

        public BlockPacket(bool blocking)
        {
            Blocking = blocking;
        }
    }
}