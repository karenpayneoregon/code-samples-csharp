namespace IncrementalSearchTextBox
{
    public class NameBase
    {
        public int Index { get; set; }
        public string DisplayText { get; set; }
        public override string ToString() => DisplayText;
    }

    public class GirlName : NameBase { }
    public class BoyName : NameBase { }
}