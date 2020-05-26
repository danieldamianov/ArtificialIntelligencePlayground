using System;
using System.IO;
using System.Threading.Tasks;

namespace CarsPricePrediction
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var text = File.ReadAllText("BrandsModels.txt");
            text = text.Replace(@"'",@"""");
            File.WriteAllText("BrandsModels.txt",text);
            MobileBgDataCollector mobileBgDataCollector = new MobileBgDataCollector();
            await mobileBgDataCollector.CollectData(0, 0);
        }
    }
}
