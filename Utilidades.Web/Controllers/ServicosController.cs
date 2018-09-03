using Microsoft.AspNetCore.Mvc;
using Utilidades.Modelo;
using Utilidades.Modelo.Response;
using Utilidades.Negocio;

namespace Utilidades.Web.Controllers
{
	/// <summary>
	/// Controles de Utilidades
	/// </summary>
	[Route("api/[controller]")]
	public class ServicosController : BaseController
	{
		private NegocioServicos negocio;

		/// <summary>
		/// Contrutor do controller de Serviços
		/// </summary>
		public ServicosController()
		{
			this.negocio = new NegocioServicos();
		}

		/// <summary>
		/// Consulta Lista de Serviços
		/// </summary>
		/// <returns>Lista de Serviços</returns>
		[HttpGet(template: "lista")]
		public IActionResult Lista()
		{
			return ExecucaoTratada<ListResponse<Servico>>((retorno) =>
			{
				retorno.CodigoRetorno = 200;
				retorno.Mensagem = "Consulta efetuada com sucesso";
				retorno.Item = negocio.Lista();
			});
		}
	}
}