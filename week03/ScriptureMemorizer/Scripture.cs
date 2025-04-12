public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] parts = text.Split(' ');
        foreach (string part in parts)
        {
            _words.Add(new Word(part));
        }
    }

    public void HideRandomWords()
    {
        Random rand = new Random();
        List<int> visibleIndexes = new List<int>();

        for (int i = 0; i < _words.Count; i++)
        {
            if (!_words[i].IsHidden())
            {
                visibleIndexes.Add(i);
            }
        }

        int numberToHide = rand.Next(1, 4); 

        for (int i = 0; i < numberToHide && visibleIndexes.Count > 0; i++)
        {
            int randomIndex = rand.Next(visibleIndexes.Count);
            int wordIndex = visibleIndexes[randomIndex];
            _words[wordIndex].Hide();
            visibleIndexes.RemoveAt(randomIndex);
        }
    }

    public string GetDisplayText()
    {
        string referenceText = _reference.GetDisplayText();
        string wordsText = "";
        foreach (Word word in _words)
        {
            wordsText += word.GetDisplayText() + " ";
        }
        return referenceText + " - " + wordsText.Trim();
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
                return false;
        }
        return true;
    }
}