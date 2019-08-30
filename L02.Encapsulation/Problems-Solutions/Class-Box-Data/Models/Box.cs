using System.Text;
using Class_Box_Data.Validators;

namespace Class_Box_Data.Models
{
    public class Box
    {
        private double length;
        private double width;
        private double height;

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
                this.length = new ValidateValue().Validator(nameof(Length), value);
            }
        }

        public double Width
        {
            get => this.width;

            private set
            {
                this.width = new ValidateValue().Validator(nameof(Width), value);
            }
        }

        public double Height
        {
            get => this.height;

            private set
            {
                this.height = new ValidateValue().Validator(nameof(Height), value);
            }
        }

        public double SurfaceArea()
        {
            return 2 * (this.Length * this.Width + this.Length * this.Height + this.Width * this.Height);
        }

        public double LateralSurfaceArea()
        {
            return 2 * this.Height * (this.Length + this.Width);
        }

        public double Volume()
        {
            return this.Length * this.Width * this.Height;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"Surface Area - {this.SurfaceArea():f2}");
            sb.AppendLine($"Lateral Surface Area - {this.LateralSurfaceArea():f2}");
            sb.AppendLine($"Volume - {this.Volume():f2}");

            return sb.ToString().TrimEnd();
        }
    }
}
