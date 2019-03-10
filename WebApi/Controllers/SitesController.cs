using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CAQM;
using CAQM.Entities;
using WebApi.Dtos;
using Newtonsoft.Json.Linq;
using System.Text.RegularExpressions;

namespace WebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class SitesController : ControllerBase
    {
        private readonly DataContext _context;
        public SitesController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> SiteData()
        {
            try
            {
                return Ok(_context.SiteData.ToList()); ;
            }
            catch (Exception ex)
            {
                return BadRequest(new { Error = ex.Message, Exception = ex.InnerException });
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetSiteData([FromRoute] int id)
        {
            var siteData = await _context.SiteData.FindAsync(id);
            if (siteData == null) return NotFound();

            return Ok(siteData);
        }

        [HttpPost("AddSite")]
        public async Task<IActionResult> PostSiteData([FromBody] SiteDataDto siteData)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                SiteData _site = new SiteData();
             
                _site.SiteId = siteData.SiteId.Trim();
                _site.Elevation = siteData.SiteElevation;
                _site.SiteName = siteData.SiteName;
                _site.CommunityProjectName = siteData.CommunityName;
                _site.Latitude = siteData.SiteLatitude;
                _site.Longitude = siteData.SiteLongitude;

                _site.Active = true;
                _site.UserId = 1;

                _site.CreatedBy = 1;
                _site.CreatedDate = DateTime.Now;

                _context.SiteData.Add(_site);
                await _context.SaveChangesAsync();

                return Ok(_site);
            }
            catch (Exception ex)
            {
                return BadRequest(new { Message = ex.Message, InnerException = ex.InnerException });
            }
        }

        [HttpPost]
        [Route("Import")]
        public IList<SiteData> ImportMonitors([FromBody]List<JObject> siteData)
        {
            List<SiteData> SiteDataList = new List<SiteData>();
            foreach (var data in siteData)
            {
                var _siteDataList = data.ToObject<Dictionary<string, string>>();
                int i = 1;
                SiteData site = new SiteData();
                foreach (KeyValuePair<string, string> __site in _siteDataList)
                {
                    var _value = __site.Value == null ? "" : __site.Value.ToString().Trim();
                    _value = Regex.Replace(_value, @"\t|\n|\r", "");
                    try
                    {
                        if (i == 1 && _value != "AS")
                        {
                            i++;
                            break;
                        }
                        if (i == 2) site.CommunityProjectName = _value;
                        if (i == 3) site.SiteName = _value;
                        if (i == 4) site.SiteId = _value;
                        if (i == 5) site.Latitude = Convert.ToDecimal(_value);
                        if (i == 6) site.Longitude = Convert.ToDecimal(_value);
                        if (i == 7) site.Elevation = _value;

                        site.CreatedDate = DateTime.Now;
                        site.UpdatedDate = DateTime.Now;
                    }
                    catch (Exception ex)
                    {
                    }

                    if (i == 7)
                        SiteDataList.Add(site);
                    else if (i > 7) break;
                    i++;
                }
            }
            try
            {
                _context.SiteData.AddRange(SiteDataList);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
            }
            return SiteDataList;
        }


        [HttpPost("Relocate")]
        public async Task<IActionResult> RelocateSite([FromBody] SiteDataDto _siteData)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                var site = _context.SiteData.Where(s => s.SiteId.Trim() == _siteData.SiteId.Trim()).FirstOrDefault();

                if (site == null)
                    return BadRequest(new { Error = "No such site id found." });

                site.SiteName = _siteData.SiteName;
                site.CommunityProjectName = _siteData.CommunityName;
                site.DeactivationEndDate = _siteData.DateEnd;
                site.Elevation = _siteData.SiteElevation;

                site.Latitude = _siteData.SiteLatitude;
                site.Longitude = _siteData.SiteLongitude;
                site.Explanation = _siteData.Explanation;
                site.RelocationEndDate = Convert.ToDateTime(_siteData.DateEnd);
                site.RelocationStartDate = Convert.ToDateTime(_siteData.DateStart);
                site.UpdatedBy = site.UserId;
                site.UpdatedDate = DateTime.Now;
               

                await _context.SaveChangesAsync();
                return Ok(site);
            }
            catch (Exception ex)
            {
                return BadRequest(new { Error = ex.Message, Exception = ex.InnerException });
            }
        }

        [HttpPost("Deactivate")]
        public async Task<IActionResult> DeactivateSite([FromBody] SiteDataDto _siteData)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                var site = _context.SiteData.Where(s => s.SiteId.Replace(@"\r\n", "").Trim() == _siteData.SiteId.Trim()).FirstOrDefault();

                if (site == null)
                    return BadRequest(new { Error = "No such site id found." });

                site.Active = false;
                site.UpdatedBy = site.UserId;
                site.UpdatedDate = DateTime.Now;
                site.DeactivationEndDate = _siteData.DateEnd;
                site.Explanation = _siteData.Explanation;
                await _context.SaveChangesAsync();
                return Ok(site);
            }
            catch (Exception ex)
            {
                return BadRequest(new { Error = ex.Message, Exception = ex.InnerException });
            }
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> PutSiteData([FromRoute] int id, [FromBody] SiteData siteData)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != siteData.Id)
            {
                return BadRequest();
            }

            _context.Entry(siteData).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SiteDataExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSiteData([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var siteData = await _context.SiteData.FindAsync(id);
            if (siteData == null)
            {
                return NotFound();
            }

            //_context.SiteData.Remove(siteData); //TODO Delete
            await _context.SaveChangesAsync();

            return Ok(siteData);
        }

        private bool SiteDataExists(int id)
        {
            return _context.SiteData.Any(e => e.Id == id);
        }
    }
}