namespace Math;
public class Complex
{
    private int real;
    private int img;
    
    //we can write the getter setter like this along with the initallization 
    //but we have  to set the varible as public
    //public double real { get; set; }
    //public double img { get; set; }


    public Complex()
    {
        this.real = 0;
        this.img = 0;
    }
    public Complex(int real, int img)
    {
        this.real = real;
        this.img = img;
    }

    public int Real
    {
        get { return this.real; }
        set { this.real = value; }
    }

    public int Img
    {
        get { return this.img; }
        set { this.img = value; }
    }

    public static Complex operator +(Complex c1, Complex c2)
    {
        Complex temp = new Complex();
        temp.real = c1.real + c2.real;
        temp.img = c1.img + c2.img;
        return temp;
    }
}