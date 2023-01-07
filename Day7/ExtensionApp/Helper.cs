namespace Math;

public static class Helper{
    public static int Multiplication(this MathEngine m ,int x,int y)
    {
        return x*y;
    }
    public static int Division(this MathEngine m,int x,int y)//this mathengine can be use by mathengine
                //for this we want static nongeneric class along with static method
    {
        return x/y;
    }
}