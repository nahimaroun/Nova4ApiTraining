using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NovaApiTraining.Data;
using NovaApiTraining.DTOs;
using NovaApiTraining.Helpers;
using NovaApiTraining.Models;
using System.Diagnostics;


namespace NovaApiTraining.Controllers
{

    public class HomeController : Controller
    {
        private readonly ILogger<DataFetcher> _logger;

        private readonly IConfiguration _configuration;

        private readonly IMapper _mapper;

        private readonly AppDBcontext _dbContext;

        private readonly IConfiguration _config;

        private static readonly Dictionary<int, string> mockData = new Dictionary<int, string>();
        public HomeController(IConfiguration config, AppDBcontext dbContext, IConfiguration configuration, ILogger<DataFetcher> logger, IMapper mapper)
        {
            _configuration = configuration;
            _logger = logger;
            _dbContext = dbContext;
            _mapper = mapper;
            _config = config;

        }
        public IActionResult Index()
        {
            return View();
        }

        [Authorize]
        public IActionResult BTCtoUSD()
        {
            ViewBag.Infos = _dbContext.Infos.ToList();
            return View();
        }

        [HttpGet]
        [Route("Dictionary")]
        public IActionResult GetUsers()
        {
            try
            {
                _logger.LogInformation(_configuration.GetValue<string>("jsonResponse"));
                return Ok(mockData);
            }
            catch (Exception ex)
            {
                return NotFound(ex);
            }
        }

        [HttpGet("Dictionary/{userId}")]
        public IActionResult GetUserById(int userId)
        {
            try
            {
                var user = mockData[userId];
                return Ok(user);
            }
            catch (KeyNotFoundException)
            {
                return NotFound($"User with ID {userId} not found.");
            }
        }

        [HttpPost]
        [Route("Dictionary")]
        public IActionResult AddUser([FromBody] User user)
        {
            try
            {

                mockData.Add(user.id, user.name);

                return Ok(mockData);

            }
            catch (Exception ex)
            {

                return NotFound(ex);
            }
        }

        [HttpPut]
        [Route("Dictionary")]
        public IActionResult UpdateUser([FromBody] User user)
        {
            try
            {
                mockData[user.id] = user.name;

                return Ok(mockData);
            }
            catch (Exception ex)
            {

                return NotFound(ex);
            }

        }

        [HttpDelete]
        [Route("Dictionary")]
        public IActionResult deleteUser([FromBody] User user)
        {
            try
            {
                mockData.Remove(user.id);

                return Ok(mockData);
            }
            catch (Exception ex)
            {

                return NotFound(ex);
            }
        }

        [HttpGet("GetBitStamp")]
        public async Task<IActionResult> GetBitStamp()
        {
            var BtcApiURL = _configuration["BitStampUrl"];

            using (var httpClient = new HttpClient())
            {
                try
                {
                    DataFetcher df = new DataFetcher(httpClient, _logger);
                    // BitStamp
                    var result = await df.FetchData<BitStamp>(BtcApiURL);

                    if (result == null)
                    {
                        return StatusCode(500, "Failed to retrieve data from one or both sources");
                    }

                    result.Converted = DateTimeHelper.ConvertEpochToDmyDateTime(result.timestamp);

                    Crypto crypto = _mapper.Map<Crypto>(result);

                    _dbContext.Infos.Add(crypto);
                    await _dbContext.SaveChangesAsync();

                    return Ok(crypto);
                }

                catch (Exception ex)
                {
                    _logger.LogError($"An error occurred: {ex.Message}");
                    return StatusCode(500, "An error occurred while retrieving the data");
                }
            }
        }

        [HttpGet("GetBitFinex")]
        public async Task<IActionResult> GetBitFinex()
        {
            var BtcApiURL = _configuration["BitFineXUrl"];

            using (var httpClient = new HttpClient())
            {
                try
                {
                    DataFetcher df = new DataFetcher(httpClient, _logger);
                    // Bitfinex
                    var result = await df.FetchData<Bitfinex>(BtcApiURL);

                    if (result == null)
                    {
                        return StatusCode(500, "Failed to retrieve data from one or both sources");
                    }

                    result.Converted = DateTimeHelper.ConvertEpochToDmyDateTime(result.timestamp);

                    Crypto crypto = _mapper.Map<Crypto>(result);

                    _dbContext.Infos.Add(crypto);
                    await _dbContext.SaveChangesAsync();

                    return Ok(crypto);
                }

                catch (Exception ex)
                {
                    _logger.LogError($"An error occurred: {ex.Message}");
                    return StatusCode(500, "An error occurred while retrieving the data");
                }
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        //[HttpGet]
        //[Route("GetJoke")]
        //public async Task<IActionResult> Index()
        //{
        //    using var httpClient = new HttpClient();
        //    var jokesApiUrl = _configuration["JokesApiUrl"];
        //    Joke j = new Joke();

        //    try
        //    {
        //        // Make GET request to Jokes API
        //        HttpResponseMessage response = await httpClient.GetAsync(jokesApiUrl);

        //        // Check if request was successful
        //        if (response.IsSuccessStatusCode)
        //        {
        //            // Read response content as string
        //            string jsonResponse = await response.Content.ReadAsStringAsync();
        //            j = JsonConvert.DeserializeObject<Joke>(jsonResponse);

        //            // Display the joke (you can parse the JSON response if needed)
        //            return Ok(j);
        //        }
        //        else
        //        {
        //            return StatusCode((int)response.StatusCode, "Failed to retrieve joke.");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        return StatusCode(500, $"An error occurred: {ex.Message}");
        //    }
        //}

    }


}