using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rock.Models;

namespace Rock.Tests
{
  [TestClass]
  public class RockTests
  {
    // Tests will go here!
    [TestMethod]
    public void RockGameConstructor_CreateInstanceOfRockGame_RockGame()
    {
      RockGame newGame = new RockGame("rock", "scissor");
      Assert.AreEqual(typeof (RockGame), newGame.GetType());
    }

    [TestMethod]
    public void RPSGame_DeterminesTie_String()
    {
      RockGame game = new RockGame("rock","rock");
      string p1 = game.RPSGame();
      Assert.AreEqual(p1,"ties");
    }
    [TestMethod]
    public void RPSGame_DeterminesRockWin_String()
    {
      RockGame game = new RockGame("rock","scissor");
      string p1 = game.RPSGame();
      Assert.AreEqual(p1,"wins");
    }

    [TestMethod]
    public void RPSGame_DeterminesPapperWin_String()
    {
      RockGame game = new RockGame("paper","rock");
      string p1 = game.RPSGame();
      Assert.AreEqual(p1,"wins");
    }
    
    [TestMethod]
    public void RPSGame_DeterminesScissorWin_String()
    {
      RockGame game = new RockGame("scissor","paper");
      string p1 = game.RPSGame();
      Assert.AreEqual(p1,"wins");
    }    
    
    [TestMethod]
    public void RPSGame_DeterminesP1Loss_String()
    {
      RockGame game = new RockGame("paper","scissor");
      string p1 = game.RPSGame();
      Assert.AreEqual(p1,"loses");
    }   
  }
}