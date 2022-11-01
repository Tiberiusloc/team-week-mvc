using System.Collections.Generic;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ForageMvc.Models
{
  public class Item
  {
    public int ItemId { get; set; }
    public string Category { get; set; }
    public string Type { get; set; }
    public string Name { get; set; }
    public string Latin { get; set; }
    public string Description { get; set; }
    public string Habitat { get; set; }
    public string Smell { get; set; }
    public string Taste { get; set; }
    public bool Edible { get; set; }
    public string EdibleDesc { get; set; }
    public string Symbolism { get; set; }
    public string History { get; set; }
    public int Score { get; set; }
    public string Hint { get; set; }
    public string Difficulty { get; set; }
    public bool Found { get; set; }
    public string Picture { get; set; }

    public static List<Item> GetItems()
    {
      var apiCallTask = ApiHelper.GetAll();
      var result = apiCallTask.Result;

      JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
      List<Item> itemList = JsonConvert.DeserializeObject<List<Item>>(jsonResponse.ToString());

      return itemList;
    }

     public static Item GetItemDetails(int id)
    {
      var apiCallTask = ApiHelper.Get(id);
      var result = apiCallTask.Result;

      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      Item item = JsonConvert.DeserializeObject<Item>(jsonResponse.ToString());

      return item;
    }
    
    public static void PutItem(Item item)
    {
      string jsonMessage = JsonConvert.SerializeObject(item);
      var apiCallTask = ApiHelper.Put(item.ItemId, jsonMessage);
    }
  }
}