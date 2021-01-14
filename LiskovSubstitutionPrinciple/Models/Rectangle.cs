namespace LiskovSubstitutionPrinciple.Models
{
    public class Rectangle
    {
        //old one
        //public int Width { get; set; }
        public virtual int Width { get; set; }

        //old one
        //public int Height { get; set; }
        public virtual int Height { get; set; }

        public Rectangle(){}

        public Rectangle(int width, int height) 
        {
            Height = height;
            Width = width;
        }

        public override string ToString() 
        {
            return $"Width: {Width}, Height: {Height}";
        }
    }

}
