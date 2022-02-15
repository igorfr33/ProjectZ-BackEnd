// =============================================================================
// Startup.cs
// 
// Autor  : Igor Fernandes Rabelo
// Data   : 17/01/2022
// =============================================================================
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using ProjectZ.Data;
using ProjectZ.Repository;
using ProjectZ.Repository.Interface;

namespace ProjectZ
{
    public class Startup
    {
        #region Propriedades Públicas
        public IConfiguration Configuration{ get; }
        #endregion

        #region Construtores
        public Startup( IConfiguration configuration )
        {
            Configuration = configuration;
        }
        #endregion

        #region Métodos/Operadores Públicos
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure( IApplicationBuilder app , IWebHostEnvironment env )
        {

            var  MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

            app.UseCors(MyAllowSpecificOrigins);

            if( env.IsDevelopment() )
            {
                
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI( opt => { opt.SwaggerEndpoint( "/swagger/v1/swagger.json" , "ProjectZ" ); } );
            }
            else
            {
                app.UseExceptionHandler( "/Error" );
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

           
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints( endpoints =>
            {
                endpoints.MapRazorPages();
                endpoints.MapControllers();
            } );

            

        }
            // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices( IServiceCollection services )
        {
            var  MyAllowSpecificOrigins = "_myAllowSpecificOrigins"; 
            var mySqlConnection = Configuration.GetConnectionString( "DefaultConnection" );
            services.AddDbContext<ApplicationContext>( options => options.UseMySql( mySqlConnection , ServerVersion.AutoDetect( mySqlConnection ) ) );

            services.AddScoped<ICidadeRepository , CidadeRepository>();
            services.AddScoped<ILiderResponsavelRepository , LeaderResponsavelRepository>();
            services.AddScoped<ISolicitacaoRepository , SolicitacaoRepository>();
            services.AddScoped<IPessoasCaptadasRepository , PessoasCaptadasRepository>();

            services.AddCors( options =>
            {
                options.AddPolicy( name:"_myAllowSpecificOrigins" , builder =>
                {
                    builder.WithOrigins("http://127.0.0.1:8080");
                });
            } );

            services.AddControllers();

            services.AddRazorPages();

            services.AddSwaggerGen( c => { c.SwaggerDoc( "v1" , new OpenApiInfo {Title = "ProjectZ" , Version = "v1" ,} ); } );

            services.AddCors();
        }
        #endregion
    }
}