using Microsoft.EntityFrameworkCore;

namespace Tz_Lastmart.Models
{
    public class ApplicationContext: DbContext
    {
        public DbSet<Point> Point { get; set; } = null!;
        public DbSet<Comment> Comment { get; set; } = null!;

        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            //Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var point1 = new Point()
            {
                Id = 1,
                X = 7,
                Y = 10,
                Color = "blue",
                Radius = 10
            };

            var point2 = new Point()
            {
                Id = 2,
                X = 5,
                Y = 4,
                Color = "red",
                Radius = 5
            };

            var points = new List<Point>() { point1, point2 };

            var comment1 = new Comment()
            {
                Id = 1,
                BackgroundColor = "blue",
                Text = "Comment1",
                Point = point1
            };


            //var comment2 = new Comment()
            //{
            //    Id = 2,
            //    BackgroundColor = "blue",
            //    Text = "Comment2",
            //    PointId = 2,
            //    Point = point2
            //};

            //var comment3 = new Comment()
            //{
            //    Id = 3,
            //    BackgroundColor = "blue",
            //    Text = "Comment3",
            //    PointId = 2,
            //    Point = point2
            //};
            //var comment4 = new Comment()
            //{
            //    Id = 4,
            //    BackgroundColor = "blue",
            //    Text = "Comment4",
            //    PointId = 1,
            //    Point = point1
            //};

            var comments = new List<Comment>() { comment1,/* comment2, comment3, comment4*/ };



            //Заполнение данными
            modelBuilder.Entity<Point>().HasData(points);
            modelBuilder.Entity<Comment>().HasData(comments);

            //Создание связей 1 ко многим
            modelBuilder.Entity<Comment>()
                .HasOne(c => c.Point)
                .WithMany(p => p.Comment)
                .HasForeignKey(c => c.PointId); 
        }
    }
}
