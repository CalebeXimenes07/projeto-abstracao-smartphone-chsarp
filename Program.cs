using ProejtoAbstracaoCelular.Models;

Console.WriteLine("Insira o modelo: ");
string entradaModelo = Console.ReadLine();

Console.WriteLine("Insira o IMEI: ");
string entradaImei = Console.ReadLine();

Console.WriteLine("Insira o número: ");
string entradaNumero = Console.ReadLine();

Console.WriteLine("Insira o memória: ");
int entradaMemoria = int.Parse(Console.ReadLine());

Console.WriteLine("Samsung\n");

Smartphone samsung = new Samsung(modelo: entradaModelo, imei: entradaImei, numero: entradaNumero, memoria: entradaMemoria);

Console.Clear();

Console.WriteLine("Insira o app que você deseja instalar: ");
string entradaNomeApp = Console.ReadLine();

Console.WriteLine($"{entradaModelo}\n{entradaMemoria}gb");

samsung.ReceberLigacao();
samsung.InstalarAplicativo(entradaNomeApp);
