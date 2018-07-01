namespace SapatariaBiblioteca
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class BancosSapataria : DbContext
    {


        // Your context has been configured to use a 'ModelSapato' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'SapatariaBiblioteca.ModelSapato' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'ModelSapato' 
        // connection string in the application configuration file.
        public BancosSapataria()
            : base("name=BancosSapataria")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Cliente> BdClientes { get; set; }
        public virtual DbSet<Modelo> BdModelo { get; set; }

    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}