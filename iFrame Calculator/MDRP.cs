using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTP_Viewer
{
    internal class MDRP
    {
        uint entryAmount;
        float[] iFrameValues;
        public MDRP(uint entryAmount, byte[] iFileBytes)
        {
            this.entryAmount = entryAmount;
            interpretBytes(iFileBytes);
        }

        private void interpretBytes(byte[] iFileBytes)
        {
            byte[] bytes = new byte[4];
            uint counter = 0;
            iFrameValues = new float[this.entryAmount];

            for (int i = 0x10; i < (iFrameValues.Length * 4) + 0x10; i += 4)
            {
                Array.Copy(iFileBytes, i, bytes, 0, 4);
                iFrameValues[counter] = BitConverter.ToSingle(bytes, 0);
                counter++;
            }
        }

        public float getAttributeFromIndex(uint index)
        {
            return iFrameValues[index];
        }
    }
}
