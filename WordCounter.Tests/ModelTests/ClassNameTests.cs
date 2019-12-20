using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Counter.Models;


namespace Counter.Tests
{
  [TestClass]
  public class ItemTest
  { 
    [TestMethod]
    public void WordConstructor_CreatesInstance_Word()
    {
      Term example = new Term("string", "string of words");
      Assert.AreEqual(typeof(Term), example.GetType());
    }
    [TestMethod]
    public void Match_ChangesToUpper_String()
    {
      string up = "string";
      string up2 = "string of words";
      Term example  = new Term(up , up2);
      string result = example.Match(up, up2);
      Assert.AreEqual(up2, result);
    }
  }
}