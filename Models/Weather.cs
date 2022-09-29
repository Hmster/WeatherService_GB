namespace Weather_GB.Models
{
    public class Weather
    {
        /// <summary>
        /// Дата измерения
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Температура в градусах Цельсия
        /// </summary>
        public int TemperatureC { get; set; }


        /// <summary>
        /// Температура в градусах Фаренгейта
        /// </summary>
        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        /// <summary>
        /// Краткое описание погоды
        /// </summary>
        public string Summary => TemperatureC switch
        {
            <= -30 => "Freezing",
            <= -20 => "Bracing",
            <= -10 => "Chilly",
            <= 5 => "Cool",
            <= 10 => "Mild",
            <= 20 => "Warm",
            <= 30 => "Balmy",
            <= 40 => "Hot",
            _ => "Welcome to Hell"
        };
    }
}
