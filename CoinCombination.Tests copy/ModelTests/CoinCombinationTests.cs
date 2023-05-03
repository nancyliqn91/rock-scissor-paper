using Microsoft.VisualStudio.TestTools.UnitTesting;
using CoinCombination.Models;

namespace CoinCombination.Tests
{
  [TestClass]
  public class CoinCombinationTests
  {
    // Tests will go here!
    [TestMethod]
    public void CoinCombinationConstructor_CreateInstanceOfCoinCombination_CoinCombination()
    {
      CoinCalculation newCoin = new CoinCalculation(1, 2, 3, 4, 1);
      Assert.AreEqual(typeof (CoinCalculation), newCoin.GetType());
    }

    [TestMethod]
    public void Get4Coin_Return4Coin_Int()
    {
      // Arrange
      CoinCalculation newCoin = new CoinCalculation(1, 2, 3, 4, 85);
      // Act
      int[] coinNum = {3, 1, 0, 0};
      int[] result = newCoin.CountCoins();
      // Assert
      Assert.AreEqual(coinNum[1], result[1]);
    }

    [TestMethod]
    public void CountCoins_ReturnPennyCoins_Int()
    {
      // Arrange
      CoinCalculation newCoin = new CoinCalculation(1, 2, 3, 4, 76);
      // Act
      int[] pennyResult= {3, 0, 0, 1};
      int[] coinResult = newCoin.CountCoins();
      // Assert
      Assert.AreEqual(1, coinResult[3]);
    }
    
    // [TestMethod]
    // public void CountCoins_ReturnPennyCoins_Int()
    // {
    //   // Arrange
    //   CoinCalculation newCoin = new CoinCalculation(1, 2, 3, 4, 43); 
    //   // Act
    //   int coinResult = newCoin.CountCoins();
    //   // Assert
    //   Assert.AreEqual(3, coinResult);
    // }

  }
}