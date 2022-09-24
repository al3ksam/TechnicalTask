using System;

namespace Solutions.Forms.Components
{
    /// <summary>
    /// Предоставляет данные для события изменения состояния подключения к базе данных.
    /// </summary>
    public class DbConnectionStateChangedEventArgs : EventArgs
    {
        public DbConnectionStateChangedEventArgs(in string text)
        {
            Text = text;
        }

        public string Text { get; }
    }
}
