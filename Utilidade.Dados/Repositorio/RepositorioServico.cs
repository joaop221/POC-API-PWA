using System;
using System.Collections.Generic;
using Utilidade.Dados.Core;
using Utilidades.Modelo;

namespace Utilidade.Dados.Repositorio
{
	/// <summary>
	/// Repositório de Acesso a utilidades
	/// </summary>
	public class RepositorioServico : RepositorioBase<Servico, int>
	{
		/// <summary>
		/// Construtor do repositório de utilidades
		/// </summary>
		public RepositorioServico()
		{
		}

		/// <summary>
		/// Geração mockada de lista
		/// </summary>
		/// <returns>Lista de Serviços</returns>
		public override List<Servico> Lista()
		{
			var lista = new List<Servico>();
			var random = new Random();

			for(var i=0; i < 10; i++)
			{
				lista.Add(new Servico()
				{
					IdServico = random.Next(),
					Nome = random.Next().ToString(),
					Ativa = random.Next() % 2 == 0 ? true : false
				});
			}

			return lista;
		}
	}
}