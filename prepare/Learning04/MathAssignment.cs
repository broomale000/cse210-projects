using System;

public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

    public MathAssignment() : base()
    {
        //
    }

    public MathAssignment(string name, string subject, string tex, string prob) : base(name, subject)
    {
        _textbookSection = tex;
        _problems = prob;
    }
}