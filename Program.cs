using System;
using CSharpShellCore;
namespace Calculadora{
class Classe{
static void Main(String[] args){

double num1 = 0;
double num2 = 0;
double resultado = 0;


do{
Console.WriteLine("----------------------------");
Console.WriteLine("bem vindo a calculadora");
Console.WriteLine("----------------------------");

Console.Write("insira o 1° número: ");
num1 = Convert.ToDouble(Console.ReadLine());

Console.Write("insira o 2° número: \n ");
num2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("escolha uma opção ");
Console.WriteLine("\t+: somar");
Console.WriteLine("\t-: subtrair");
Console.WriteLine("\t*: multiplicar");
Console.WriteLine("\t/: dividir");

switch(Console.ReadLine()){

case "+":
resultado = num1 + num2;
Console.WriteLine($"o resultado de {num1} + {num2} é "+ resultado);
break;

case "-":
resultado = num1 - num2;
Console.WriteLine($"o resultado de {num1} - {num2} é "+ resultado);
break;

case "*":
resultado = num1 * num2;
Console.WriteLine($"o resultado de {num1} * {num2} é "+ resultado);
break;


case "/":
resultado = num1 / num2;
Console.WriteLine($"o resultado de {num1} / {num2} é "+ resultado);
break;

default:
Console.WriteLine("essa opção não é valida ");
break;



}

Console.WriteLine("gostaria de usar novamente? (S) = sim (N) = não");
}while(Console.ReadLine().ToUpper() == "S");

Console.WriteLine(" obrigado por usar a calcular ");


}

}
}