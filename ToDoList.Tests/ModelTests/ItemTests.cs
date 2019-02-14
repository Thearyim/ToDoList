using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToDoList.Models;

namespace ToDoList.Tests
{
  [TestClass]
  public class ItemTest
  {

    [TestMethod]
    public void ItemConstructor_CreatesInstanceOfItem_Item()
    {
      Item newItem = new Item("test");
      Assert.AreEqual(typeof(Item), newItem.GetType());
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      //Arrange
      string description = "Walk the dog.";

      //Act
      Item newItem = new Item(description);
      string result = newItem.GetDescription();

      //Assert
      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void SetDescription_UpdatesDescription_String()
    {
      //Arrange
      string updatedDescription = "Do the dishes";

      //Act
      Item newItem = new Item(updatedDescription);
      newItem.SetDescription(updatedDescription);
      string result = newItem.GetDescription();

      //Assert
      Assert.AreEqual(updatedDescription, result);
    }

  }
}
