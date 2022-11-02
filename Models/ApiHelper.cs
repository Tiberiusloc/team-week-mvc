using System.Threading.Tasks;
using RestSharp;

namespace ForageMvc.Models
{
  class ApiHelper
  {
    public static async Task<string> GetAll()
    {
      RestClient client = new RestClient("http://localhost:5003/api");
      RestRequest request = new RestRequest($"items", Method.GET);
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }

    public static async Task<string> Get(int id)
    {
      RestClient client = new RestClient("http://localhost:5003/api");
      RestRequest request = new RestRequest($"items/{id}", Method.GET);
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }

    public static async Task<string> GetCat(string cat)
    {
      RestClient client = new RestClient("http://localhost:5003/api");
      RestRequest request = new RestRequest($"items?category={cat}", Method.GET);
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }

    // public static async Task<string> GetCatDiff(string cat, string diff)
    // {
    //   RestClient client = new RestClient("http://localhost:5003/api");
    //   RestRequest request = new RestRequest($"items?category={cat}&difficulty={diff}", Method.GET);
    //   var response = await client.ExecuteTaskAsync(request);
    //   return response.Content;
    // }

    public static async Task Put(int id, string item)
		{
			RestClient client = new RestClient("http://localhost:5003/api");
			RestRequest request = new RestRequest($"items/{id}", Method.PUT);
			request.AddHeader("Content-Type", "application/json");
			request.AddJsonBody(item);
			var response = await client.ExecuteTaskAsync(request);
		}
  }
}