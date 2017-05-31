using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Net.Http;
using Newtonsoft.Json;

namespace BLL
{
    public class AccessWebAPI
    {

        private string baseUri = "http://localhost:2998/api/ProductsEF/";


        /*-------------------METHODE WEATHER-----------------------------------*/
        public List<Weather> getWeathers()
        {
            //want to access this link
            string uri = baseUri;

            HttpClient client = new HttpClient();
            //async is for access the link and do something else
            //new thread
            Task<string> response = client.GetStringAsync(uri);
            return JsonConvert.DeserializeObject<List<Weather>>(response.Result);
            client.Dispose();
        }

        public bool PostWeathers(Weather w)
        {
            string uri = baseUri;
            using (HttpClient httpClient = new HttpClient())
            {
                string pro = JsonConvert.SerializeObject(w);
                StringContent frame = new StringContent(pro, Encoding.UTF8, "Application/json");
                Task<HttpResponseMessage> reponse = httpClient.PostAsync(uri, frame);
                return reponse.Result.IsSuccessStatusCode;
            }
        }

        public bool PutWeathers(Weather w)
        {
            string uri = baseUri;
            using (HttpClient httpClient = new HttpClient())
            {
                string pro = JsonConvert.SerializeObject(w);
                StringContent frame = new StringContent(pro, Encoding.UTF8, "Application/json");
                Task<HttpResponseMessage> reponse = httpClient.PutAsync(uri, frame);
                return reponse.Result.IsSuccessStatusCode;
            }
        }

        public bool DeleteWeathers(int i)
        {
            string uri = baseUri;
            using (HttpClient httpClient = new HttpClient())
            {
                Task<HttpResponseMessage> reponse = httpClient.DeleteAsync(uri);
                return reponse.Result.IsSuccessStatusCode;
            }  
    }

        /*-------------------METHODE COUNTRY-----------------------------------*/
        public List<Country> getCountries()
        {
            //want to access this link
            string uri = baseUri;

            HttpClient client = new HttpClient();
            //async is for access the link and do something else
            //new thread
            Task<string> response = client.GetStringAsync(uri);
            return JsonConvert.DeserializeObject<List<Country>>(response.Result);
            client.Dispose();
        }

        public bool PostCountries(Country c)
        {
            string uri = baseUri;
            using (HttpClient httpClient = new HttpClient())
            {
                string pro = JsonConvert.SerializeObject(c);
                StringContent frame = new StringContent(pro, Encoding.UTF8, "Application/json");
                Task<HttpResponseMessage> reponse = httpClient.PostAsync(uri, frame);
                return reponse.Result.IsSuccessStatusCode;
            }
        }

        public bool PutCountries(Country c)
        {
            string uri = baseUri;
            using (HttpClient httpClient = new HttpClient())
            {
                string pro = JsonConvert.SerializeObject(c);
                StringContent frame = new StringContent(pro, Encoding.UTF8, "Application/json");
                Task<HttpResponseMessage> reponse = httpClient.PutAsync(uri, frame);
                return reponse.Result.IsSuccessStatusCode;
            }
        }

        public bool DeleteCountries(int i)
        {
            string uri = baseUri;
            using (HttpClient httpClient = new HttpClient())
            {
                Task<HttpResponseMessage> reponse = httpClient.DeleteAsync(uri);
                return reponse.Result.IsSuccessStatusCode;
            }
        }

        /*-------------------METHODE CITY-----------------------------------*/
        public List<City> getCities()
        {
            //want to access this link
            string uri = baseUri;

            HttpClient client = new HttpClient();
            //async is for access the link and do something else
            //new thread
            Task<string> response = client.GetStringAsync(uri);
            return JsonConvert.DeserializeObject<List<City>>(response.Result);
            client.Dispose();
        }

        public bool PostCities(City c)
        {
            string uri = baseUri;
            using (HttpClient httpClient = new HttpClient())
            {
                string pro = JsonConvert.SerializeObject(c);
                StringContent frame = new StringContent(pro, Encoding.UTF8, "Application/json");
                Task<HttpResponseMessage> reponse = httpClient.PostAsync(uri, frame);
                return reponse.Result.IsSuccessStatusCode;
            }
        }

        public bool PutCities(City c)
        {
            string uri = baseUri;
            using (HttpClient httpClient = new HttpClient())
            {
                string pro = JsonConvert.SerializeObject(c);
                StringContent frame = new StringContent(pro, Encoding.UTF8, "Application/json");
                Task<HttpResponseMessage> reponse = httpClient.PutAsync(uri, frame);
                return reponse.Result.IsSuccessStatusCode;
            }
        }

        public bool DeleteCities(int i)
        {
            string uri = baseUri;
            using (HttpClient httpClient = new HttpClient())
            {
                Task<HttpResponseMessage> reponse = httpClient.DeleteAsync(uri);
                return reponse.Result.IsSuccessStatusCode;
            }
        }

        /*-------------------METHODE CANTON-----------------------------------*/
        public List<Canton> getCantons()
        {
            //want to access this link
            string uri = baseUri;

            HttpClient client = new HttpClient();
            //async is for access the link and do something else
            //new thread
            Task<string> response = client.GetStringAsync(uri);
            return JsonConvert.DeserializeObject<List<Canton>>(response.Result);
            client.Dispose();
        }

        public bool PostCantons(Canton c)
        {
            string uri = baseUri;
            using (HttpClient httpClient = new HttpClient())
            {
                string pro = JsonConvert.SerializeObject(c);
                StringContent frame = new StringContent(pro, Encoding.UTF8, "Application/json");
                Task<HttpResponseMessage> reponse = httpClient.PostAsync(uri, frame);
                return reponse.Result.IsSuccessStatusCode;
            }
        }

        public bool PutCantons(Canton c)
        {
            string uri = baseUri;
            using (HttpClient httpClient = new HttpClient())
            {
                string pro = JsonConvert.SerializeObject(c);
                StringContent frame = new StringContent(pro, Encoding.UTF8, "Application/json");
                Task<HttpResponseMessage> reponse = httpClient.PutAsync(uri, frame);
                return reponse.Result.IsSuccessStatusCode;
            }
        }

        public bool DeleteCantons(int i)
        {
            string uri = baseUri;
            using (HttpClient httpClient = new HttpClient())
            {
                Task<HttpResponseMessage> reponse = httpClient.DeleteAsync(uri);
                return reponse.Result.IsSuccessStatusCode;
            }
        }
    }
}
