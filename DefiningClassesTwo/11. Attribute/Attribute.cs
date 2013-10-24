using System;
using System.Reflection;
using System.Runtime.InteropServices;

//Use classes Point3D, AttributePoint and OtherPoint

[AttributeUsage(AttributeTargets.Method | AttributeTargets.Enum | 
    AttributeTargets.Struct | AttributeTargets.Class | AttributeTargets.Interface, 
    AllowMultiple = false)]             //Define AttributeUsage - for methods, enumerations, structures, classes and interfaces
public class Version : System.Attribute //Create class Version, which inherits System.Attribute, with fields properties and constructor
{
    private byte major;                 //Use byte - small and positive numbers
    private byte minor;

    public byte Major 
    { 
        get { return this.major; }
        set { this.major = value; } 
    }

    public byte Minor 
    {
        get { return this.minor; }
        set { this.minor = value; } 
    }

    public Version(byte major, byte minor)
	{
        this.Major = major;
        this.Minor = minor;
	}
}