using System.Collections.Generic;

namespace Solutions.Units
{
    /// <summary>
    /// Представляет раствор с компонентами. Этот класс не наследуется.
    /// </summary>
    public sealed class Solution
    {
        // Минимальное количество воды в растворе
        private const float _MIN_AMOUNT_WATER = 0.1f;

        // Вода, %
        private float _water = 100;

        // Коллекция компонентов
        private List<Component> _components = new List<Component>();

        /// <summary>
        /// Создает новый раствор
        /// </summary>
        public Solution() { }

        /// <summary>
        /// Возвращает минимальное количество воды, которое может содержать раствор
        /// </summary>
        public static double MinimumAmountWater => _MIN_AMOUNT_WATER;

        /// <summary>
        /// Возвращает оставшуюся воду в растворе
        /// </summary>
        public float Water => _water;

        /// <summary>
        /// Возвращает воду, которую можно использовать для нового компонента
        /// </summary>
        public float WaterForComponents => _water - _MIN_AMOUNT_WATER;
        
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
            float tempWater = _water - component.Amount;
            if (tempWater < _MIN_AMOUNT_WATER) { return false; }
            _water = tempWater;
            _components.Add(component);
            return true;
        }

        /// <summary>
        /// Удаляет первое вхождение указанного компонента в растворе
        /// </summary>
        /// <param name="idComponent">Компонента, который необходимо удалить</param>
        /// <returns>Значение true, если компонент успешно удален, в противном случае - значение false.
        /// Этот метод также возвращает false, если компонент не найден в растворе.</returns>
        public bool DeleteComponent(Component component)
        {
            return _components.Remove(component);
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
