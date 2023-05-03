using System.Collections.Generic;
using System;

namespace CoinCombination.Models
{
  public class CoinCalculation
  {
      // private int _quarter;
      // public int Quarter
      // {
      //   get { return _quarter; }
      //   set { _quarter = value; }
      // }
      
    public int Quarter { get; set; }
    public int Dime { get; set; }  
    public int Nickel { get; set; } 
    public int Penny { get; set; }
    public int Cent { get; set; }

    public CoinCalculation(int numberQ, int numberD, int numberN, int numberP, int centNum)
    {
      Quarter = numberQ;
      Dime = numberD;
      Nickel = numberN;
      Penny = numberP;
      Cent = centNum;
    }
    
    // public int Dollar { get; set; }
    // public CoinCalculation(int numberQ, int numberD, int numberN, int numberP, int dollarNum) : this(numberQ, numberD, numberN, numberP) 
    // {
        // Quarter = numberQ;
        // Dime = numberD;
        // Nickel = numberN;
        // Penny = numberP;
    //   Dollar = CentNum;
    // }

    public int[] CountCoins()
    {
      int[] coins = {0, 0, 0, 0};
      // for quarter
      if(Cent >= 25 )   
      {
        int numberQ = (int)(Cent / 25);
        // return Quarter = numberQ;
        coins[0] = numberQ;
        Console.WriteLine(numberQ);
      }
      // for dime  35cent  1quarter 1 dime 25+10 
      if((Cent % 25) >= 10 )
      {    
        // return quater
        // decimal decimalQ = Math.Round((decimal)(Cent / 25));
        // int numberQ = (int) decimalQ;
        int numberD = (int)((Cent % 25) / 10);
        // return Quarter = numberQ;
        // return Dime = numberD;
        coins[1] = numberD;
      }

      // for nickel 40
      if(((Cent % 25) % 10) >= 5 )
      {
        int numberN = (int)(((Cent % 25) % 10) / 5);
        coins[2] = numberN;
        // return numberN;
      }

      // for penny  
      if(((Cent % 25) % 10) % 5 >= 0)
      {
        int numberP = (int)(((Cent % 25) % 10) % 5);
        // return numberP;
        coins[3] = numberP;
      }
      // Console.WriteLine(coins[0]);
      return coins;
      
    }
  }
}
