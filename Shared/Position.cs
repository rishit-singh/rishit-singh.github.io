namespace portfolio;

public enum ContainerType
{
    Grid,
    Flex
}

public enum Position
{
    Left,
    Right,
    Center
}

public class Positions
{
    public static string[,] PositionStrings = new string[,]
    {
        {
            "left",
            "right",
            "center"
        }
    };
}

