namespace Solutions.Components
{
    //
    // Сводка:
    //     Представляет метод, обрабатывающий событие System.Windows.Forms.Form.FormClosed.
    //
    // Параметры:
    //   sender:
    //     Источник события.
    //
    //   e:
    //     Объект System.Windows.Forms.FormClosedEventArgs, содержащий данные события.
    /// <summary>
    ///     Представляет метод, обрабатывающий событие System.Windows.Forms.Form.FormClosed.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    public delegate void ConnectionStatusEventHandler(object sender, ConnectionStatusEventArgs e);
}
