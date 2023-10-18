using System;

public class Kata
{
    public static int[] CountPositivesSumNegatives(int[] input)
    {
      int[] arrayVazio = new int[0];
      
      if(input == null || input.Length == 0) {
        return arrayVazio;
      }
      
      int contagemNumerosPositivos = 0;
      int somaNumerosNegativos = 0;
      int[] novoArray = new int[2];
      
      foreach(int numero in input) {
        if (numero > 0) {
          contagemNumerosPositivos++;
        } else {
          somaNumerosNegativos += numero;
        }
      }
      novoArray[0] = contagemNumerosPositivos;
      novoArray[1] = somaNumerosNegativos;
      return novoArray;
    }
}
