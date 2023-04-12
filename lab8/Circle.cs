/**
*--------------------------------------------------------------------
* File name: Circle.cs
* Project name: lab8
*--------------------------------------------------------------------
* Author’s name and email: Justin Dubin, dubinj@etsu.edu
* Course-Section: CSCI 1250-001
* Creation Date: 14 Apr 2022
*
-------------------------------------------------------------------
*/
public class Circle
{
    // fields (data)
    private double _radius;
    
    // Constructors
    public Circle(double radius)
    {
        // notice parameters are different names than the fields
        // this avoids the shadowing of the field names
        _radius = radius;
    }


   // methods (actions)
    public double GetRadius()
    {
        return _radius;
    }

    public void SetRadius(double radius)
    {
        // this.length refers to the field value of length (not the parameter)
        _radius = radius;
    }

    public double GetDiameter()
    {
        //d = 2r
        return _radius * 2;
    }

    public double GetCircumference()
    {
        //C = 2(PI)r
        return 2 * (Math.PI) * _radius;
    }

    public double GetArea()
    {
        //A = (PI)r^2
        return Math.PI * Math.Pow(_radius, 2);
    }
}