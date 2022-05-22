namespace Oop
{
    using System;


    public class ShapeFactory
    {
        public static Shape Create(string name)
        {

            var inputFirstThreeLetters = name.Substring(0, 3);

            if (inputFirstThreeLetters == "Cir")
            {
                return new Circle();
           
            } else if(inputFirstThreeLetters == "Tri")
            {
                return new Triangle();

            } else if(inputFirstThreeLetters == "Rec")

            {
                return new Rectangle();
            }

            else
            {
                throw new Exception("Invalid shape, first 3 letters doesn't start with any valid letters");
            }
           
        }
    }
}
