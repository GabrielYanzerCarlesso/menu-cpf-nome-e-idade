// See https://aka.ms/new-console-template for more information
using System;
using System.Collections;
using System.ComponentModel.Design;
using System.Runtime.InteropServices;

//Crie um projeto que receba dois valores e depois com esses valores:
// some, divida, multiplique e subitração
// crie uma função para cada (soma, divisão, multiplicaçaõ ,, etc..)
class Program{

static void Main(){
float A; 
float B;
float Resultado;

switch (
  Menu()
  ){
    case 1: 
    Console.WriteLine("coloque números para fazer a soma");
    Console.WriteLine("digite o primeiro numero:");
    A = float.Parse(Console.ReadLine());
    Console.WriteLine("digite o segundo numero:");
    B = float.Parse(Console.ReadLine());
    
    Resultado = Soma(A,B);

    Console.WriteLine($"O Resultado da Soma é {Resultado}");
      Menu();
    break; 
     
    case 2: 
      Console.WriteLine("coloque o primeiro número da divisão");
      A = float.Parse(Console.ReadLine());
      Console.WriteLine("Coloque o segundo número da divisão");
      B = float.Parse(Console.ReadLine());
      Resultado = Divisao(A,B);
      
      Console.WriteLine($"O Resultado da Divisão  é {Resultado}");
      
      Menu();
    break; 
 
    case 3: 
      Console.WriteLine("coloque o primeiro número da multiplicação");
      A = float.Parse(Console.ReadLine());
      Console.WriteLine("digite o segundo número para multiplicação");
      B = float.Parse(Console.ReadLine());
      Resultado = Multiplicacao(A,B);
      Console.WriteLine($"seu resultado da multiplicação é {Resultado} ");
      Menu();
    break;
    
    case 4:
      Console.WriteLine("coloque seu primeiro número da subtração");
      A = float.Parse(Console.ReadLine());
      Console.WriteLine("escreva o segundo número para a subtração");
      B = float.Parse(Console.ReadLine());
      Resultado = Subtracao(A,B);
      Console.WriteLine($"seu resultado é {Resultado}");
      Menu();
    break;

    default:  
      Menu();
    break; 
    
  }
 }
  static int Menu(){
    int escolha; 
    Console.WriteLine("Escolha uma opção do menu");
    Console.WriteLine("1 - Soma"); 
    Console.WriteLine("2 - Multiplicação");
    Console.WriteLine("3 - Divisão"); 
    Console.WriteLine("4 - Subitração"); 
    escolha = int.Parse(Console.ReadLine());
    return escolha;
  }
  
   static float Soma(float A, float B){
    return A+B;
   }

   static float Divisao(float A, float B){
    return A / B;
   }
    
   static float Multiplicacao(float A,float B){
    return A * B;
   }
    
    static float Subtracao(float A,float B){
      return A - B;
    }
}
