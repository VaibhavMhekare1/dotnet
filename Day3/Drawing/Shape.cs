namespace Drawing;
public enum Color{
    RED,GREEN,BLUE
}
public abstract class Shape
{
  public Color Color{get;set;}
  public int Width{get;set;}
  public abstract void Draw();
}
