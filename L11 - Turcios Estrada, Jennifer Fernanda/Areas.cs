class Areas
{
    public double ObtenerAreaTriangulo(double Base, double Altura)
    {
        double Area = (Base * Altura)/2; 
        return Area;
    }
    public double ObtenerAreaCuadrado(double Lado)
    {
        double Area = Lado * Lado; 
        return Area;
    }
    public double ObtenerAreaRectangulo(double Base, double Altura)
    {
        double Area = (Base * Altura)/2; 
        return Area;
    }
    public double ObtenerAreaCirculo(double Radio)
    {
        double Area = (3.1416 * Radio); 
        return Area;
    }

}