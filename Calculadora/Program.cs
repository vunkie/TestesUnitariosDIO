using Calculadora.Services;

CalculadoraImp c = new CalculadoraImp();

int num1 = 5;
int num2 = 10;

Console.WriteLine($"A soma de {num1} e {num2} é {c.Somar(num1, num2)}");
Console.WriteLine($"A subtração de {num1} e {num2} é {c.Subtrair(num1, num2)}");
Console.WriteLine($"A multiplicação de {num1} e {num2} é {c.Multiplicar(num1, num2)}");
Console.WriteLine($"A divisão de {num1} e {num2} é {c.Dividir(num1, num2)}");
Console.WriteLine($"O resto da divisão de {num1} e {num2} é {c.RestoDivisao(num1, num2)}");
Console.WriteLine($"A potência de {num1} e {num2} é {c.Potencia(num1, num2)}");
Console.WriteLine($"A raiz quadrada de {num1} é {c.RaizQuadrada(num1)}");
Console.WriteLine($"A raiz cúbica de {num1} é {c.RaizCubica(num1)}");
Console.WriteLine($"O logaritmo base 10 de {num1} é {c.LogaritmoBase10(num1)}");
Console.WriteLine($"O logaritmo natural de {num1} é {c.LogaritmoNatural(num1)}");
Console.WriteLine($"O fatorial de {num1} é {c.Fatorial(num1)}");
Console.WriteLine($"O {num2}° número de fibonacci é {c.Fibonacci(num2)}");
Console.WriteLine($"O número {num1} é par? " + (c.EhPar(num1)? "Sim" : "Não"));
Console.WriteLine($"O número {num2} é par? " + (c.EhPar(num2)? "Sim" : "Não"));