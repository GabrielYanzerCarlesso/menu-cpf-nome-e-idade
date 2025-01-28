// See https://aka.ms/new-console-template for more information
using System;
using System.Collections;
using System.ComponentModel.Design;
using System.Runtime.InteropServices;
class Program{

static void Main(){
string cpf;
string name;
string idade;

switch (
  Menu()
)
  {
    case 1: 
  Console.WriteLine("1 escreva seu nome"); 
  name = Console.ReadLine();
  Console.WriteLine($"seu nome é {name} ");

   Menu();
   break; 
   
    case 2: 
      Console.WriteLine("seu cpf é");
     cpf = Console.ReadLine();
     Console.WriteLine($" seu cpf é {cpf} ");
    Menu();
    break; 
 

    case 3: 
    Console.WriteLine("sua idade é ");
    idade = Console.ReadLine();
    Console.WriteLine($"sua idade é {idade}");
    Menu();
    break;
    default:  Menu();
    break; 
    
  }




static int Menu(){
  int escolha; 
  Console.WriteLine("0 Escolha uma opção do menu");
  Console.WriteLine("1 escreva seu nome"); 
  Console.WriteLine("2 cpf");
  Console.WriteLine("3 idade "); 
  escolha = int.Parse(Console.ReadLine());

return escolha;

    }  
 }
}