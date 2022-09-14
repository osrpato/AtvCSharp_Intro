var fibonacciNumbers = new List<int> { 1, 1 };

while (fibonacciNumbers.Count < 20)
{
    var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
    var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];

    fibonacciNumbers.Add(previous + previous2);
}
foreach (var item in fibonacciNumbers)
    Console.WriteLine(item);

//Esse código nos dá a Serquência Fibonacci, o qual gera os 20 primeiros números.
//A sequência ocorre assim : Tem o primeiro valor, que é 1, depois vem 1 de novo e apartir desse para frente...
//... qualquer número será o resultado da soma dos dois anteriores, exemplo :
// 1
// 1
// 2 <- porque 1 + 1 é 2
// 3 <- porque 1 + 2 é 3
//etc.