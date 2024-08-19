using System.Runtime.CompilerServices;

namespace DesafioProjetoHospedagem.Models
{
	public class Reserva
	{
		public List<Pessoa> Hospedes { get; set; }
		public Suite Suite { get; set; }
		public int DiasReservados { get; set; }

		public Reserva() { }

		public Reserva(int diasReservados)
		{
			DiasReservados = diasReservados;
		}

		public void CadastrarHospedes(List<Pessoa> hospedes)
		
		{
			// TODO: Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido
			// *IMPLEMENTADO!
			bool capacidadeMaxima =  Suite.Capacidade >= hospedes.Count();
			if (capacidadeMaxima)
			{
				Hospedes = hospedes;
			}
			else
			{
				// TODO: Retornar uma exception caso a capacidade seja menor que o número de hóspedes recebido
				// *IMPLEMENTADO!
				throw new Exception($" Capacidade máxima: {Suite.Capacidade} . A quantidade de hospedes ultrapassa a Capacidade máxima da Suíte.");
			}
		}

		public void CadastrarSuite(Suite suite)
		{
			Suite = suite;
		}

		public int ObterQuantidadeHospedes()
		{
			// TODO: Retorna a quantidade de hóspedes (propriedade Hospedes)
			// *IMPLEMENTADO!
			
			return Hospedes.Count();
		}

		public decimal CalcularValorDiaria()
		{
			// TODO: Retorna o valor da diária
			// Cálculo: DiasReservados X Suite.ValorDiaria
			// *IMPLEMENTADO!
			
			decimal valor = DiasReservados * Suite.ValorDiaria;

			// Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
			// *IMPLEMENTADO!
			bool descontoDezDias = DiasReservados>= 10;
			if (descontoDezDias)
			{
				valor = valor - (valor / 10) ;
				
			}

			return valor;
		}
	}
}