using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WebApi.Dtos;
using AutoMapper;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.Extensions.Options;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using System.Linq;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using CAQM;
using CAQM.Entities;
using CAQM.IServices;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : Controller
    {
        private IUserService _userService;
        private IUserDocumentService _userDocumentService;
        private IFileDataService _fileDataService;
        private IMapper _mapper;
        private readonly AppSettings _appSettings;
        private IHostingEnvironment _hostingEnvironment;

        public UsersController(
            IUserService userService,
            IUserDocumentService userDocumentService,
            IFileDataService fileDataService,
            IMapper mapper,
            IOptions<AppSettings> appSettings,
            IHostingEnvironment hostingEnvironment)
        {
            _userDocumentService = userDocumentService;
            _userService = userService;
            _mapper = mapper;
            _appSettings = appSettings.Value;
            _hostingEnvironment = hostingEnvironment;
            _fileDataService = fileDataService;
        }

        [AllowAnonymous]
        [HttpPost("upload")]
        public IActionResult UploadFile([FromBody]List<FileData> listFileUpload)
        {
            try
            {
                if (listFileUpload.Count > 0)
                {
                    foreach (FileData obj in listFileUpload)
                    {
                        _fileDataService.AddFile(obj);
                    }
                }
                return Ok();
            }
            catch (AppException ex)
            {
                // return error message if there was an exception
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("remove")]
        public IActionResult RemoveFile()
        {
            var token = Convert.ToString(Request.Headers["Authorization"]).Replace("Bearer ", "");
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            var tokenS = tokenHandler.ReadJwtToken(token);
            var userId = tokenS.Claims.First(claim => claim.Type == "unique_name").Value;

            string folderName = "Images/" + userId;
            string webRootPath = Directory.GetCurrentDirectory();
            string path = Path.Combine(webRootPath, folderName);
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            string fileName = Request.Form["fileNames"];

            if (fileName != null && fileName.Trim() != "")
            {
                string fullPath = Path.Combine(path, fileName);
                var doc = _userDocumentService.GetById(Convert.ToInt32(userId), fileName);
                if (doc != null)
                {
                    FileInfo fileInfo = new FileInfo(fullPath);
                    if (fileInfo.Exists)//check file exsit or not
                    {
                        fileInfo.Delete();

                        _userDocumentService.Delete(doc.Id);
                    }
                }

            }

            return Ok();
        }

        [AllowAnonymous]
        [HttpPost("authenticate")]
        public IActionResult Authenticate([FromBody]UserDto userDto)
        {
            var user = _userService.Authenticate(userDto.Username, userDto.Password);

            if (user == null)
                return BadRequest("Username or password is incorrect");

            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, user.UserId.ToString())
                }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            var tokenString = tokenHandler.WriteToken(token);

            // return basic user info (without password) and token to store client side
            return Ok(new
            {
                Id = user.UserId,
                Username = user.Username,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Token = tokenString
            });
        }

        [AllowAnonymous]
        [HttpPost("register")]
        public IActionResult Register([FromBody]UserDto userDto)
        {
            // map dto to entity
            var user = _mapper.Map<User>(userDto);

            try
            {
                // save 
                _userService.Create(user, userDto.Password);
                return Ok();
            }
            catch (AppException ex)
            {
                // return error message if there was an exception
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var users = _userService.GetAll();
            var userDtos = _mapper.Map<IList<UserDto>>(users);
            return Ok(userDtos);
        }

        [HttpGet("GetById/{id}")]
        public IActionResult GetById(int id)
        {
            var user = _userService.GetById(id);
            var userDto = _mapper.Map<UserDto>(user);
            return Ok(userDto);
        }

        [HttpGet("GetUserData/{id}")]
        public IActionResult GetUserData(int id)
        {
            try
            {
                var user = _userService.GetUserDataById(id);
                // var userDto = _mapper.Map<UserDto>(user);
                return Ok(user);
            }
            catch (Exception ex)
            {
                return BadRequest(new { Message = ex.Message, InnerException = ex.InnerException });
            }
        }

        [HttpPut("Update/{id}")]
        public IActionResult Update(int id, [FromBody]UserDto userDto)
        {
            // map dto to entity and set id
            var user = _mapper.Map<User>(userDto);
            user.UserId = id;

            try
            {
                // save 
                _userService.Update(user, userDto.Password);
                return Ok();
            }
            catch (AppException ex)
            {
                // return error message if there was an exception
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("Delete/{id}")]
        public IActionResult Delete(int id)
        {
            _userService.Delete(id);
            return Ok();
        }

        

    }


}
