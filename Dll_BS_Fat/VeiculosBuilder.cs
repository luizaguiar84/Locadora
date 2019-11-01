using System;

namespace BsFat
{
	public class VeiculosBuilder : Veiculos
	{

		public Veiculos Build()
		{
			return new Veiculos(Montadora, Modelo, AnoModelo, Portas, Cor, Placa, Renavam, Chassi, Lugares, Quilometragem, Status, Combustivel, ValorAtual, ValorDiaria, Observacoes, DataAquisicao, ArCondicionado, DirecaoHidraulica, VidroEletrico, AirBag, Abs, IsAtivo);
		}
		public VeiculosBuilder GetIsAtivo(bool isAtivo)
		{
			this.IsAtivo = isAtivo;
			return this;
		}
		public VeiculosBuilder GetAbs(bool abs)
		{
			this.Abs = abs;
			return this;
		}
		public VeiculosBuilder GetAirBag(bool airBag)
		{
			this.AirBag = airBag;
			return this;
		}
		public VeiculosBuilder GetVidroEletrico(bool vidroEletrico)
		{
			this.VidroEletrico = vidroEletrico;
			return this;
		}
		public VeiculosBuilder GetDirecaoHidraulica(bool direcaoHidraulica)
		{
			this.DirecaoHidraulica = direcaoHidraulica;
			return this;
		}
		public VeiculosBuilder GetArCondicionado(bool arCondicionado)
		{
			this.ArCondicionado = arCondicionado;
			return this;
		}
		public VeiculosBuilder GetObservacoes(string observacoes)
		{
			this.Observacoes = observacoes;
			return this;
		}
		public VeiculosBuilder GetDataAquisicao(DateTime dataAquisicao)
		{
			this.DataAquisicao = dataAquisicao;
			return this;
		}

		public VeiculosBuilder GetValorAtual(string valorAtual)
		{
			this.ValorAtual = valorAtual;
			return this;
		}
		public VeiculosBuilder GetValorDiaria(string valorDiaria)
		{
			if (string.IsNullOrEmpty(valorDiaria))
			{
				valorDiaria = "0";
			}
			this.ValorDiaria = Convert.ToDecimal(valorDiaria);
			return this;
		}
		public VeiculosBuilder GetCombustivel(string combustivel)
		{
			this.Combustivel = combustivel;
			return this;
		}
		public VeiculosBuilder GetStatus(string status)
		{
			this.Status = status;
			return this;
		}
		public VeiculosBuilder GetQuilometragem(int quilometragem)
		{
			this.Quilometragem = quilometragem;
			return this;
		}
		public VeiculosBuilder GetLugares(int lugares)
		{
			this.Lugares = lugares;
			return this;
		}
		public VeiculosBuilder GetCor(string cor)
		{
			this.Cor = cor;
			return this;
		}
		public VeiculosBuilder GetMontadora(string montadora)
		{
			this.Montadora = montadora;
			return this;
		}
		public VeiculosBuilder GetModelo(string modelo)
		{
			this.Modelo = modelo;
			return this;
		}
		public VeiculosBuilder GetAnoModelo(string anoModelo)
		{
			this.AnoModelo = anoModelo;
			return this;
		}
		public VeiculosBuilder GetPortas(int portas)
		{
			this.Portas = portas;
			return this;
		}
		public VeiculosBuilder GetPlaca(string placa)
		{
			this.Placa = placa;
			return this;
		}
		public VeiculosBuilder GetRenavam(string renavam)
		{
			this.Renavam = renavam;
			return this;
		}
		public VeiculosBuilder GetChassi(string chassi)
		{
			this.Chassi = chassi;
			return this;
		}
	}
}
