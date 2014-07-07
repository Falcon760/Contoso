using ContosoUniversity.Models; 

using System.Data.Entity; 

using System.Data.Entity.ModelConfiguration.Conventions;



namespace ContosoUniversity.DAL
{

    public class SchoolContext : DbContext
    {

        //constructor with the method SchoolContext() giving the db name SchoolContext
        public SchoolContext() : base("SchoolContext")
        {

        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}

//this file uses DbSet to set the tables with the corresponding info from the classes