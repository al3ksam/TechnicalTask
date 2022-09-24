using System;

namespace Solutions.Components
{
    public class ConnectionStatusEventArgs : EventArgs
    {
        public ConnectionStatusEventArgs(string text)
        {
            Text = text;
        }

        public string Text { get; }
    }
}
