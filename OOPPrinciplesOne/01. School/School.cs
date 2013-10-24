using System;

//Create class School, which inherits interface IComment
public class School
{
    private Class[] schoolClasses;
    private Student[] schoolStudents;

    public Class[] SchoolClasses
    {
        get { return this.schoolClasses; }
        set { this.schoolClasses = value; }
    }

    public Student[] SchoolStudents
    {
        get { return this.schoolStudents; }
        set { this.schoolStudents = value; }
    }

    public School(Class[] schoolClasses, Student[] schoolStudents)
    {
        this.SchoolClasses = schoolClasses;
        this.SchoolStudents = schoolStudents;
    }
}