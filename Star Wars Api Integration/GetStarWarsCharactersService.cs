using Newtonsoft.Json;
using Star_Wars_Api_Integration.Entities;
using System.Net;

namespace Star_Wars_Api_Integration
{
    public class GetStarWarsCharactersService
    {
        private readonly string _url;

        /// <summary>
        ///
        /// </summary>
        /// <param name="url"></param>
        public GetStarWarsCharactersService(string url)
        {
            _url = url;
        }

        public StarWarsCharactersResponse GetStarWarsCharacters()
        {
            var jsonResponse = GetJsonResponse();

            var response = JsonConvert.DeserializeObject<StarWarsCharactersResponse>(jsonResponse);

            return response;
        }

        private string GetJsonResponse()
        {
            using (var client = new WebClient())
            {
                var json = client.DownloadString(_url);

                return json;
            }
        }
    }
}
