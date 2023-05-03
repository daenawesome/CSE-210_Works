public class Word
{
    private string text;
    private bool hidden;

    public Word(string text)
    {
        this.text = text;
        hidden = false;
    }

    public bool IsHidden()
    {
        return hidden;
    }

    public void Hide()
    {
        hidden = true;
    }

    public override string ToString()
    {
        if (hidden)
        {
            return "_____";
        }
        else
        {
            return text;
        }
    }
}
