
namespace portfolio
{
    public enum Color
    {
        White,
        Red,
        Green,
        Blue,
        Violet,
        Indigo,
        Yellow,
        Orange,
        Black
    }

    public struct RGB
    {
        public int Red;

        public int Green;

        public int Blue;

        public override string ToString()
        {
            return $"rgb({this.Red}, {this.Green}, {this.Blue})";
        }

        public RGB(int red = 0, int green = 0, int blue = 0)
        {
            this.Red = red;
            this.Green = green;
            this.Blue = blue;
        }
    }

    public class ColorManager
    {
        public static RGB[] Colors = new RGB[] {
            new RGB(255, 255, 255),
            new RGB(255, 0, 0),
            new RGB(0, 255, 0),
            new RGB(0, 0, 255),
            new RGB()
        };
        
    }
}