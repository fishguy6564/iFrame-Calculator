using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTP_Viewer
{
    internal class TTP
    {
        private uint entryAmount;
        private uint[] iFramevalues;


        public TTP(uint entryAmount, byte[] iFileBytes)
        {
            this.entryAmount = entryAmount;
            interpretBytes(iFileBytes);
        }

        private void interpretBytes(byte[] iFileBytes)
        {
            byte[] bytes = new byte[4];
            uint counter = 0;
            iFramevalues = new uint[this.entryAmount];

            for(int i = 0x10; i < (iFramevalues.Length * 0x38); i+= 0x38)
            {
                Array.Copy(iFileBytes, i + 0x34, bytes, 0, 4);
                iFramevalues[counter] = BitConverter.ToUInt32(bytes, 0);
                counter++;
            }
        }

        public uint getAttributeFromIndex(uint index)
        {
            if (index == 0xFFFFFFFF) return 0;
            return iFramevalues[index];
        }
    }
}
