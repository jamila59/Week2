using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
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
    public void SentenceConstructor_CreatesInstance_Sentence()
    {
      Term example = new Term("string", "string of words");
      Assert.AreEqual(typeof(Term), example.GetType());
    }

    [TestMethod]
    public void RepeatCounter_ChangesWordToUpper_String()
    {
      string input = "string";
      string inputUpper = input.ToUpper();
      Assert.AreEqual("STRING", inputUpper);
    }
    [TestMethod]
    public void RepeatCounter_ChangesSentenceToUpper_String()
    {
      string inputSentence = "string sentence";
      string inputUpper = inputSentence.ToUpper();
      Assert.AreEqual("STRING SENTENCE", inputUpper);
    }
    [TestMethod]
    public void RepeatCounter_ChecksForMatches_Int()
    {
      string up = "string";
      string up2 = "string of words";
      Term example  = new Term(up , up2);
      int result = example.RepeatCounter(up, up2);
      Assert.AreEqual(1, result);
    }
    [TestMethod]
    public void RepeatCounter_ChecksForNonMatches_Int()
    {
      string up = "string";
      string up2 = "strings of words";
      Term example  = new Term(up , up2);
      int result = example.RepeatCounter(up, up2);
      Assert.AreEqual(0, result);
    }
    [TestMethod]
    public void RepeatCounter_ChecksForMultipleMatches_Int()
    {
      string up = "string";
      string up2 = "string of strings in a string array full of string inputs";
      Term example  = new Term(up , up2);
      int result = example.RepeatCounter(up, up2);
      Assert.AreEqual(3, result);
    }
  }
}