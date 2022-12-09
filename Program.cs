
decimal valorSaque, valorRestante;
int  notas100, notas50, notas20, notas10, notas5, notas2;

Console.WriteLine("--- Caixa Eletrônico ---\n");
Console.Write("Digite o valor a ser sacado...: ");
valorSaque = Convert.ToDecimal(Console.ReadLine());


Console.Write("Digite sua senha com 6 dígitos: ");
Console.ReadLine();

if(valorSaque <= 0)

{
    Console.WriteLine("\nNão é possível realizar o saque.");
    return;
}

if (valorSaque % 1 > 0)
{
    Console.WriteLine("\nEste caixa não trabalha com moedas.");
    return;
}

valorRestante = valorSaque;

notas100 = (int)(valorRestante / 100);
valorRestante = valorRestante % 100;

notas50 = (int)(valorRestante / 50);
valorRestante = valorRestante % 50;

notas20 = (int)(valorRestante / 20);
valorRestante = valorRestante % 20;

notas10 = (int)(valorRestante / 10);
valorRestante = valorRestante % 10;

notas5 = (int)(valorRestante / 5);
valorRestante = valorRestante % 5;

notas2 = (int)(valorRestante / 2);
valorRestante = valorRestante % 2;


Console.WriteLine("\nO valor a retitar:");

if (notas100 > 0) Console.WriteLine($"{notas100} nota(s) de R$100,00");
if (notas50 > 0) Console.WriteLine($"{notas50} nota(s) de R$50,00");
if (notas20 > 0) Console.WriteLine($"{notas20} nota(s) de R$20,00");
if (notas10 > 0) Console.WriteLine($"{notas10} nota(s) de R$10,00");
if (notas5 > 0) Console.WriteLine($"{notas5} nota(s) de R$5,00");
if (notas2 > 0) Console.WriteLine($"{notas2} nota(s) de R$2,00");


Console.Write("Muito Obrigada(o)! Volte sempre.");