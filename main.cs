using System;

class MainClass {
  public static void Main (string[] args) {
  string r1,r2,r3;
  int num1,num2,num3;
  Console.WriteLine("Ingrese las medidas de los lados de un triangulo:");
  r1=Console.ReadLine();
  r2=Console.ReadLine();
  r3=Console.ReadLine();
  num1=int.Parse(r1);
  num2=int.Parse(r2);
  num3=int.Parse(r3);

  if((num1==num2) && (num2==num3))
  {Console.WriteLine("El triangulo es equilatero. Todos los lados igual");}
  else
  if(num1==num2)
  {Console.WriteLine("El triangulo es isosceles. Dos lados iguales, uno desigual");}
  else
  if(num1==num3)
  {Console.WriteLine("El triangulo es isosceles. Dos lados iguales, uno desigual");}
  else
  if(num2==num3)
  {Console.WriteLine("El triangulo es isosceles. Dos lados iguales, uno desigual");}
  else
  {Console.WriteLine("El triangulo es escaleno. Ningun lado igual");}
  }
}