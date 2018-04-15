namespace Dal
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class ModelBeauty : DbContext
    {
        // Your context has been configured to use a 'ModelBeauty' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Dal.ModelBeauty' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'ModelBeauty' 
        // connection string in the application configuration file.
        public ModelBeauty()
            : base("name=ModelBeauty")
        {
            Database.SetInitializer(new MyInitializer<ModelBeauty>());
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public virtual DbSet<Material> Materials { get; set; }
        public virtual DbSet<Service> Services { get; set; }
        public virtual DbSet<Staff> Staffs { get; set; }
        public virtual DbSet<WorkPosition> WorkPositions { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}