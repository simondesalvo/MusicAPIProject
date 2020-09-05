using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Helpers;

namespace MusicAPIProject.Models
{
    public class MusicDAL
    {
        private readonly string _apikey;

        public MusicDAL(string apiKey)
        {
            _apikey = apiKey;
        }

        public HttpClient GetClient()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://deezerdevs-deezer.p.rapidapi.com");
            client.DefaultRequestHeaders.Add("x-rapidapi-key", _apikey);
            return client;
        }

        public async Task<MusicObject> GetInfo(string userInput)
        { 
            HttpClient client = GetClient();
            var response = await client.GetAsync($"/search?q={userInput}");
            string jasonData = await response.Content.ReadAsStringAsync(); 
            MusicObject artist = JsonConvert.DeserializeObject<MusicObject>(jasonData);
            return artist;
        }

        public async Task<Album> GetAlbum(int id)
        {
            HttpClient client = GetClient();
            var response = await client.GetAsync($"/album/{id}");
            string jasonData = await response.Content.ReadAsStringAsync();
            Album music = JsonConvert.DeserializeObject<Album>(jasonData);
            return music;
        }
        public async Task<Artist> GetArtist(int id)
        {
            HttpClient client = GetClient();
            var response = await client.GetAsync($"/artist/{id}");
            string jasonData = await response.Content.ReadAsStringAsync();
            Artist artist = JsonConvert.DeserializeObject<Artist>(jasonData);
            return artist;
        }
    }
}
