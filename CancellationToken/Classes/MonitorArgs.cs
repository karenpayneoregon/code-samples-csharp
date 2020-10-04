using System;

namespace CancellationToken.Classes
{
    public class MonitorArgs : EventArgs
    {
        protected string _text;
        protected int _value;

        public MonitorArgs(string text, int value)
        {
            _text = text;
            _value = value;

        }
        public string Text => _text;
        public int Value => _value;

    }
}

