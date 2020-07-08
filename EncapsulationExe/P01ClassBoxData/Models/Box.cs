
namespace P01ClassBoxData.Models
{
    using System;
    using System.Text;
    using Exceptions;

    public class Box
    {
        private double length;
        private double height;
        private double width;

        public Box(double length, double width, double height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }

        public double Length
        {
            get => this.length;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(ExceptionMesseges.LengthZeroOrNegativeException);
                }

                this.length = value;
            }
        }

        public double Width
        {
            get => this.width;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(ExceptionMesseges.WidthZeroOrNegativeException);
                }

                this.width = value;
            }
        }

        public double Height
        {
            get => this.height;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(ExceptionMesseges.HeightZeroOrNegativeException);
                }

                this.height = value;
            }
        }

        public double SurfaceArea()
        {
            double surfaceArea = 2 * this.Length * this.Width +
                2 * this.Length * this.Height +
                2 * this.Width * this.Height;

            return surfaceArea;
        }

        public double LateralSurfaceArea()
        {
            double lateralSurfaceArea = 2 * this.Length * this.Height +
                2 * this.Width * this.Height;

            return lateralSurfaceArea;
        }

        public double Volume()
        {
            double volume = this.Length * this.Height * this.Width;

            return volume;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Surface Area - {SurfaceArea():f2}");
            sb.AppendLine($"Lateral Surface Area - {LateralSurfaceArea():f2}");
            sb.AppendLine($"Volume - {Volume():f2}");

            return sb.ToString().TrimEnd();
        }
    }
}
