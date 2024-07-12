namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        // Lista do tipo Pessoa. Ela diz que a lista é desse tipo, mas não define esse tipo. Ele será definido fora da criação da lista.
        // O que é uma pessoa, nesse caso? É um objeto com três construtores diferentes, podendo receber: três strings (nome, sobrenome, nomecompleto), só uma (nome) ou outra string qualquer. 
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
            // *IMPLEMENTE AQUI*

            if (Suite.Capacidade >= hospedes.Count)
            {
                Hospedes = hospedes;
                // Ele criou uma variável hospedes (uma lista que recebe pessoa) e criou uma validação nela de if e else. Se validar, essa variável vai para a propriedade Hospedes
            }
            else
            {
                // Retorna uma exception caso a capacidade seja menor que o número de hóspedes recebido
                throw new Exception("A capacidade é menor que o número de hóspedes recebido.");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // TODO: Retorna a quantidade de hóspedes (propriedade Hospedes)
            // *IMPLEMENTE AQUI*

            int quantidadeDeHospedes = Hospedes.Count;

            return quantidadeDeHospedes;
        }

        public decimal CalcularValorDiaria()
        {
            // TODO: Retorna o valor da diária
            // Cálculo: DiasReservados X Suite.ValorDiaria
            // *IMPLEMENTE AQUI*

            decimal valor = 0;

            if (DiasReservados < 10)
            {
                valor = DiasReservados * Suite.ValorDiaria;
            }
                else
                {
                    valor = (DiasReservados * Suite.ValorDiaria) * 0.90m;
                    // Aqui pode ocorrer um erro caso eu multiplique por 0.90 e não por 0.90m. Isso ocorre porque o compilador interpreta que 0.90 é um double, não um decimal.
                }

            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
            return valor;
        }
    }
}