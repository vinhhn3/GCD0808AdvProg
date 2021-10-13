using System;

namespace TemplateMethodPattern
{
  class AndroidBuilder : Builder
  {
    public override void AnalyzeAndDesign()
    {
      Console.WriteLine("Analyze and Design ... Android App ...");
    }

    public override void CollectRequirements()
    {
      Console.WriteLine("Collect Requirements ... Android App ...");

    }

    public override void Deploy()
    {
      Console.WriteLine("Deploy ... Android App ...");
    }

    public override void Implement()
    {
      Console.WriteLine("Implement ... Android App ...");
    }

    public override void Test()
    {
      Console.WriteLine("Test ... Android App ...");
    }
  }
}
