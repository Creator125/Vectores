using System;

class MainClass {
  public static void Main (string[] args) {
    
    int[] notas = new int[7];
    notas[0] = 14;
    notas[1] = 15;
    notas[2] = 13;
    notas[3] = 11;
    notas[4] = 16;
    notas[5] = 18;
    notas[6] = 19;

    int suma = 0;
    double promedio;

    for(int i=0; i<=6; i++){
      suma = suma + notas[i];
    }
  promedio = suma / 7;
  Console.WriteLine("El promedio es: "+ promedio);
  }
}