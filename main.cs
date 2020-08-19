using System;

class MainClass {
  
  public static void Main () {
    float n1, n2, nota1, nota2, nota3, nota4;
    //numeros para o ex3 soma
    Console.Write("EX03"+"\n"+"Digite o primeiro número: ");
    n1 = float.Parse(Console.ReadLine());

    Console.Write("Digite o segundo número: ");
    n2 = float.Parse(Console.ReadLine());
    Soma(n1, n2);
    //notas para ex4 media
    Console.Write("EX04"+"\n"+"Digite a primeira nota: ");
    nota1 = float.Parse(Console.ReadLine());

    Console.Write("Digite a segunda nota: ");
    nota2 = float.Parse(Console.ReadLine());
    
    Console.Write("Digite a terceira nota: ");
    nota3 = float.Parse(Console.ReadLine());

    Console.Write("Digite a quarta nota: ");
    nota4 = float.Parse(Console.ReadLine());

    Media(nota1, nota2, nota3, nota4);
  }

  public static void Soma(float n1,float n2) {
    float soma;
    soma = n1 + n2;
    Console.WriteLine (" O número informado foi "+ soma+"\n");
  }

  public static void Media(float nota1,float nota2,float nota3,float nota4) {
      float media;
      media = (
        nota1 + nota2 + nota3 + nota4) / 4;
      Console.WriteLine (" O número informado foi "+ media);
    }

 

}