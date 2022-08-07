namespace Tz_Lastmart.Models;

public class Point
{
    /// <summary>
    /// Id точки
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Координаты по X
    /// </summary>
    public int X { get; set; }

    /// <summary>
    /// Координаты по Y
    /// </summary>
    public int Y { get; set; }

    /// <summary>
    /// Радиус точки
    /// </summary>
    public int Radius { get; set; }

    /// <summary>
    /// Цвет точки
    /// </summary>
    public string? Color { get; set; }

    public List<Comment>? Comment { get; set; }
}
