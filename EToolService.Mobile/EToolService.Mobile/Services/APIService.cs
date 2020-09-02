using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using EToolService.Model.Models;
using EToolService.Model.Requests;
using Flurl.Http;
using Xamarin.Forms;

namespace EToolService.Mobile.Services
{
    public class APIService
    {
        public static string Username { get; set; }
        public static string Password { get; set; }
        public static Customer Client { get; set; }

        private readonly string _route;

#if DEBUG
        private string _apiUrl = "http://localhost:5000/api";
#endif

#if RELEASE
        private string _apiUrl = "http://localhost:5000/api";
#endif

        public APIService(string route)
        {
            _route = route;
        }
        public async Task<T> Get<T>(object search)
        {
            var url = $"{_apiUrl}/{_route}";

            try
            {
                if (search != null)
                {
                    url += "?";
                    url += search.ToString();
                }

                return await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();
            }
            catch (FlurlHttpException ex)
            {
                if (ex.Call.HttpStatus == System.Net.HttpStatusCode.Unauthorized)
                {
                    await Application.Current.MainPage.DisplayAlert("Greška", "Niste autentificirani", "OK");
                }
                throw;
            }
        }

        public async Task<T> GetWithUrl<T>(object search, string suffix)
        {
            var url = $"{_apiUrl}/{_route}/{suffix}";

            try
            {
                if (search != null)
                {
                    url += "?";
                    url += search.ToString();
                }

                return await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();
            }
            catch (FlurlHttpException ex)
            {
                if (ex.Call.HttpStatus == System.Net.HttpStatusCode.Unauthorized)
                {
                    await Application.Current.MainPage.DisplayAlert("Greška", "Niste autentificirani", "OK");
                }
                throw;
            }
        }
        public async Task<T> GetById<T>(object id)
        {
            var url = $"{_apiUrl}/{_route}/{id}";

            return await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();
        }

        internal async Task<byte[]> GetFile(string file)
        {
            var url = $"{_apiUrl}/{_route}/{file}";

            try
            {
                return await url.WithBasicAuth(Username, Password).GetBytesAsync();
            }
            catch (FlurlHttpException ex)
            {
                if (ex.Call.HttpStatus == System.Net.HttpStatusCode.Unauthorized)
                {
                    await Application.Current.MainPage.DisplayAlert("Greška", "Niste autentificirani", "OK");
                }
                throw;
            }
        }

        public async Task<HttpResponseMessage> Delete(object id)
        {
            var url = $"{_apiUrl}/{_route}/{id}";

            return await url.WithBasicAuth(Username, Password).DeleteAsync();
        }

        public async Task<T> Insert<T>(object request)
        {
            var url = $"{_apiUrl}/{_route}";

            try
            {
                var response = await url.WithBasicAuth(Username, Password)
                   .PostJsonAsync(request)
                   .ReceiveJson<T>();
                return response;
            }
            catch (FlurlHttpException ex)
            {
                await Application.Current.MainPage.DisplayAlert("Greška", ex.Message, "OK");

                return default(T);
            }

        }
        public async Task<T> Update<T>(int id, object request)
        {
            try
            {
                var url = $"{_apiUrl}/{_route}/{id}";

                return await url.WithBasicAuth(Username, Password).PutJsonAsync(request).ReceiveJson<T>();
            }
            catch (FlurlHttpException ex)
            {
                var errors = await ex.GetResponseJsonAsync<Dictionary<string, string[]>>();

                var stringBuilder = new StringBuilder();
                foreach (var error in errors)
                {
                    stringBuilder.AppendLine($"{error.Key}, ${string.Join(",", error.Value)}");
                }

                await Application.Current.MainPage.DisplayAlert("Greška", stringBuilder.ToString(), "OK");

                return default(T);
            }

        }
        public async Task<Account> Authenticate(AuthenticateRequest request)
        {
            var url = $"{_apiUrl}/Account";
            Account account = await url.WithBasicAuth(Username, Password)
                .PostJsonAsync(request).ReceiveJson<Account>();

            return account;
        }

        public async Task<T> Patch<T>(object id, object request)
        {
            try
            {
                var url = $"{_apiUrl}/{_route}/{id}";
                var result = await url.WithBasicAuth(Username, Password).PatchJsonAsync(request).ReceiveJson<T>();

                return result;
            }
            catch (FlurlHttpException ex)
            {
                var errors = await ex.GetResponseJsonAsync<Dictionary<string, string[]>>();

                var stringBuilder = new StringBuilder();
                foreach (var error in errors)
                {
                    stringBuilder.AppendLine($"{error.Key}, {string.Join(",", error.Value)}");
                }

                await Application.Current.MainPage.DisplayAlert("Greška", stringBuilder.ToString(), "OK");

                return default(T);
            }
        }

    }
}
