// Copy into a separate console application's Program.cs.
using JsonScraper.InstagramApi;
using var client=new Instagram(Environment.GetEnvironmentVariable("JSONSCRAPER_INSTAGRAM_LICENSE_KEY")!);
using var response=await client.JsonAsync("/v1/user/medias/chunk",new Dictionary<string,object?>{["user_id"]="5821462185", ["end_cursor"]="", ["cache_timeout"]=60});
Console.WriteLine(response.RootElement);
