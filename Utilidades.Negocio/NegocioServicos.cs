using System.Collections.Generic;
using Utilidade.Dados.Repositorio;
using Utilidades.Modelo;

namespace Utilidades.Negocio
{
	/// <summary>
	/// Classe de Negócio de Utilidades
	/// </summary>
	public class NegocioServicos : NegocioBase
	{
		private RepositorioServico repositorio;

		/// <summary>
		/// Contrutor da Classe de Negócio de Utilidades
		/// </summary>
		public NegocioServicos()
		{
			this.repositorio = new RepositorioServico();
		}

		/// <summary>
		/// Lista Serviços
		/// </summary>
		/// <returns></returns>
		public List<Servico> Lista()
		{
			return repositorio.Lista();
		}
	}
}