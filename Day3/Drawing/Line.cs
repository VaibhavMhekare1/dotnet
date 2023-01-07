namespace Drawing;

public class Line : Shape, IPrintable
{
    public Point StartPoint { get; set; }
    public Point EndPoint { get; set; }

    public Line()
    {
        StartPoint = new Point(0, 0);
        EndPoint = new Point(0, 0);
    }

    public Line(Point pt1, Point pt2)
    {
        this.StartPoint = pt1;
        this.EndPoint = pt2;
    }

    public override void Draw()
    {
        Type t = this.GetType;
        Console.WriteLine("Type =" + t.Name);
        Console.WriteLine("(" + this.StartPoint + "), (" + this.EndPoint + ")," +
         this.Width + "," + this.Color);
    }

    public override void print()
    {
        Console.WriteLine("Printing object using  exiting printer");
        Type t = this.GetType();
        Console.WriteLine("Type =" + t.Name);
        Console.WriteLine("(" + this.StartPoint + "), (" + this.EndPoint + ")," +
        this.Width + "," + this.Color);
    }
}