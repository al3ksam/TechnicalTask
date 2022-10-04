using System.Collections.Generic;

namespace Solutions.Units
{
    /// <summary>
    /// Представляет раствор с компонентами. Этот класс не наследуется.
    /// </summary>
    public sealed class Solution
    {
        private const decimal _minAmountWater = 0.1m; // Минимальное количество воды в растворе
        private const decimal _maxAmountWater = 100m; // Максимальное количество воды в растворе

        /// <summary>
        /// Создает новый раствор
        /// </summary>
        public Solution() { }

        /// <summary>
        /// Возвращает минимальное количество воды, которое может содержать раствор
        /// </summary>
        public static decimal MinimumAmountWater => _minAmountWater;

        /// <summary>
        /// Возвращает оставшуюся воду в растворе
        /// </summary>
        public decimal Water { get; private set; } = _maxAmountWater;

        /// <summary>
        /// Возвращает воду, которую можно использовать для нового компонента
        /// </summary>
        public decimal WaterForComponent => Water - _minAmountWater;

        /// <summary>
        /// Возвращает коллекцию компонентов раствора
        /// </summary>
        public List<Component> Components { get; } = new List<Component>();

        /// <summary>
        /// Добавляет компонент в раствор
        /// </summary>
        /// <param name="component">Компонент</param>
        /// <returns>Возвращает True, в случае успешного добавления компонента, или False - в случае неудачи (в растворе не хватает воды)</returns>
        public bool AddComponent(in Component component)
        {
            decimal tempWater = Water - component.Amount;
            if (tempWater < _minAmountWater) { return false; }
            Water = tempWater;
            Components.Add(component);
            return true;
        }

        /// <summary>
        /// Удаляет первое вхождение указанного компонента в растворе
        /// </summary>
        /// <param name="idComponent">Компонент, который необходимо удалить</param>
        /// <returns>Значение true, если компонент успешно удален, в противном случае - значение false.
        /// Этот метод также возвращает false, если компонент не найден в растворе.</returns>
        public bool DeleteComponent(Component component)
        {
            if (Components.Remove(component)) {
                Water += component.Amount;
                if (Water > _maxAmountWater) { Water = _maxAmountWater; }
                return true;
            }
            return false;
        }

        /// <summary>
        /// Удаляет первое вхождение указанного компонента в растворе
        /// </summary>
        /// <param name="idComponent">Идентификатор компонента, которого необходимо удалить</param>
        /// <returns>Значение true, если компонент успешно удален, в противном случае - значение false.
        /// Этот метод также возвращает false, если компонент не найден в растворе.</returns>
        public bool DeleteComponent(int idComponent)
        {
            Component temp = Components.Find(component => component.Id == idComponent);
            return DeleteComponent(temp);
        }

        /// <summary>
        /// Ищет первый компонент в растворе с указанным идентификатором
        /// </summary>
        /// <param name="idComponent">Идентификатор компонента</param>
        /// <returns>Возвращает компонент, если он найден; в противном случае - пустой компонент.</returns>
        public Component FindComponent(int idComponent)
        {
            return Components.Find(component => component.Id == idComponent);
        }
    }
}
