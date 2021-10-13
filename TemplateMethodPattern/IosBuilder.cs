using System;

namespace TemplateMethodPattern
{
  class IosBuilder : Builder
  {
    public override void AnalyzeAndDesign()
    {
      Console.WriteLine("Analyze and Design ... iOS App ...");
    }

    public override void CollectRequirements()
    {
      Console.WriteLine("Collect Requirements ... iOS App ...");

    }

    public override void Deploy()
    {
      Console.WriteLine("Deploy ... iOS App ...");
    }

    public override void Implement()
    {
      Console.WriteLine("Implement ... iOS App ...");
    }

    public override void Test()
    {
      Console.WriteLine("Test ... iOS App ...");
    }
  }
}
