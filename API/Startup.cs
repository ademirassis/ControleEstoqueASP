using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Repository;

namespace API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // Configurando a ID do banco - Context
            services.AddDbContext<Context>(options => options.UseSqlServer
            (Configuration.GetConnectionString("ControleEstoqueConnection")));

            // Configurar a ID dos DAOS
            services.AddScoped<DevolucaoDAO>();
            services.AddScoped<CategoriaDAO>();
            services.AddScoped<EstoqueDAO>();
            services.AddScoped<FornecedorDAO>();
            services.AddScoped<MovimentoDAO>();
            services.AddScoped<ProdutoDAO>();
            services.AddScoped<UsuarioDAO>();
            services.AddScoped<EnderecoDAO>();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}
