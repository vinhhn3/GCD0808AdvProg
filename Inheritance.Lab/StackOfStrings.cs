using System.Collections.Generic;

namespace Inheritance.Lab
{
  class StackOfStrings : Stack<string>
  {
    public StackOfStrings()
    {

    }

    public bool IsEmpty()
    {
      if (this.Count == 0) return true;
      else return false;
    }
  }
}
