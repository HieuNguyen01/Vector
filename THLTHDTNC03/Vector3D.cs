using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THLTHDTNC03
{
    public class Vector3D : Vector2D
    {
        #region Khai báo biến
        private float z;
        #endregion
        #region Các hàm tạo
        public Vector3D() : base()
        {
            z = 0;
        }
        public Vector3D(float x0, float y0, float z0) : base(x0, y0)
        {
            z = z0;
        }
        #endregion
        #region Các đặc trưng
        public float CaoDo
        {
            set { z = value; }
            get { return z; }
        }
        #endregion
        #region Các phương thức
        public new float Module()
        {
            return (float)Math.Sqrt(x * x + y * y + z * z);
        }
        public static Vector3D operator +(Vector3D v1, Vector3D v2)
        {
            return new Vector3D(v1.x + v2.x, v1.y + v2.y, v1.z + v2.z);
        }
        public static Vector3D operator -(Vector3D v1, Vector3D v2)
        {
            return new Vector3D(v1.x - v2.x, v1.y - v2.y, v1.z - v2.z);
        }
        public static Vector3D operator *(float c, Vector3D v)
        {
            return new Vector3D(c * v.x, c * v.y, c * v.z);
        }
        public static float ScalarProduct(Vector3D v1, Vector3D v2)
        {
            return v1.x * v2.x + v1.y * v2.y + v1.z * v2.z;
        }
        public static Vector3D operator *(Vector3D v1, Vector3D v2)
        {
            return new Vector3D(v1.y * v2.z - v1.z * v2.y, v1.z * v2.x - v1.x * v2.z, v1.x * v2.y - v1.y * v2.x);
        }
        public static float MixedProduct(Vector3D v1, Vector3D v2, Vector3D v3)
        {
            return ScalarProduct(v1, v2 * v3);
        }
        #endregion
    }
}
