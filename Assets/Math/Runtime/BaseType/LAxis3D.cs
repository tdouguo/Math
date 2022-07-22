// Copyright 2019 谭杰鹏. All Rights Reserved //https://github.com/JiepengTan 

using TG.Math;
using static TG.Math.LVector3;

namespace TG.Math
{
    public struct LAxis3D
    {
        public LVector3 x;
        public LVector3 y;
        public LVector3 z;
        public static readonly LAxis3D identity = new LAxis3D(LVector3.right, LVector3.up, LVector3.forward);

        public LAxis3D(LVector3 right, LVector3 up, LVector3 forward)
        {
            this.x = right;
            this.y = up;
            this.z = forward;
        }

        public LVector3 WorldToLocal(LVector3 vec)
        {
            var _x = Dot(x, vec);
            var _y = Dot(y, vec);
            var _z = Dot(z, vec);
            return new LVector3(_x, _y, _z);
        }
        public LVector3 LocalToWorld(LVector3 vec)
        {
            return x * vec.x + y * vec.y + z * vec.z;
        }

        public LVector3 this[int index]
        {
            get
            {
                switch (index)
                {
                    case 0: return x;
                    case 1: return y;
                    case 2: return z;
                    default: throw new System.IndexOutOfRangeException("vector idx invalid" + index);
                }
            }

            set
            {
                switch (index)
                {
                    case 0:
                        x = value;
                        break;
                    case 1:
                        y = value;
                        break;
                    case 2:
                        z = value;
                        break;
                    default: throw new System.IndexOutOfRangeException("vector idx invalid" + index);
                }
            }
        }
    }
}