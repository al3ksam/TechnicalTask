namespace Solutions.Data
{
    /// <summary>
    /// Описывает метод аутентификации подключения к базе данных.
    /// </summary>
    public enum AuthentificationMethod : byte
    {
        Windows = 0,
        SQLServer = 1
    }
}
