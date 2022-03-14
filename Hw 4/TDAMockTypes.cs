using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw_4
{
    public static class TDAMock
    {
        public static int[,] GetMock(TDAMockType type)
        {
            switch(type)
            {
                case TDAMockType.Empty:
                    return new int[,] { };

                case TDAMockType.One:
                    return new int[1,1] { { 1 } };

                case TDAMockType.Quadtwo:
                    return new int[2, 2] {
                        {10,11},
                        {30,33},
                        };
                case TDAMockType.Quadthree:
                    return new int[3, 3] {
                        {35,43,53 },
                        {48,46,41},
                        {78,12,20},
                        };
                case TDAMockType.QuadthreeDiagReverse:
                    return new int[3, 3] {
                        {35,48,78 },
                        {43,46,12},
                        {53,41,20},
                        };
                case TDAMockType.Quadfour:
                    return new int[4, 4] {
                        {15,13,87,98},
                        {15,74,51,0},
                        {62,14,33,37},
                        {99,43,51,-4}
                        };
                case TDAMockType.QuadfourDiagReverse:
                    return new int[4, 4] {
                        {15,15,62,99},
                        {13,74,14,43},
                        {87,51,33,51},
                        {98,0,37,-4}
                        };
                case TDAMockType.ThreeByFour:
                    return new int[3, 4] {
                        {10,20,30,40},
                        {45,65,56,90},
                        {0,0,6,71}
                        };
                default:
                    throw new ArgumentException("Missing Mock type");
            }
        }
    }
}
