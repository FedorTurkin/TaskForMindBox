namespace AreaLibrary;
public static class AreaCalculation
{
    public static double CirclAarea(double R)
    {
        double area;
        area = double.Pi*R*R;
        return area;
    }
    public static double TriangleArea(double a, double b, double c)
    {
        double area = 0;
        if (a+b>c)
        {
            if (b + c > a)
            {
                if (a + c > b)
                {
                    double p = (a + b + c) / 2;
                    area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                }
               
            }
            
        }
        return area;
    }
}

