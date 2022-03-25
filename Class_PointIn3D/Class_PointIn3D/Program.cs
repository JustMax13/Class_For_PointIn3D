class PointOn3D
{
    public PointOn3D()
    {

    }
    public PointOn3D(float x, float y)
    {
        this.x = x;
        this.y = y;
    }
    public PointOn3D(float x, float y, float z) : this(x, y)
    {
        this.z = z;
    }
    public PointOn3D(PointOn3D point)
    {
        this.x = point.x;
        this.y = point.y;
        this.z = point.z;
    }
    private float x, y, z;
    public void PrintPoint()
    {
        Console.WriteLine($"X: {x};\nY: {y};\nZ: {z}.\n");
    }
    public void ChangeX(float x)
    {
        this.x = x;
    }
    public void ChangeY(float y)
    {
        this.y = y;
    }
    public void ChangeZ(float z)
    {
        this.z = z;
    }
}