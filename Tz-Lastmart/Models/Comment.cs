namespace Tz_Lastmart.Models
{
    public class Comment
    {
        /// <summary>
        /// Id комментария
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Текст комментария
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// Цвет блока
        /// </summary>
        public string BackgroundColor { get; set; }

        /// <summary>
        /// Ключ 
        /// </summary>
        public int PointId { get;set; }

        public Point Point { get; set; }
    }
}
