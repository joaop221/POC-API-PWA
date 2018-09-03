using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Utilidades.Web.Config;

namespace Utilidades.Web
{
	/// <summary>
	/// Classe de inicialização da aplicação
	/// </summary>
	public class Startup
	{
		/// <summary>
		/// Construtor da classe Startup
		/// </summary>
		/// <param name="configuration"></param>
		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		/// <summary>
		/// Configurações iniciais da aplicação
		/// </summary>
		public IConfiguration Configuration { get; }

		/// <summary>
		/// Método chamada pela aplicação em tempo de execução para configurar todos os serviços
		/// </summary>
		/// <param name="services">Serviços</param>
		public void ConfigureServices(IServiceCollection services)
		{
			// Configurando serviço MVC
			services.AddMvc();

			// Configurando o serviço de documentação do Swagger
			services.AddSwagger();

			// Adiciona controlador de headers na aplicação
			services.AddCors();
		}

		/// <summary>
		/// Método chamada pela aplicação em tempo de execução para configurar a aplicação
		/// </summary>
		/// <param name="app">Contexto da aplicação</param>
		/// <param name="env">Ambiente</param>
		public void Configure(IApplicationBuilder app, IHostingEnvironment env)
		{
			// Contexto de desenvolvimento da aplicação
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}

			// Inicia serviço MVC
			app.UseMvc();

			// Inicia serviço que permite urls consultarem API
			app.UseCors(options =>
			{
				options.WithOrigins("http://localhost:4200").AllowAnyHeader();
			});

			// Inicia serviço Swagger
			app.UseSwaggerConfig();
		}
	}
}