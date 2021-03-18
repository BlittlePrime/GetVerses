using EFGetVerses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace GetVerses.Models
{
    public class Verse
    {
        public string id { get; set; }

        [DisplayName("Verse Text")]
        public string verseText { get; set; }

        [DisplayName("Verse Image")]
        public string verseImage { get; set; }
        public bool? isFavorite { get; set; }
    }

    public class VerseModel
    {
        [Required]
        [DisplayName("Start Date")]
        [DataType(DataType.Date)]
        public DateTime? startdate { get; set; }
        
        [Required]
        [DisplayName("Number of Verses")]
        [Range(1, int.MaxValue, ErrorMessage = "Please enter a value equal to or greater than {1}")]
        public int? PageSize { get; set; }

        public List<Verse> verses = new List<Verse>();
    }

    public class ApiVerseModel
    {
        public string VerseText { get; set; }

        public string ImageLink { get; set; }
        public string VerseDate { get; set; }

        public string VideoLink { get; set; }

        public string ReferenceLink { get; set; }

        public string VerseNumbers { get; set; }

        public string Chapter { get; set; }

        public string Book { get; set; }

        public string ReferenceText { get; set; }

        public string BibleReferenceLink { get; set; }

        public string FacebookShareUrl { get; set; }
        public string TwitterShareUrl { get; set; }
        public string PinterestShareUrl { get; set; }
        public bool IsValid { get; set; }
        public string Id { get; set; }
        public string Url { get; set; }
    }

    public class ApiVersesModel
    {
        public IEnumerable <ApiVerseModel> Verses { get; set; }
    }

    public class VerseBusinessLogic
    { 
        private const string API_KEY = "Ocp-Apim-Subscription-Key";
        private const string API_VALUE = "d10161af8cf44f0c8267d571c682fda4";
        private string baseUrl = "https://emfservicesstage-api.azure-api.net/bible/v1/getversesbydate?siteId=1";
        public async Task<VerseModel> fetchVerses(VerseModel verseCriteria)
        {
            VerseModel verses = new VerseModel();
            ApiVersesModel apiVerses = new ApiVersesModel();

            using (HttpClient httpClient = new HttpClient() )
            {               
                string parameter1 = "&startdate=" + System.Web.HttpUtility.UrlEncode(DateTime.Now.ToString("MM/dd/yyyy"));
                string parameter2 = "&PageSize=" + verseCriteria.PageSize;
                baseUrl += parameter1 + parameter2;

                httpClient.BaseAddress = new Uri(baseUrl);
                httpClient.DefaultRequestHeaders.Add(API_KEY, API_VALUE);

                using (HttpResponseMessage response = await httpClient.GetAsync(baseUrl))
                { 
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    apiVerses = JsonSerializer.Deserialize<ApiVersesModel>(apiResponse);
                }
            }

            foreach(ApiVerseModel apiVerse in apiVerses.Verses)
            {
                Verse verse = new Verse();
                verse.id = apiVerse.Id;
                verse.verseText = apiVerse.VerseText;
                verse.verseImage = apiVerse.ImageLink;
                verses.verses.Add(verse);
            }

            return verses;
        }

        internal void addFavorite(string id, string verse, string imageLink)
        {
            using (FavoriteVersesContext dbContext = new FavoriteVersesContext())
            {
                dbContext.Add( new Favorites { Id = id, Verse = verse, ImageLink = imageLink});
                dbContext.SaveChanges();
            }
        }

        internal VerseModel getFavorites()
        {
            VerseModel verses = new VerseModel();

            using (FavoriteVersesContext dbContext = new FavoriteVersesContext())
            {
                verses.verses = (from F in dbContext.Favorites
                                 select new Verse
                                 {
                                    id = F.Id,
                                    verseText = F.Verse,
                                    verseImage = F.ImageLink

                                 }).ToList();
            }

            return verses;
        }
    }
}
