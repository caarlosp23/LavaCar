using System;

namespace Lava
{
    public class Cliente
    {
        public int Id { get; set; }
        public int Identificacao { get; set; }
        public string CpfCnpj { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string CEP { get; set; }
        public string Email { get; set; }
        public string Rua { get; set; }
        public string NumeroEndereco { get; set; }
        public string Bairro { get; set; }
        public string Complemento { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public DateTime DataHoraCadastro { get; set; }

    }
}
