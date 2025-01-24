public class Reference
{
    private string _book;
    private int _startChapter;
    private int _startVerse;
    private int? _endChapter;
    private int? _endVerse;

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _startChapter = chapter;
        _startVerse = verse;
        _endChapter = null;
        _endVerse = null;
    }

    public Reference(string book, int startChapter, int startVerse, int endChapter, int endVerse)
    {
        _book = book;
        _startChapter = startChapter;
        _startVerse = startVerse;
        _endChapter = endChapter;
        _endVerse = endVerse;
    }

    public override string ToString()
    {
        if (_endChapter.HasValue && _endVerse.HasValue)
        {
            return $"{_book} {_startChapter}:{_startVerse}-{_endChapter}:{_endVerse}";
        }
        else
        {
            return $"{_book} {_startChapter}:{_startVerse}";
        }
    }
}
