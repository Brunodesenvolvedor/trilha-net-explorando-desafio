using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa(nome: "Hóspede 1");
Pessoa p2 = new Pessoa(nome: "Hóspede 2");
// Instanciação de acordo com o método construtor da classe Pessoa

hospedes.Add(p1);
hospedes.Add(p2);

Suite suite = new Suite(tipoSuite: "Premium", capacidade: 1, valorDiaria: 30);
// Cria a suíte. Classe suite e objeto Suite, nos moldes da classe

// Cria uma nova reserva, passando a suíte e os hóspedes
Reserva reserva = new Reserva(diasReservados: 5);
reserva.CadastrarSuite(suite);
// Cadastrando a Suite Premium, criada anteriormente
reserva.CadastrarHospedes(hospedes);
// Cadastranso os hóspedes p1 e p2. 
// Na classe Reserva está chamando os métodos cadastrar suite e hóspede e passando uma variável

Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");
// Exibe a quantidade de hóspedes e o valor da diária