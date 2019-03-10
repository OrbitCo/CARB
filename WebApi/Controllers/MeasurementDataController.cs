using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CAQM.Entities;
using CAQM.Identity;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using OfficeOpenXml;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using CAQM;
using System.Text;
using System.Data;
using CAQM.Services;
using System.Text.RegularExpressions;

namespace WebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class MeasurementDataController : ControllerBase
    {
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly DataContext _context;
        private IUploadService _uploadService;

        public MeasurementDataController(IHostingEnvironment hostingEnvironment, DataContext context,
            IUploadService uploadService)
        {
            _hostingEnvironment = hostingEnvironment;
            _context = context;
            _uploadService = uploadService;
        }


        [HttpPost]
        [Route("SendFile")]
        public async Task<IActionResult> SendFile(IFormFile file)
        {
            if (file == null || file.Length == 0)
                return BadRequest(new { error = "File not selected" });

            string _fileExtension = Path.GetExtension(file.FileName).ToLower();
            var path = Path.Combine(
                       Directory.GetCurrentDirectory(), "wwwroot",
                       file.FileName);

            String CSVText = _uploadService.GetCSVText(path); 

            using (var stream = new FileStream(path, FileMode.Create))
            {
                await file.CopyToAsync(stream);

                byte[] document = new byte[file.Length];
                file.OpenReadStream().Read(document, 0, (Int32)file.Length);

                DataFile _file = new DataFile();
                _file.SubmittedFileName = file.FileName;
                //_file.SubmittedFile = document; //data type must be VarBinary(max)
                _file.SubmittedFile = CSVText;
                _file.FileIsLoaded = true;
                _file.LoadingErrors = null;
                _file.CreatedDate = DateTime.Now;

              //  _context.DataFile.Add(_file);
             //   _context.SaveChanges();
            }

            return Ok(CSVText);
        }

        [HttpPost]
        [Route("UploadCsv")]
        public async Task<IActionResult> UploadCsv(IFormFile file)
        {
            if (file == null || file.Length == 0)
                return BadRequest(new { error = "File not selected" });

            string _fileExtension = Path.GetExtension(file.FileName).ToLower();
            var path = Path.Combine(
                       Directory.GetCurrentDirectory(), "wwwroot",
                       file.FileName);

            if (_fileExtension.ToLower() == ".csv")
            {
                DataTable dt = _uploadService.GetCSVDataTable(path);

                foreach (DataRow row in dt.Rows)
                {
                    var test = row["Community Name / Project Name"].ToString();                    
                    //TODO Save into database table
                }

                return Ok();
            }
            return BadRequest(new { error = "Please enter a valid csv file." });
        }

        [HttpPost]
        [Route("UploadJson")]
        public async Task<IActionResult> UploadJson(IFormFile file)
        {
            if (file == null || file.Length == 0)
                return BadRequest(new { error = "File not selected" });

            string _fileExtension = Path.GetExtension(file.FileName).ToLower();
            var path = Path.Combine(
                       Directory.GetCurrentDirectory(), "wwwroot",
                       file.FileName);

            if (_fileExtension.ToLower() == ".json")
            {
                DataTable dt = _uploadService.GetJsonDataTable(path);

                foreach (DataRow row in dt.Rows)
                {
                    var test = row["Community Name / Project Name"].ToString();
                    MeasurementData _measurementData = new MeasurementData();
                    _measurementData.MonitorId = row["Monitor ID"] == DBNull.Value ? "" : Convert.ToString(row["Monitor ID"]);
                    _measurementData.DataFileId = row["ID"] == DBNull.Value ? 0 : Convert.ToInt64(row["ID"]);
                    //_measurementData.SiteId = row["Site ID"] == DBNull.Value ? "" : Convert.ToString(row["Site ID"]);
                    //_measurementData.MethodDetectionLimit = row["Monitor ID"] == DBNull.Value ? "" : Convert.ToString(row["Monitor ID"]);
                    //_measurementData.MonitorId = row["Monitor ID"] == DBNull.Value ? "" : Convert.ToString(row["Monitor ID"]);
                    //_measurementData.MonitorId = row["Monitor ID"] == DBNull.Value ? "" : Convert.ToString(row["Monitor ID"]);
                    //_measurementData.MonitorId = row["Monitor ID"] == DBNull.Value ? "" : Convert.ToString(row["Monitor ID"]);
                    //_measurementData.MonitorId = row["Monitor ID"] == DBNull.Value ? "" : Convert.ToString(row["Monitor ID"]);
                    //_measurementData.MonitorId = row["Monitor ID"] == DBNull.Value ? "" : Convert.ToString(row["Monitor ID"]);
                    //TODO Save into database table
                }

                return Ok();
            }
            return BadRequest(new { error = "Please enter a valid csv file." });
        }

        [HttpPost]
        [Route("Import")]
        public IList<MeasurementData> ImportMonitors([FromBody]List<JObject> measurementList)
        {
            List<MeasurementData> MeasurementDataList = new List<MeasurementData>();
            foreach (var data in measurementList)
            {
                var _measurementList = data.ToObject<Dictionary<string, string>>();
                int i = 0;
                MeasurementData m = new MeasurementData();
                foreach (KeyValuePair<string, string> __measurement in _measurementList)
                {
                    var _value = __measurement.Value == null ? "" : __measurement.Value.ToString().Trim();
                    _value = Regex.Replace(_value, @"\t|\n|\r", "");

                    try
                    {
                        
                      //  if (i == 0) m.SiteId =_value;
                        if (i == 1) m.MonitorId =_value;                       
                        if (i == 2)
                        {
                            try { m.ParameterId = Convert.ToInt32(_value); } catch { }
                        }
                        if (i == 3)
                        {
                            try { m.MethodDetectionLimit = Convert.ToDouble(_value); } catch { }
                        }
                        if (i == 4) m.DetectionRangeUnits =_value;
                        if (i == 5) m.LabOrganization =_value;
                        if (i == 6) 
                        {
                            try { m.Date = Convert.ToInt32(_value); } catch { }
                        }
                        if (i == 8)
                        {
                            try { m.ChannelAMeasurementValue = Convert.ToDecimal(_value); } catch { }
                        }
                        
                        if (i == 9)
                        {
                            try { m.ChannelBMeasurementValue = Convert.ToDecimal(_value); } catch { }
                        }                        
                        if (i == 10)
                        {
                            try { m.ChannelCMeasurementValue = Convert.ToDecimal(_value); } catch { }
                        }                        
                        //if (i == 11) 
                        //{
                        //    try { m.MeasurementValue = Convert.ToDouble(_value); } catch { }
                        //}
                        if (i == 11) 
                        {
                            try { m.MeasurementUnits = Convert.ToInt32(_value); } catch { }
                        }
                        if (i == 12)
                        {
                            try { m.ChannelAAdjustedMeasurementValue = Convert.ToDecimal(_value); } catch { }
                        }                       
                        if (i == 13)
                        {
                            try { m.ChannelDAdjustedMeasurementValue = Convert.ToDecimal(_value); } catch { }
                        }                       
                        if (i == 14)
                        {
                            try { m.ChannelCAdjustedMeasurementValue = Convert.ToDecimal(_value); } catch { }
                        }                        
                        //if (i == 15)
                        //{
                        //    try { m.AdjustedMeasurementValue = Convert.ToDouble(_value); } catch { }
                        //}

                        if (i == 15) 
                        {
                            try { m.AdjustmentTechnique = Convert.ToInt32(_value); } catch { }
                        }
                        if (i == 16) m.Uncertainty = _value;
                        if (i == 17) 
                        {
                            try { m.Quality = Convert.ToInt32(_value); } catch { }
                        }


                        m.CreatedDate = DateTime.Now;
                        m.UpdatedDate = DateTime.Now;
                    }
                    catch (Exception ex)
                    {

                    }
                    if (i == 14)
                        MeasurementDataList.Add(m);
                    i++;
                }
            }
            try
            {
                _context.MeasurementData.AddRange(MeasurementDataList);
                _context.SaveChanges();
            }
            catch (Exception ex)
            { }
            return MeasurementDataList;
        }


        [HttpGet]
        public IEnumerable<MeasurementData> GetMeasurementData()
        {
            return _context.MeasurementData;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetMeasurementData([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var measurementData = await _context.MeasurementData.FindAsync(id);

            if (measurementData == null)
            {
                return NotFound();
            }

            return Ok(measurementData);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutMeasurementData([FromRoute] long id, [FromBody] MeasurementData measurementData)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != measurementData.MeasurementDataId)
            {
                return BadRequest();
            }

            _context.Entry(measurementData).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MeasurementDataExists(id))
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

        [HttpPost]
        public async Task<IActionResult> PostMeasurementData([FromBody] MeasurementData measurementData)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                _context.MeasurementData.Add(measurementData);
                await _context.SaveChangesAsync();

                return CreatedAtAction("GetMeasurementData", new { id = measurementData.MeasurementDataId }, measurementData);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.InnerException);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMeasurementData([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var measurementData = await _context.MeasurementData.FindAsync(id);
            if (measurementData == null)
            {
                return NotFound();
            }

            _context.MeasurementData.Remove(measurementData);
            await _context.SaveChangesAsync();

            return Ok(measurementData);
        }

        private bool MeasurementDataExists(long id)
        {
            return _context.MeasurementData.Any(e => e.MeasurementDataId == id);
        }
    }
}