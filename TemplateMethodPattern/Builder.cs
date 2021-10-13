using System;

namespace TemplateMethodPattern
{
  abstract class Builder
  {
    // Template method
    public void Build()
    {
      Console.WriteLine("========================");
      CollectRequirements();
      AnalyzeAndDesign();
      Implement();
      Test();
      Deploy();
    }

    // abstract methods
    abstract public void CollectRequirements();
    abstract public void AnalyzeAndDesign();
    abstract public void Implement();
    abstract public void Test();
    abstract public void Deploy();
  }
}
