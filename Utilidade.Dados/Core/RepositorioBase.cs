using System.Collections.Generic;

namespace Utilidade.Dados.Core
{
	/// <summary>
	/// Modelo de banco base
	/// Instancia conexões com banco e mecanismos de acesso importantes
	/// </summary>
	/// <typeparam name="TEntidade">Entidade</typeparam>
	/// <typeparam name="TChave">Chave</typeparam>
	public class RepositorioBase<TEntidade, TChave> : IRepositorioBase<TEntidade, TChave> where TEntidade : new()
	{
		/// <summary>
		/// Construtor da classe de repositório
		/// </summary>
		public RepositorioBase()
		{
		}

		/// <summary>
		/// Método de listagem genérico
		/// </summary>
		/// <returns>Entidade</returns>
		public virtual List<TEntidade> Lista()
		{
			return new List<TEntidade>() { new TEntidade() };
		}
	}
}