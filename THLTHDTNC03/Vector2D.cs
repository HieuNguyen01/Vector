using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THLTHDTNC03
{
    public class Vector2D
    {
        #region 
        protected float x;
        protected float y;
        #endregion
        #region 
        public Vector2D()
        {
            x = 0; y = 0;
        }
        public Vector2D(float x0, float y0)
        {
            x = x0; y = y0;
        }
        #endregion
        #region 
        public float HoanhDo
        {
            set { x = value; }
            get { return x; }
        }
        public float TungDo
        {
            set { y = value; }
            get { return y; }
        }
        #endregion
        #region 
        public float Module()
        {
            return (float)Math.Sqrt(x * x + y * y);
        }
        public static Vector2D operator +(Vector2D v1, Vector2D v2)
        {
            return new Vector2D(v1.x + v2.x, v1.y + v2.y);
        }
        public static Vector2D operator -(Vector2D v1, Vector2D v2)
        {
            return new Vector2D(v1.x - v2.x, v1.y - v2.y);
        }
        public static Vector2D operator *(float c, Vector2D v)
        {
            return new Vector2D(c * v.x, c * v.y);
        }
        public static float ScalarProduct(Vector2D v1, Vector2D v2)
        {
            return v1.x * v2.x + v1.y * v2.y;
        }
        #endregion
    }
}