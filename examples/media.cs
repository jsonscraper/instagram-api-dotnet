// Copy into a separate console application's Program.cs.
using JsonScraper.InstagramApi;
using var client=new Instagram(Environment.GetEnvironmentVariable("JSONSCRAPER_INSTAGRAM_LICENSE_KEY")!);
using var response=await client.JsonAsync("/v1/media/by/code",new Dictionary<string,object?>{["code"]="DT23hQ-EgkI", ["cache_timeout"]=60});
Console.WriteLine(response.RootElement);
