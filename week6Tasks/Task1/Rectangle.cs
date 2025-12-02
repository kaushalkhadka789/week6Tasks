public class Rectangle
{
    public double Length { get; }
    public double Width { get; }

    public Rectangle(double length, double width)
        => (Length, Width) = (length, width);

    public double Area => Length * Width;

    public double Perimeter => 2 * (Length + Width);
}
