using System;

class Reference
{
    private string _book = "Alma";
    private string _chapter = "37";
    private string _verse = "35";
    private string _endVerse = "37";

    public string DisplayReference()
    {
        return $"{_book} {_chapter}:{_verse}";
    }

    public string DisplayFullReference()
    {
        return $"{_book} {_chapter}:{_verse} - {_endVerse}";
    }
}