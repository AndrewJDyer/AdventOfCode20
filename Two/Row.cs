namespace Two;
record Row(Policy Policy, Password Password)
{
    public bool IsConsistentWithPolicy()
    {
        var matchingChars = 0;
        if (Password.Text[Policy.AllowedRange.Lower - 1] == Policy.Character)
            matchingChars++;
        
        if (Password.Text[Policy.AllowedRange.Upper - 1] == Policy.Character)
            matchingChars++;
        
        return matchingChars == 1;
    }
}