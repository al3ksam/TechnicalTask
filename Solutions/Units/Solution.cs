using System.Collections.Generic;

namespace Solutions.Units
{
    /// <summary>
    /// Представляет раствор с компонентами. Этот класс не наследуется.
    /// </summary>
    public sealed class Solution
    {
        // Максимальное количество воды в растворе
        private const decimal _MAX_AMOUNT_WATER = 100m;
        // Минимальное количество воды в растворе
        private const decimal _MIN_AMOUNT_WATER = 0.1m;

        // Вода, %
        private decimal _water = _MAX_AMOUNT_WATER;

        // Коллекция компонентов
        private List<Component> _components = new List<Component>();

        /// <summary>
        /// Создает новый раствор
        /// </summary>
        public Solution() { }

        /// <summary>
        /// Возвращает минимальное количество воды, которое может содержать раствор
        /// </summary>
        public static decimal MinimumAmountWater => _MIN_AMOUNT_WATER;

        /// <summary>
        /// Возвращает оставшуюся воду в растворе
        /// </summary>
        public decimal Water => _water;

        /// <summary>
        /// Возвращает воду, которую можно использовать для нового компонента
        /// </summary>
        public decimal WaterForComponent => _water - _MIN_AMOUNT_WATER;
        
        /// <summary>
        /// Возвращает коллекцию компонентов раствора
        /// </summary>
        public List<Component> Components => _components;
        
        /// <summary>
        /// Добавляет компонент в раствор
        /// </summary>
        /// <param name="component">Компонент</param>
        /// <returns>Возвращает True, в случае успешного добавления компонента, или False - в случае неудачи (в растворе не хватает воды)</returns>
        public bool AddComponent(in Component component)
        {
            decimal tempWater = _water - component.Amount;
            if (tempWater < _MIN_AMOUNT_WATER) { return false; }
            _water = tempWater;
            _components.Add(component);
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
            if (_components.Remove(component))
            {
                _water += component.Amount;
                if (_water > _MAX_AMOUNT_WATER) { _water = _MAX_AMOUNT_WATER; }
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
            Component temp = _components.Find(component => component.Id == idComponent);
            return DeleteComponent(temp);
        }

        /// <summary>
        /// Ищет первый компонент в растворе с указанным идентификатором
        /// </summary>
        /// <param name="idComponent">Идентификатор компонента</param>
        /// <returns>Возвращает компонент, если он найден; в противном случае - пустой компонент.</returns>
        public Component FindComponent(int idComponent)
        {
            return _components.Find(component => component.Id == idComponent);
        }
    }
}
