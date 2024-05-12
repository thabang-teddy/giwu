using DataAccess.Data;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;

public static class SeedData
{

    public static void Seed(ApplicationDbContext context)
    {
        if (!context.BibleVersions.Any())
        {
            // Read JSON file
            // Load JSON data from file
            var biblePath = Path.Combine(Directory.GetCurrentDirectory(), "Data", "SeedData", "Json", "bible_version_key.json");

            if (biblePath != null)
            {
                var bibleJsonText = File.ReadAllText(biblePath);
                var bibleJsonObject = JsonConvert.DeserializeObject<BibleRootObject>(bibleJsonText);

                if (bibleJsonObject != null)
                {
                    string biblebooksData = "";
                    var biblebooksPath = Path.Combine(Directory.GetCurrentDirectory(), "Data", "SeedData", "Json", "key_english.json");
                    if(biblebooksPath != null)
                    {
                        var biblebooksJsonText = File.ReadAllText(biblebooksPath);
                        var biblebooksJsonObject = JsonConvert.DeserializeObject<BibleVersionRootObject>(biblebooksJsonText);

                        if (biblebooksJsonObject != null)
                        {
                            biblebooksData = biblebooksJsonObject.resultset.keys.ToString() ?? "";
                        }
                    }

                    // Parse JSON and add to database
                    var bibleVersions = bibleJsonObject.resultset.row.Select(row =>
                        new BibleVersion
                        {
                            Id = Guid.NewGuid(),
                            Table = row.field[1].ToString(),
                            Abbreviation = row.field[2].ToString(),
                            Language = row.field[3].ToString(),
                            Version = row.field[4].ToString(),
                            InfoText = "",
                            InfoURL = row.field[5]?.ToString(),
                            Publisher = "",
                            Copyright = row.field[7]?.ToString(),
                            CopyrightInfo = "",
                            BookList = biblebooksData
                        }).ToList();

                    context.BibleVersions.AddRange(bibleVersions);
                }
            }
        }
        if (!context.ASV.Any())
        {
            // Read JSON file

            // Load JSON data from file
            var asvPath = Path.Combine(Directory.GetCurrentDirectory(), "Data", "SeedData", "Json", "t_asv.json");

            if (asvPath != null)
            {
                var asvJsonText = File.ReadAllText(asvPath);
                var asvJsonObject = JsonConvert.DeserializeObject<BibleRootObject>(asvJsonText);

                if (asvJsonObject != null)
                {
                    // Parse JSON and add to database
                    var asvBibleVerses = asvJsonObject.resultset.row.Select(asvVow =>
                        new ASVBibleVerse
                        {
                            Book = Convert.ToInt32(asvVow.field[1]),
                            Chapter = Convert.ToInt32(asvVow.field[2]),
                            Verse = Convert.ToInt32(asvVow.field[3]),
                            Text = asvVow.field[4].ToString() ?? ""
                        }).ToList();

                    context.ASV.AddRange(asvBibleVerses);
                }
            }
        }
        if (!context.BBE.Any())
        {
            // Read JSON file

            // Load JSON data from file
            var bbePath = Path.Combine(Directory.GetCurrentDirectory(), "Data", "SeedData", "Json", "t_bbe.json");

            if (bbePath != null)
            {
                var bbeJsonText = File.ReadAllText(bbePath);
                var bbeJsonObject = JsonConvert.DeserializeObject<BibleRootObject>(bbeJsonText);

                if (bbeJsonObject != null)
                {
                    // Parse JSON and add to database
                    var bbeBibleVerses = bbeJsonObject.resultset.row.Select(bbeVow =>
                        new BBEBibleVerse
                        {
                            Book = Convert.ToInt32(bbeVow.field[1]),
                            Chapter = Convert.ToInt32(bbeVow.field[2]),
                            Verse = Convert.ToInt32(bbeVow.field[3]),
                            Text = bbeVow.field[4].ToString() ?? ""
                        }).ToList();

                    context.BBE.AddRange(bbeBibleVerses);
                }
            }
        }
        if (!context.KJV.Any())
        {
            // Read JSON file

            // Load JSON data from file
            var kjvPath = Path.Combine(Directory.GetCurrentDirectory(), "Data", "SeedData", "Json", "t_kjv.json");

            if (kjvPath != null)
            {
                var kjvJsonText = File.ReadAllText(kjvPath);
                var kjvJsonObject = JsonConvert.DeserializeObject<BibleRootObject>(kjvJsonText);

                if (kjvJsonObject != null)
                {
                    // Parse JSON and add to database
                    var kjvBibleVerses = kjvJsonObject.resultset.row.Select(kjvVow =>
                        new KJVBibleVerse
                        {
                            Book = Convert.ToInt32(kjvVow.field[1]),
                            Chapter = Convert.ToInt32(kjvVow.field[2]),
                            Verse = Convert.ToInt32(kjvVow.field[3]),
                            Text = kjvVow.field[4].ToString() ?? ""
                        }).ToList();

                    context.KJV.AddRange(kjvBibleVerses);
                }
            }
        }
        if (!context.WEB.Any())
        {
            // Read JSON file

            // Load JSON data from file
            var webPath = Path.Combine(Directory.GetCurrentDirectory(), "Data", "SeedData", "Json", "t_web.json");

            if (webPath != null)
            {
                var webJsonText = File.ReadAllText(webPath);
                var webJsonObject = JsonConvert.DeserializeObject<BibleRootObject>(webJsonText);

                if (webJsonObject != null)
                {
                    // Parse JSON and add to database
                    var webBibleVerses = webJsonObject.resultset.row.Select(webVow =>
                        new WEBBibleVerse
                        {
                            Book = Convert.ToInt32(webVow.field[1]),
                            Chapter = Convert.ToInt32(webVow.field[2]),
                            Verse = Convert.ToInt32(webVow.field[3]),
                            Text = webVow.field[4].ToString() ?? ""
                        }).ToList();

                    context.WEB.AddRange(webBibleVerses);
                }
            }
        }
        if (!context.YLT.Any())
        {
            // Read JSON file

            // Load JSON data from file
            var yltPath = Path.Combine(Directory.GetCurrentDirectory(), "Data", "SeedData", "Json", "t_ylt.json");

            if (yltPath != null)
            {
                var yltJsonText = File.ReadAllText(yltPath);
                var yltJsonObject = JsonConvert.DeserializeObject<BibleRootObject>(yltJsonText);

                if (yltJsonObject != null)
                {
                    // Parse JSON and add to database
                    var yltBibleVerses = yltJsonObject.resultset.row.Select(yltVow =>
                        new YLTBibleVerse
                        {
                            Book = Convert.ToInt32(yltVow.field[1]),
                            Chapter = Convert.ToInt32(yltVow.field[2]),
                            Verse = Convert.ToInt32(yltVow.field[3]),
                            Text = yltVow.field[4].ToString() ?? ""
                        }).ToList();

                    context.YLT.AddRange(yltBibleVerses);
                }
            }
        }
        context.SaveChanges();
    }
}