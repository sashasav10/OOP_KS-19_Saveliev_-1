using System;
using System.Drawing;


namespace LR5Task2Forms
{
    abstract class Figure
    {
        public Color colour
        {
            get;
            set;
        }
        private double X_;
        private double Y_;
        public double x
        {
            get
            {
                return X_;
            }
            set
            {
                X_ = x;
            }
        }
        public double y
        {
            get
            {
                return Y_;
            }
            set
            {
                Y_ = y;
            }
        }
        public abstract void DrawBlack();
        public abstract void HideDrawingBackGround();
        public void MoveRight()
        {
            for (int i = 0; i < 100; i++)
            {
                DrawBlack();
                System.Threading.Thread.Sleep(50);
                HideDrawingBackGround();
                X_++;
            }
        }



    }
}
