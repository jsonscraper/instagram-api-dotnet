using JsonScraper.InstagramApi;

using var client = new Instagram(Environment.GetEnvironmentVariable("JSONSCRAPER_INSTAGRAM_LICENSE_KEY")!);
using var response = await client.JsonAsync("/v1/user/by/username", new Dictionary<string, object?> { ["username"]="apple", ["cache_timeout"]=60 });
if (response.RootElement.GetProperty("status").GetString() != "ok") throw new Exception("API application error");
Console.WriteLine(response.RootElement.GetProperty("ig"));
