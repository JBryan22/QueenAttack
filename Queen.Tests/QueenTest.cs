using Microsoft.VisualStudio.TestTools.UnitTesting;
using Queens.Models;
using System;

namespace Queens.Test
{
  [TestClass]
  public class QueenTest : IDisposable
  {
    [TestMethod]
    public void CanAttack_HorizontalCheck_True()
    {
      //Arrange
      Queen queen = new Queen(4, 4);

      //Act
      bool result = queen.CanAttack(4, 6);
      bool result2 = queen.CanAttack(4, 1);

      //Assert
      Assert.AreEqual(true, result);
      Assert.AreEqual(true, result2);
    }

    [TestMethod]
    public void CanAttack_VerticalCheck_True()
    {
      //Arrange
      Queen queen = new Queen(4, 4);

      //Act
      bool result = queen.CanAttack(6, 4);
      bool result2 = queen.CanAttack(1, 4);

      //Assert
      Assert.AreEqual(true, result);
      Assert.AreEqual(true, result2);
    }

    [TestMethod]
    public void CanAttack_DiagonalDownLeftCheck_True()
    {
      //Arrange
      Queen queen = new Queen(4, 4);

      //Act
      bool result = queen.CanAttack(2, 2);
      bool result2 = queen.CanAttack(1, 1);

      //Assert
      Assert.AreEqual(true, result);
      Assert.AreEqual(true, result2);
    }

    [TestMethod]
    public void CanAttack_DiagonalUpLeftCheck_True()
    {
      //Arrange
      Queen queen = new Queen(4, 4);

      //Act
      bool result = queen.CanAttack(3, 5);
      bool result2 = queen.CanAttack(2, 6);

      //Assert
      Assert.AreEqual(true, result);
      Assert.AreEqual(true, result2);
    }

    [TestMethod]
    public void CanAttack_DiagonalUpRightCheck_True()
    {
      //Arrange
      Queen queen = new Queen(4, 4);

      //Act
      bool result = queen.CanAttack(5, 5);
      bool result2 = queen.CanAttack(7, 7);

      //Assert
      Assert.AreEqual(true, result);
      Assert.AreEqual(true, result2);
    }

    [TestMethod]
    public void CanAttack_DiagonalDownRightCheck_True()
    {
      //Arrange
      Queen queen = new Queen(4, 4);

      //Act
      bool result = queen.CanAttack(5, 3);
      bool result2 = queen.CanAttack(6, 2);
    
      //Assert
      Assert.AreEqual(true, result);
      Assert.AreEqual(true, result2);
    }

    public void Dispose()
    {

    }
  }
}
