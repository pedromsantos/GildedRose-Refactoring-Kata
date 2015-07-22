namespace GildedRoseGoldenMaster
{
    using System;
    using System.IO;
    using System.Text;

    using GildedRose;

    using NUnit.Framework;

    [TestFixture]
    public class GildedRoseTests
    {
        [Test]
        public void VerifyAgainstGoldenMaster()
        {
            for (var i = 0; i < 31; i++)
            {
                var fakeoutput = new StringBuilder();

                Console.SetOut(new StringWriter(fakeoutput));
                Console.SetIn(new StringReader("a\n"));

                var numberOfDays = i.ToString();
                Program.Main(new[] { numberOfDays });
                var output = fakeoutput.ToString();

                var goldenMasterFile = File.OpenText($"GoldenMaster{numberOfDays}.txt");
                var goldenMasterOutput = goldenMasterFile.ReadToEnd();

                Assert.That(output, Is.EqualTo(goldenMasterOutput));
            }
        }

        [Test,Ignore]
        public void GenerateGoldenMaster()
        {
            //for (var i = 0; i < 31; i++)
            //{
            //    var fakeoutput = new StringBuilder();

            //    Console.SetOut(new StringWriter(fakeoutput));
            //    Console.SetIn(new StringReader("a\n"));

            //    var numberOfDays = i.ToString();
            //    Program.Main(new[] { numberOfDays });
            //    var output = fakeoutput.ToString();

            //    using (var file = File.CreateText($"GoldenMaster{numberOfDays}.txt"))
            //    {
            //        file.Write(output);
            //    }
            //}
        } 
    }
}
