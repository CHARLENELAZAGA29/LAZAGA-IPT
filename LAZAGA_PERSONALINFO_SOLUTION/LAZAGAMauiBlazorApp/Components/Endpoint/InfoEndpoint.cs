using LAZAGAMauiBlazorApp.Components.Models;
using System.Net.Http.Json;

namespace LAZAGAMauiBlazorApp.Components.Endpoint
{
    public class InfoEndpoint
    {
        private readonly HttpClient _http;

        public InfoEndpoint(HttpClient http) => _http = http;

        public async Task<MyInfo.Fullname?> GetFirstAsync() =>
            await _http.GetFromJsonAsync<MyInfo.Fullname>("api/get");

        public async Task<MyInfo.MiddleName?> GetMiddleAsync() =>
            await _http.GetFromJsonAsync<MyInfo.MiddleName>("api/get/MD");

        public async Task<MyInfo.LastName?> GetLastAsync() =>
            await _http.GetFromJsonAsync<MyInfo.LastName>("api/get/LN");

        public async Task<MyInfo.Mycourse?> GetCourseAsync() =>
            await _http.GetFromJsonAsync<MyInfo.Mycourse>("api/get/Course");

        public async Task<MyInfo.MyYear?> GetYearAsync() =>
            await _http.GetFromJsonAsync<MyInfo.MyYear>("api/get/Year");

        public async Task<MyInfo.MyBirthday?> GetBirthdayAsync() =>
            await _http.GetFromJsonAsync<MyInfo.MyBirthday>("api/get/MyBirthday");

        public async Task<MyInfo.Myage?> GetAgeAsync() =>
            await _http.GetFromJsonAsync<MyInfo.Myage>("api/get/MyAge");

        public async Task<MyInfo.MyContacts?> GetContactsAsync() =>
            await _http.GetFromJsonAsync<MyInfo.MyContacts>("api/get/MyContacts");
    }
}