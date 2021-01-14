namespace LiskovSubstitutionPrinciple.Models
{
    public class Square :Rectangle
    {
        //old one
        //public new int Width 
        //{
        //    //if someone changes the width he auto changes the height
        //    set { base.Width = base.Height = value;}
        //}

        public override int Width
        {
            set { base.Width = base.Height = value; }
        }

        //old one
        //public new int Height
        //{
        //    set { base.Height = base.Width = value; }
        //}

        public override int Height
        {
            set { base.Height = base.Width = value; }
        }
    }
}
