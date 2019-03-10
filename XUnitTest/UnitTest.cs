using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using CAQM;
using CAQM.Services;
using Newtonsoft.Json;
using Xunit;

namespace XUnitTest
{

    public class UnitTest
    {
      //  DataContext _context = new DataContext();
      //  UserService service = new UserService(new DataContext());
        HttpClient client = new HttpClient();
        [Fact]
        public async void GetAll()
        {
            HttpResponseMessage response = await client.GetAsync("http://localhost:56339/users/getAll");
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
        [Fact]
        public async void GetById()
        {
            HttpClient client = new HttpClient();
            int id = 1;
            var url = "http://localhost:56339/users/GetById?id=" + id;
            HttpResponseMessage response = await client.GetAsync(url);
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
        [Fact]
        public async void Create()
        {
            UserDto objUser = new UserDto()
            {
                FirstName = "test1",
                LastName = "user",
                Username = "testNew",
                Password = "123",
                UserRole = "Role 1"
            };
            string json = JsonConvert.SerializeObject(objUser, Formatting.Indented);
            var buffer = System.Text.Encoding.UTF8.GetBytes(json);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var url = "http://localhost:56339//users/Register";
            HttpResponseMessage response = await client.PostAsync(url, byteContent);
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async void Login()
        {
            userLogin objUserLogin = new userLogin();
            objUserLogin.username = "sa";
            objUserLogin.password = "123";
            string json = JsonConvert.SerializeObject(objUserLogin, Formatting.Indented);
            var buffer = System.Text.Encoding.UTF8.GetBytes(json);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var url = "http://localhost:56339//users/authenticate";
            HttpResponseMessage response = await client.PostAsync(url, byteContent);
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);

        }

        [Fact]
        public void GerAllService()
        {
           // var result = service.GetAll();
            //Assert.NotEmpty(result);
        }
        [Fact]
        public void GetByIdService()
        {
         //   var result = service.GetById(1);
          //  Assert.NotNull(result);
        }
        [Fact]
        public void LoginService()
        {
            //var result = service.Authenticate("sa", "123");
           // Assert.NotNull(result);
        }

    }
    public class userLogin
    {
        public string username;
        public string password;
    }
    public class UserDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        // Add New Property for User Roles
        public string UserRole { get; set; }
    }

}
