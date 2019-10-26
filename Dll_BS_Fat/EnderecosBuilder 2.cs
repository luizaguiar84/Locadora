namespace Dll_BS_Fat
{
	public class EnderecosBuilder : Enderecos
	{
		public Enderecos Build()
		{
			return new Enderecos(Cep, Logradouro, Num, Complemento, Bairro, Cidade, Uf);
		}

		public EnderecosBuilder GetCep(string cep)
		{
			this.Cep = cep;
			return this;
		}
		public EnderecosBuilder GetLogradouro(string logradouro)
		{
			this.Logradouro = logradouro;
			return this;
		}
		public EnderecosBuilder GetNumero(string numero)
		{
			this.Num = numero;
			return this;
		}
		public EnderecosBuilder GetComplemento(string complemento)
		{
			this.Complemento = complemento;
			return this;
		}
		public EnderecosBuilder GetBairro(string bairro)
		{
			this.Bairro = bairro;
			return this;
		}
		public EnderecosBuilder GetCidade(string cidade)
		{
			this.Cidade = cidade;
			return this;
		}
		public EnderecosBuilder GetUf(string uf)
		{
			this.Uf = uf;
			return this;
		}
	}
}
