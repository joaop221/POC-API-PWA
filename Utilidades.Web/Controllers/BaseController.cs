using Microsoft.AspNetCore.Mvc;
using System;
using Utilidades.Modelo.Response;
using Utilidades.Modelo.Tratamento;

namespace Utilidades.Web.Controllers
{
	/// <summary>
	/// Controller base da aplicação
	/// </summary>
	public abstract class BaseController : Controller
	{
		/// <summary>
		/// Construtor da classe
		/// </summary>
		public BaseController()
		{
		}

		/// <summary>
		/// Execução tratada
		/// </summary>
		/// <typeparam name="TResult">Tipo do Resultado da chamada</typeparam>
		/// <param name="action">Ação da Execução</param>
		/// <returns>Resultado da chamada</returns>
		protected IActionResult ExecucaoTratada<TResult>(Action<TResult> action)
			where TResult : BaseResponse, new()
		{
			TResult retorno = new TResult();

			try
			{
				action.Invoke(retorno);
			}
			catch (NegocioExcacao ex)
			{
				retorno.CodigoRetorno = ex.Codigo;
				retorno.Mensagem = ex.Mensagem;
			}
			catch (DadosExcecao ex)
			{
				retorno.CodigoRetorno = ex.Codigo;
				retorno.Mensagem = ex.Mensagem;
			}
			catch (Exception ex)
			{
				retorno.CodigoRetorno = 500;
				retorno.Mensagem = ex.Message;
			}

			return StatusCode(retorno.CodigoRetorno, retorno);
		}
	}
}