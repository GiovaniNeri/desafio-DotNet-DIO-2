using System.Text;
using System.Globalization;
using DesafioHotel.models;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa(nome: "Hóspede 1");
Pessoa p2 = new Pessoa(nome: "Hóspede 2");

hospedes.Add(p1);
hospedes.Add(p2);

// Cria a suíte

Console.WriteLine("Qual será o tipo da Suíte? ");
string tipoSuite = Console.ReadLine();
Console.WriteLine("Qual a capacidade da Suíte? ");
int capacidade = int.Parse(Console.ReadLine());
Console.WriteLine("Qual a diária da Suíte escolhida? ");
decimal valorDiaria = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Suite suite = new Suite(tipoSuite: tipoSuite, capacidade: capacidade, valorDiaria: valorDiaria);

// Cria uma nova reserva, passando a suíte e os hóspedes
Console.WriteLine("Quantos dias serão a reserva?");
int quantidaDeDias = int.Parse(Console.ReadLine());
Reserva reserva = new Reserva(diasReservados: quantidaDeDias);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

// Exibe a quantidade de hóspedes e o valor da diária
Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");