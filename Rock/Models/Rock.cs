using System.Collections.Generic;
using System;

namespace Rock.Models
{
  public class RockGame
  {
    private string _choice1;
    private string _choice2;
    // public string Choice1
    // {
    //   get { return _choice1; }
    // }
    // public string Choice2
    // {
    //   get { return _choice2; }
    // }

    public RockGame(string player1, string player2)
    {
      _choice1 = player1;
      _choice2 = player2;
    }

    public string RPSGame()
    {
      if(_choice1 == _choice2)
      {
        return "ties";
      } else if( _choice1 == "rock" && _choice2 == "scissor" || _choice1 == "paper" && _choice2 == "rock" || _choice1 == "scissor" && _choice2 == "paper")
      {
        return "wins";
      } else
      {
        return "loses";
      }   
    }
  }
}


/*
Rock v. Scissors = Rock wins
Rock v. Paper = Paper wins
Paper v. Scissors = Scissors wins

if tie nobody wins

return "wins, lose, tie" for player 1

*/