namespace Utilidades.Modelo.Response
{
	/// <summary>
	/// Modelo padrão de response da aplicação
	/// </summary>
	public abstract class BaseResponse
	{
		/// <summary>
		/// Mensagem de retorno da consulta
		/// </summary>
		public virtual string Mensagem { get; set; }

		/// <summary>
		/// Código de retorno para rastrabilidade da execução
		/// </summary>
		public virtual int CodigoRetorno { get; set; }
	}
}