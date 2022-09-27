namespace Solutions.Units
{
    // Представляет собой Компонент раствора
    public readonly struct Component
    {
        /// <summary>
        /// Пустой компонент
        /// </summary>
        public static readonly Component Empty;

        private const float _MIN_AMOUNT = 1.1f; // Минимальное значение количества
        private const float _MAX_AMOUNT = 99.9f; // Максимальное значение количества

        /// <summary>
        /// Создает новый компонент
        /// </summary>
        /// <param name="id">Идентификатор компонента</param>
        /// <param name="amount">
        /// Количество компонента: от 0.1 до 99.9
        /// <br />Если значения меньше 0.1, будет установлено 0.1, или 99.9, если больше.
        /// </param>
        public Component(in int id, in float amount)
        {
            Id = id;

            //  Устанавливаем количество в пределах диапазона MIN..MAX
            if (amount < _MIN_AMOUNT)
            {
                Amount = _MIN_AMOUNT;
            }
            else
            {
                if (amount > _MAX_AMOUNT)
                {
                    Amount = _MAX_AMOUNT;
                }
                else
                {
                    Amount = amount;
                }
            }
        }

        /// <summary>
        /// Возвращает идентификатор раствора
        /// </summary>
        public int Id { get; }
        /// <summary>
        /// Возвращает количество компонента, %
        /// </summary>
        public float Amount { get; }

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
