namespace Solutions.Units
{
    // Представляет собой Компонент раствора
    public readonly struct Component
    {
        /// <summary>
        /// Пустой компонент
        /// </summary>
        public static readonly Component Empty;

        private const decimal _minAmount = 0.1m; // Минимальное значение количества
        private const decimal _maxAmount = 99.9m; // Максимальное значение количества

        /// <summary>
        /// Создает новый компонент
        /// </summary>
        /// <param name="id">Идентификатор компонента</param>
        /// <param name="amount">
        /// Количество компонента: от 0.1 до 99.9
        /// <br />Если значения меньше 0.1, будет установлено 0.1, или 99.9, если больше.
        /// </param>
        public Component(in int id, in decimal amount)
        {
            Id = id;

            //  Устанавливаем количество в пределах диапазона MIN..MAX
            if (amount < _minAmount)
            {
                Amount = _minAmount;
            }
            else if (amount > _maxAmount)
            {
                Amount = _maxAmount;
            }
            else
            {
                Amount = amount;
            }
        }

        /// <summary>
        /// Возвращает идентификатор раствора
        /// </summary>
        public int Id { get; }
        /// <summary>
        /// Возвращает количество компонента, %
        /// </summary>
        public decimal Amount { get; }

        // Переопределение базовых методов
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }

        // Операторы
        public static bool operator ==(Component left, Component right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(Component left, Component right)
        {
            return left.Equals(right);
        }
    }
}
