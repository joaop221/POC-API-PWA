using System.Collections.Generic;

namespace Utilidade.Dados.Core
{
	/// <summary>
	/// Define padrões de criação de repositórios
	/// </summary>
	/// <typeparam name="TEntidade">Entidade da Consulta</typeparam>
	/// <typeparam name="TChave">Chave da Consulta</typeparam>
	public interface IRepositorioBase<TEntidade, TChave>
	{
		/// <summary>
		/// Lista Entidade
		/// </summary>
		/// <returns>Lista de Entidade</returns>
		List<TEntidade> Lista();
	}
}