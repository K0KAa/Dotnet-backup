//2

//A c# structure type
struct Point{
    //Structures can contain fields
    public int xPos, yPos;

    //Structure can contain parameterized constructors.
    public Point(int x, int y)
    {
        xPos=x, yPox=y;
    }
    //Structures may define methods
    public void PrintPosition()
    {
        System.Console.WriteLine("{0},{1}",xPos,yPos);
    }
}
