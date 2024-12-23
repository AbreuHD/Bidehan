// See https://aka.ms/new-console-template for more information
using Application.Utils;

var t = new Search();

Console.WriteLine(await t.AutomaticSearchAsync("https://www.tiktok.com/@johancel20_/video/7424271383699426590?is_from_webapp=1"));
