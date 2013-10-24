using System;

//class DisplayConstructor adds the constructors from second task to class Display
class DisplayConstructor : Display
{
    public DisplayConstructor()
        : this(1)
    {
    }

    public DisplayConstructor(float inches)
        : this(inches, 2)
    {
    }

    public DisplayConstructor(float inches, byte numberColors) : base(inches, numberColors)
    {
        base.Inches = inches;
        base.NumberColors = numberColors;
    }
}