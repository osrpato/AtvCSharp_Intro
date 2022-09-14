int a1, a2, a3;

Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
Console.Write("Forneça o primeiro número : ");
a1 = int.Parse(Console.ReadLine());
Console.Write("Forneça o segundo número : ");
a2 = int.Parse(Console.ReadLine());
Console.Write("Forneça o terceiro número : ");
a3 = int.Parse(Console.ReadLine());
if ((a1 + a2 + a3 > 30) && (a1 == a2))
{
    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
    Console.WriteLine("A resposta é maior que 30");
}
else
{
    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
    Console.WriteLine("A resposta NÃO é maior que 30");

}
if (a1 == a2)
{
    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
    Console.WriteLine("E o primeiro número fornecido é igual ao segundo.");
}
else
{
    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
    Console.WriteLine("E o primeiro número fornecido NÃO é igual ao segundo.");
}