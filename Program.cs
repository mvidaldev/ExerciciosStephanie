Opcoes();

void Opcoes()
{
    Console.WriteLine("Digite uma opção para Continuar ou 0 para Sair:  " +
                      "\n 1 - Programa Notas" +
                      "\n 2 - Programa Baskara" +
                      "\n 3 - Programa Menor Numero");
    int? opcao = int.Parse(Console.ReadLine());
    switch (opcao)
    {
        case 1:
            ProgramadeNotas();
            Limpar();
            Opcoes();
            break;
        case 2:
            Baskara();
            Limpar();
            Opcoes();
            break;
        case 3:
            Menordetres();
            Limpar();
            Opcoes();

            break;

        default: ; 
            Default();
            break;
    }
}

void Limpar()
{
    Console.ReadKey();
    Console.Clear();
}

void ProgramadeNotas()
{
    Console.WriteLine("Programa Notas \n");
    decimal numero1, numero2, media;
    Console.WriteLine("Digite a primeira nota: ");
    numero1 = Convert.ToDecimal(Console.ReadLine());
    Console.WriteLine("Digite a segunda nota: ");
    numero2 = Convert.ToDecimal(Console.ReadLine());
    media = (numero1 + numero2) / 2;
    Console.WriteLine($"Media Final: {media,0:N}");
    if (media <= 60)
    {
        Console.WriteLine("Reprovado");
    }
    else
    {
        Console.WriteLine("Aprovado");
    }
}
void Baskara()
{
    Console.WriteLine("Programa Baskara \n");
    Console.WriteLine("Digite os coeficientes da equação ax² + bx + c = 0");
        
    Console.Write("a = ");
    double a = Convert.ToDouble(Console.ReadLine());

    Console.Write("b = ");
    double b = Convert.ToDouble(Console.ReadLine());

    Console.Write("c = ");
    double c = Convert.ToDouble(Console.ReadLine());

    double delta = b * b - 4 * a * c;

    if (delta > 0)
    {
        double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
        double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
        Console.WriteLine($"As raízes são x1 = {x1} e x2 = {x2}");
    }
    else if (delta == 0)
    {
        double x = -b / (2 * a);
        Console.WriteLine($"A única raiz é x = {x}");
    }
    else
    {
        Console.WriteLine("A equação não possui raízes reais.");
    }
}
void Menordetres(){
    // Solicita três números ao usuário
    Console.WriteLine("Por favor, insira três números:");

    Console.Write("Primeiro número: ");
    double num1 = Convert.ToDouble(Console.ReadLine());

    Console.Write("Segundo número: ");
    double num2 = Convert.ToDouble(Console.ReadLine());

    Console.Write("Terceiro número: ");
    double num3 = Convert.ToDouble(Console.ReadLine());

    // Determina o menor número
    double menorNumero = Math.Min(Math.Min(num1, num2), num3);

    // Exibe o resultado
    Console.WriteLine($"O menor número entre {num1}, {num2} e {num3} é: {menorNumero}");

}
void Default()
{
    Console.WriteLine("Digite uma opção válida ou 0 para sair;");
    if (Console.ReadLine() == "0")
    {
        Environment.Exit(0);
                
    }
    else
    {
        Opcoes();
    }
}