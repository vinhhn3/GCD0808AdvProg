using System;
using System.Collections.Generic;

namespace Inheritance.Lab
{
  class RandomList : List<string>
  {
    public RandomList()
    {

    }

    public string RandomString()
    {
      if (this.Count == 0)
      {
        return null;
      }
      else
      {
        var randomNumber = new Random().Next(0, this.Count - 1);
        var randomString = this[randomNumber];
        this.Remove(randomString);
        return randomString;
      }
    }
  }
}
