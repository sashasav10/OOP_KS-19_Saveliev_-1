using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lr2TVector
{
    class TVector3D : TVector2DF
    {
        private double a3_;
        public TVector3D(double a1, double a2, double a3) : base(a1, a2)
        {
            this.a3_ = a3;

        }
        public double a3
        {
            get { return a3_; }
            set { a3_ = value; }
        }
        override public string ToString()
        {
            return base.ToString()+";" + a3_ + ")";
        }
        public void ChangeElements(double a3)
        {
            this.a3_ = a3;

        }
        public new double VectorLength()
        {
            return Math.Sqrt(Math.Pow(a1, 2) + Math.Pow(a2, 2) + Math.Pow(a3_, 2));
        }
        public new TVector3D ToNormVector()
        {
            TVector3D normVector = new TVector3D(a1 / VectorLength(), a2 / VectorLength(), a3_ / VectorLength());
            return normVector;
        }
        public bool IsTheSame( TVector3D b)
        {
            bool res = false;
            if (this.a3_ == b.a3_ && base.IsTheSame(b)) res = true;
            return res;
        }
        public static string operator +(TVector3D a, TVector3D b)
        {
            
            return "("+(a.a1+ b.a1)+ ";"+(a.a2 + b.a2) + ";" +( a.a3_+b.a3_)+")";
        }
        public static string operator -(TVector3D a, TVector3D b)
        {

            return "(" + (a.a1 - b.a1) + ";" + (a.a2 - b.a2) + ";" + (a.a3_ - b.a3_) + ")";
        }
        public static string operator *(TVector3D a, TVector3D b)
        {
            return "(" + (a.a1* b.a1) + ";" + (a.a2 *b.a2) + ";" + (a.a3_ * b.a3_) + ")";
        }


    }
}

