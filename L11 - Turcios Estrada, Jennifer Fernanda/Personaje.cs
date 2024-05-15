class Personaje
{
    int x = 0;
    int y = 0;

    public int GetX()
    {
        return x;
    }

    public int GetY()
    {
        return y;
    }
    public Personaje (int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    public void MoverHaciaArriba(int cantidad)
    {
        y+= cantidad;
    }

    public void MoverHaciaAbajo(int cantidad)
    {
        y-= cantidad;
    }

    public void MoverHaciaLaIzquierda(int cantidad)
    {
        x-= cantidad;
    }

    public void MoverHaciaLaDerecha(int cantidad)
    {
        x+= cantidad;
    }


}
