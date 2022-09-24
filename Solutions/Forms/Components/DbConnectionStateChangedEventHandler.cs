namespace Solutions.Forms.Components
{
    /// <summary>
    ///     Представляет метод, обрабатывающий событие изменения состояния подключения к базе данных.
    /// </summary>
    /// <param name="sender">Источник события</param>
    /// <param name="e">Объект класса Solution.Forms.Components.DbConnectionStateChangedEventArgs, содержащий данные события.</param>
    public delegate void DbConnectionStateChangedEventHandler(object sender, DbConnectionStateChangedEventArgs e);
}
