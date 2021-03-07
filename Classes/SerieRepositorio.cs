using System;
using System.Collections.Generic;
using project002.Interfaces;

namespace project002
{
	public class SerieRepositorio : IRepositorio<Serie>
	{
        private List<Serie> listaSerie = new List<Serie>();
		public void Atualiza(int id, Serie objeto)
		{
			if (listaSerie.Count <= id){
				Console.WriteLine();
				Console.WriteLine("Erro, série informada não existe!");
				return;
			}			
			listaSerie[id] = objeto;
		}

		public void Exclui(int id)
		{
			if (listaSerie.Count <= id){
				Console.WriteLine();
				Console.WriteLine("Erro, série informada não existe!");
				return;
			}
			listaSerie[id].Excluir();
		}

		public void Insere(Serie objeto)
		{
			listaSerie.Add(objeto);
		}

		public List<Serie> Lista()
		{
			return listaSerie;
		}

		public int ProximoId()
		{
			return listaSerie.Count;
		}

		public Serie RetornaPorId(int id)
		{
			return listaSerie[id];
		}
	}
}