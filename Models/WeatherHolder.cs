namespace Weather_GB.Models
{
    /// <summary>
    /// Объект на базе класса WeatherHolder, будет хранить список показателей
    /// температуры
    /// </summary>
    public class WeatherHolder
    {
        // Коллекция для хранения показателей температуры
        private List<Weather> _values;

        #region Конструкторы

        public WeatherHolder()
        {
            // Инициализирую коллекцию для хранения показателей температуры
            _values = new List<Weather>();
        }

        #endregion


        #region Методы

        /// <summary>
        /// Добавить новый показатель температуры
        /// </summary>
        /// <param name="date">Дата фиксации показателя температуры</param>
        /// <param name="temperatureC">Показатель температуры</param>
        public void Add(DateTime date, int temperatureC)
        {
            _values.Add(new Weather() { Date = date, TemperatureC = temperatureC });
        }

        /// <summary>
        /// Обновить показатель температуры
        /// </summary>
        /// <param name="date">Дата фиксации показания температуры</param>
        /// <param name="temperatureC">Новый показатель температуры</param>
        /// <returns>Результат выполнения операции</returns>
        public bool Update(DateTime date, int temperatureC)
        {
            foreach (var item in _values)
            {
                if (item.Date == date)
                {
                    item.TemperatureC = temperatureC;
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Получить показатели температуры за временной период
        /// </summary>
        /// <param name="dateFrom">Начальная дата</param>
        /// <param name="dateTo">Конечная дата</param>
        /// <returns>Коллекция показателей температуры</returns>
        public List<Weather> Get(DateTime dateFrom, DateTime dateTo)
        {
            return _values.FindAll(item => item.Date >= dateFrom && item.Date <= dateTo);
        }

        /// <summary>
        /// Удалить показатель температуты на дату
        /// </summary>
        /// <param name="date">Дата фиксации показателя температуры</param>
        /// <returns>Результат выполнения операции</returns>
        public bool Delete(DateTime date)
        {
            foreach (var item in _values)
            {
                if (item.Date == date)
                {
                    _values.Remove(item);
                    return true;
                }
            }
            return false;
        }

        #endregion
    }
}
