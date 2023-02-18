using MySqlConnector;

public class Startup {  
    // Use this method to add services to the container. 

      public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
 
        public IConfiguration Configuration { get; }
    public void ConfigureServices(IServiceCollection services) {  
           services.AddMvc(); 
           services.AddTransient<MySqlConnection>(_ => new MySqlConnection(Configuration.GetConnectionString("Default")));

    }  
    // Use this method to configure the HTTP request pipeline.  
    public void Configure(IApplicationBuilder app) {  
           app.UseMvc();  

    }  
}