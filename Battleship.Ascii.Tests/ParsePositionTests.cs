
namespace Battleship.Ascii.Tests
{
   using Battleship.GameController.Contracts;
   using Microsoft.VisualStudio.TestTools.UnitTesting;

   [TestClass]
   public class ParsePositionTests
   {
      [TestMethod]
      public void ParseLetterNumber()
      {
         var actual = Program.ParsePosition("A1");

         var expected = new Position(Letters.A, 1);

         Assert.AreEqual(expected, actual);
      }

      [TestMethod]
      public void testHitColor()
      {
         Program.showHit();
         Assert.AreEqual(System.Console.ForegroundColor, System.ConsoleColor.Red);
      }

       [TestMethod]
      public void testWaterColor()
      {
         Program.showWater();
         Assert.AreEqual(System.Console.ForegroundColor, System.ConsoleColor.Blue);
      }

       [TestMethod]
      public void testInstructionsColor()
      {
         Program.ShowInstruction("Message");
         Assert.AreEqual(System.Console.ForegroundColor, System.ConsoleColor.Green);
      }

       [TestMethod]
      public void testPositionColor()
      {
         Program.ShowPosition("test");
         Assert.AreEqual(System.Console.ForegroundColor, System.ConsoleColor.Cyan);
      }

        [TestMethod]
      public void testShowStep()
      {
         Program.ShowStep();
         Assert.AreEqual(System.Console.ForegroundColor, System.ConsoleColor.White);
      }
   }
}
