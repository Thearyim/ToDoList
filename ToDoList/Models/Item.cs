using System.Collections.Generic;

namespace ToDoList.Models
{
  public class Item
  {
    private string _description;
    private static List<Item> _instances = new List<Item> {};

    public Item (string description)
    {
      _description = description;
      _instances.Add(this);
    }

    public string GetDescription()
    {
      return _description;
    }

    public static List<Item> GetAll()
    {
      return _instances;
    }

    public void SetDescription(string newDescription)
    {
      _description = newDescription;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}