using System;
using System.Collections.Generic;

namespace MadLib.Models
{
  public class MadLibVariable
  {
    private string _firstAdjective;
    private string _secondAdjective;
    private string _firstHobby;
    private string _secondHobby;
    private string _thirdHobby;
    private string _food;



    public MadLibVariable(string firstAdjective, string secondAdjective, string firstHobby, string secondHobby, string thirdHobby, string food)
    {
      _firstAdjective = firstAdjective;
      _secondAdjective = secondAdjective;
      _firstHobby = firstHobby;
      _secondHobby = secondHobby;
      _thirdHobby = thirdHobby;
      _food = food;
    }
    public string Get_firstAdjective()
    {
      return _firstAdjective;
    }
    public string Get_secondAdjective()
    {
      return _secondAdjective;
    }
    public string Get_firstHobby()
    {
      return _firstHobby;
    }
    public string Get_secondHobby()
    {
      return _secondHobby;
    }
    public string Get_thirdHobby()
    {
      return _thirdHobby;
    }
    public string Get_food()
    {
      return _food;
    }
  }
}
