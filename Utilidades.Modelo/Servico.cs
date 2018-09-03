namespace Utilidades.Modelo
{
	/// <summary>
	/// Modelo de Serviço
	/// </summary>
	public class Servico
	{
		/// <summary>
		/// Id da Serviço
		/// </summary>
		public int IdServico { get; set; }

		/// <summary>
		/// Nome da Serviço
		/// </summary>
		public string Nome { get; set; }

		/// <summary>
		/// Indica se Serviço está ativa
		/// </summary>
		public bool Ativa { get; set; }
	}
}