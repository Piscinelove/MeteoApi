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

        private string baseUri = "http://localhost:12410/api/";


        /*-------------------METHODE WEATHER-----------------------------------*/
        public List<Weather> GetWeathers()
        {
            //want to access this link
            string uri = baseUri + "/weathers";

            HttpClient client = new HttpClient();
            //async is for access the link and do something else
            //new thread
            Task<string> response = client.GetStringAsync(uri);
            return JsonConvert.DeserializeObject<List<Weather>>(response.Result);
            client.Dispose();
        }

        public Weather GetWeather(int id)
        {
            //want to access this link
            string uri = baseUri + "/weathers/"+id;

            HttpClient client = new HttpClient();
            //async is for access the link and do something else
            //new thread
            Task<string> response = client.GetStringAsync(uri);
            return JsonConvert.DeserializeObject<Weather>(response.Result);
            client.Dispose();
        }

        public bool PostWeathers(Weather w)
        {
            string uri = baseUri + "/weathers";
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
            string uri = baseUri + "/weathers/"+w.Id;
            using (HttpClient httpClient = new HttpClient())
            {
                string pro = JsonConvert.SerializeObject(w);
                StringContent frame = new StringContent(pro, Encoding.UTF8, "Application/json");
                Task<HttpResponseMessage> reponse = httpClient.PutAsync(uri, frame);
                return reponse.Result.IsSuccessStatusCode;
            }
        }

        public bool DeleteWeathers(int id)
        {
            string uri = baseUri + "/weathers"+id;
            using (HttpClient httpClient = new HttpClient())
            {
                Task<HttpResponseMessage> reponse = httpClient.DeleteAsync(uri);
                return reponse.Result.IsSuccessStatusCode;
            }  
    }

        /*-------------------METHODE COUNTRY-----------------------------------*/
        public List<Country> GetCountries()
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
        public List<City> GetCities()
        {
            //want to access this link
            string uri = baseUri + "/cities";

            HttpClient client = new HttpClient();
            //async is for access the link and do something else
            //new thread
            Task<string> response = client.GetStringAsync(uri);
            return JsonConvert.DeserializeObject<List<City>>(response.Result);
            client.Dispose();
        }

        public City GetCity(int id)
        {
            //want to access this link
            string uri = baseUri + "/cities/" + id;

            HttpClient client = new HttpClient();
            //async is for access the link and do something else
            //new thread
            Task<string> response = client.GetStringAsync(uri);
            return JsonConvert.DeserializeObject<City>(response.Result);
            client.Dispose();
        }

        public bool PostCities(City c)
        {
            string uri = baseUri + "/cities";
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
            string uri = baseUri + "/cities/" + c.Id;
            using (HttpClient httpClient = new HttpClient())
            {
                string pro = JsonConvert.SerializeObject(c);
                StringContent frame = new StringContent(pro, Encoding.UTF8, "Application/json");
                Task<HttpResponseMessage> reponse = httpClient.PutAsync(uri, frame);
                return reponse.Result.IsSuccessStatusCode;
            }
        }

        public bool DeleteCities(int id)
        {
            string uri = baseUri + "/cities/"+id;
            using (HttpClient httpClient = new HttpClient())
            {
                Task<HttpResponseMessage> reponse = httpClient.DeleteAsync(uri);
                return reponse.Result.IsSuccessStatusCode;
            }
        }

        /*-------------------METHODE CANTON-----------------------------------*/
        public List<Canton> GetCantons()
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

        /*-------------------METHODE CITY-----------------------------------*/
        public List<State> GetStates()
        {
            //want to access this link
            string uri = baseUri + "/states";

            HttpClient client = new HttpClient();
            //async is for access the link and do something else
            //new thread
            Task<string> response = client.GetStringAsync(uri);
            return JsonConvert.DeserializeObject<List<State>>(response.Result);
            client.Dispose();
        }

        public State GetState(int id)
        {
            //want to access this link
            string uri = baseUri + "/states/" + id;

            HttpClient client = new HttpClient();
            //async is for access the link and do something else
            //new thread
            Task<string> response = client.GetStringAsync(uri);
            return JsonConvert.DeserializeObject<State>(response.Result);
            client.Dispose();
        }

        public bool PostStates(State c)
        {
            string uri = baseUri + "/states";
            using (HttpClient httpClient = new HttpClient())
            {
                string pro = JsonConvert.SerializeObject(c);
                StringContent frame = new StringContent(pro, Encoding.UTF8, "Application/json");
                Task<HttpResponseMessage> reponse = httpClient.PostAsync(uri, frame);
                return reponse.Result.IsSuccessStatusCode;
            }
        }

        public bool PutStates(State c)
        {
            string uri = baseUri + "/states/" + c.Id;
            using (HttpClient httpClient = new HttpClient())
            {
                string pro = JsonConvert.SerializeObject(c);
                StringContent frame = new StringContent(pro, Encoding.UTF8, "Application/json");
                Task<HttpResponseMessage> reponse = httpClient.PutAsync(uri, frame);
                return reponse.Result.IsSuccessStatusCode;
            }
        }

        public bool DeleteStates(int id)
        {
            string uri = baseUri + "/states/"+id;
            using (HttpClient httpClient = new HttpClient())
            {
                Task<HttpResponseMessage> reponse = httpClient.DeleteAsync(uri);
                return reponse.Result.IsSuccessStatusCode;
            }
        }
    }
}
