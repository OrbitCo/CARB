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
using CAQM.Services;
using CAQM;
using WebApi.Dtos;

namespace WebApi.Controllers
{

    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class MonitorsController : ControllerBase
    {
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly DataContext _context;
        private IUploadService _uploadService;

        public MonitorsController(IHostingEnvironment hostingEnvironment, DataContext context,
            IUploadService uploadService)
        {
            _hostingEnvironment = hostingEnvironment;
            _context = context;
            _uploadService = uploadService;
        }

        [HttpPost]
        [Route("Import")]
        public async Task<IActionResult> ImportMonitors([FromBody]List<JObject> csvList)
        {
            try
            {
                var MonitorsList = _uploadService.UploadMonitor(csvList);

                if (MonitorsList == null)
                    return BadRequest(new { Error = "One of the Monitor Id already exists", Exception = string.Empty });
                else
                {
                    var UploadSiteDataList = _uploadService.UploadSiteData(csvList);
                    return Ok(MonitorsList);
                }
            }
            catch (Exception ex)
            {
                return BadRequest(new { Error = ex.Message, Exception = ex.InnerException });
            }
        }

        [HttpPost]
        [Route("AddMonitor")]
        public async Task<IActionResult> AddMonitor([FromBody]AddSiteDto monitor)
        {

            Monitors _monitor = new Monitors();

            foreach (var m in monitor.siteMonitors)
            {
                try
                {
                    var _MonitorExist = _context.Monitor.Where(x => x.MonitorId == m.monitorId);
                   // if (_MonitorExist != null)
                    //    return BadRequest(new { Error = "Monitor Id already exists." });
                    
                    _monitor.Active = true;
                    _monitor.EffectiveDate = m.dateStart;
                    _monitor.SiteId = monitor.siteId;
                    _monitor.MonitorId = m.monitorId;
                    _monitor.MonitorModel = m.monitorModel;
         
                    _monitor.MonitorPurpose = m.monitorPurpose;
                    //_monitor.Parameter = m.
                    _monitor.MonitorManufacturer = m.monitorManufacturer;
                    _monitor.MonitorPurchaseDate = m.monitorPurchaseDate;
                    _monitor.FirmwareVersion = m.monitorFirmwareVersion;
                    _monitor.InletDiameter = m.monitorInletDiameter;
                    _monitor.InletHeight = m.monitorInletHeight;
                    _monitor.InletOrientation = m.monitorInletOrientation;
                    _monitor.LastServiceDate = m.monitorLastServiceDate.ToString();

                    _monitor.CreatedDate = DateTime.Now;

                    foreach (var mp in m.monitorParameters)
                    {
                        SiteMonitorParameter _monitorP = new SiteMonitorParameter();
                        _monitorP.StartDate = mp.dateStart;
                        if (!string.IsNullOrEmpty(mp.parameterCode))
                            _monitorP.ParameterId = Helper.ToInt32(mp.parameterCode) ?? 0;
                        if (!string.IsNullOrEmpty(mp.parameterDetectionRangeUnits))
                            _monitorP.DetectionRangeUnitId = Helper.ToInt32(mp.parameterDetectionRangeUnits);

                        try
                        {
                            _monitorP.LastCalibrationTimestamp = mp.parameterLastCalibrationTimestamp;
                        }
                        catch (Exception ex) { }
                        


                        if (!string.IsNullOrEmpty(mp.parameterLowerDetectionLimit))
                            _monitorP.LowerDetectionLimit = Helper.ToDouble(mp.parameterLowerDetectionLimit);
                        if (!string.IsNullOrEmpty(mp.parameterMeasurementTechnique))
                            _monitorP.MeasurementTechniqueId = Helper.ToInt32(mp.parameterMeasurementTechnique);
                        if (!string.IsNullOrEmpty(mp.parameterMethodDetectionLimit))
                            _monitorP.MethodDetectionLimit = Helper.ToDouble(mp.parameterMethodDetectionLimit);
                        if (!string.IsNullOrEmpty(mp.parameterMeasurementUnits))
                            _monitorP.MeasurementUnitId = Helper.ToInt32(mp.parameterMeasurementUnits) ?? 0;
                        

                        //Invalid column name 'MeasurementResolution'.
                        //Invalid column name 'MonitorPrecision'.
                        //Invalid column name 'MonitorUncertainty'.

                        //_monitorP.parameterName = mp.parameterName
                        //_monitorP.MonitorPrecision = mp.parameterPrecision;
                        //_monitorP.MeasurementResolution = mp.parameterMeasurementResolution;

                        _monitorP.Uncertainty = mp.parameterUncertainty;
                        if (!string.IsNullOrEmpty(mp.parameterSamplingDuration))
                            _monitorP.SampleDurationId = Helper.ToInt32(mp.parameterSamplingDuration);
                        if (!string.IsNullOrEmpty(mp.parameterSamplingFrequency))
                            _monitorP.SampleFrequencyId = mp.parameterSamplingFrequency;
                        if (!string.IsNullOrEmpty(mp.parameterUpperDetectionLimit))
                            _monitorP.UpperDetectionLimit = Helper.ToDouble(mp.parameterUpperDetectionLimit);

                        _monitorP.SiteMonitorId = _monitor.MonitorId;
                        if (!string.IsNullOrEmpty(mp.parameterCode))
                            _monitor.Parameter = Helper.ToInt32(mp.parameterCode) ?? 0;

                        _monitorP.CreatedDate = DateTime.Now;
                        _context.SiteMonitorParameter.Add(_monitorP);
                    }

                    _context.Monitor.Add(_monitor);
                    _context.SaveChanges();
                }
                catch (Exception ex)
                {
                    return BadRequest(new { Error = ex.Message, Exception = ex.InnerException });
                }
            }
            
            return Ok(monitor);
        }

        [HttpPost]
        [Route("Add")]
        public async Task<IActionResult> Add([FromBody]AddMonitorDto monitor)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            List<SiteMonitorParameter> SiteMonitorParameterList = new List<SiteMonitorParameter>();
            try
            {
                var _MonitorExist = _context.Monitor.Where(x => x.MonitorId == monitor.monitorId).FirstOrDefault();
                if (_MonitorExist != null)
                    return BadRequest(new { Error = "Monitor Id already exists." });

                Monitors _monitor = new Monitors();
                _monitor.EffectiveDate = monitor.dateStart;
                _monitor.Active = true;
                _monitor.SiteId = monitor.siteId;
                _monitor.MonitorId = monitor.monitorId;
                _monitor.MonitorName = "Monitor";
                _monitor.Cfrstring = monitor.monitorCfrSiting;
                if (monitor.monitorFirmwareVersion != null)
                    _monitor.FirmwareVersion = monitor.monitorFirmwareVersion.ToString();
                _monitor.FlowRate = monitor.monitorFlowRate;
                _monitor.InletDiameter = monitor.monitorInletDiameter;
                _monitor.InletHeight = monitor.monitorInletHeight;
                _monitor.InletOrientation = monitor.monitorInletOrientation;
                if (monitor.monitorLastServiceDate != null)
                    _monitor.LastServiceDate = monitor.monitorLastServiceDate.ToString();
                _monitor.MonitorManufacturer = monitor.monitorManufacturer;
                _monitor.MonitorModel = monitor.monitorModel;
                if (monitor.monitorPurchaseDate != null)
                    _monitor.MonitorPurchaseDate = monitor.monitorPurchaseDate.ToString();
                _monitor.MonitorPurpose = monitor.monitorPurpose;
                _monitor.SystemDescription = monitor.monitorSystemDescription;
                _monitor.CreatedDate = DateTime.Now;

                foreach (var mp in monitor.monitorParameters)
                {
                    SiteMonitorParameter _monitorP = new SiteMonitorParameter();
                    _monitorP.StartDate = mp.dateStart;
                    _monitorP.ParameterId = Helper.ToInt32(mp.parameterCode) ?? 0;
                    _monitorP.DetectionRangeUnitId = Helper.ToInt32(mp.parameterDetectionRangeUnits);                    
                    _monitorP.LowerDetectionLimit = Helper.ToDouble(mp.parameterLowerDetectionLimit);
                    _monitorP.MeasurementTechniqueId = Helper.ToInt32(mp.parameterMeasurementTechnique);
                    _monitorP.MethodDetectionLimit = Helper.ToDouble(mp.parameterMethodDetectionLimit);
                    _monitorP.MeasurementUnitId = Helper.ToInt32(mp.parameterMeasurementUnits) ?? 0;
                    _monitorP.Uncertainty = mp.parameterUncertainty;

                    //Invalid column name 'MeasurementResolution'.
                    //Invalid column name 'MonitorPrecision'.
                    //_monitorP.parameterName = mp.parameterName
                    //_monitorP.MonitorPrecision = mp.parameterPrecision;
                    //_monitorP.MeasurementResolution = mp.parameterMeasurementResolution;

                    _monitorP.SampleDurationId = Helper.ToInt32(mp.parameterSamplingDuration);
                    _monitorP.SampleFrequencyId = mp.parameterSamplingFrequency;
                    _monitorP.UpperDetectionLimit = Helper.ToDouble(mp.parameterUpperDetectionLimit);

                    _monitorP.SiteMonitorId = monitor.monitorId;
                    _monitor.Parameter = Helper.ToInt32(mp.parameterCode) ?? 0;

                    try
                    {
                        _monitorP.LastCalibrationTimestamp = mp.parameterLastCalibrationTimestamp;
                    }
                    catch (Exception ex) { }

                    _monitorP.CreatedDate = DateTime.Now;
                    SiteMonitorParameterList.Add(_monitorP);
                }

                _context.SiteMonitorParameter.AddRange(SiteMonitorParameterList);
                _context.Monitor.Add(_monitor);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                return BadRequest(new { Error = ex.Message, Exception = ex.InnerException });
            }

            return Ok(monitor);
        }


        [HttpPost]
        [Route("Update")]
        public async Task<IActionResult> UpdateMonitor([FromBody]AddMonitorDto monitor)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                var _monitor = _context.Monitor.Where(x => x.MonitorId == monitor.monitorId).FirstOrDefault();
                if (_monitor == null)
                    return BadRequest(new { Error = "No Such Monitor Id Exist", Exception = string.Empty });

               // _monitor.MonitorId = monitor.monitorId;
               // _monitor.MonitorName = "Monitor";
                _monitor.Cfrstring = monitor.monitorCfrSiting;

                if (monitor.monitorFirmwareVersion != null)
                    _monitor.FirmwareVersion = monitor.monitorFirmwareVersion.ToString();

                _monitor.EffectiveDate = monitor.dateStart;
                _monitor.FlowRate = monitor.monitorFlowRate;
                _monitor.InletDiameter = monitor.monitorInletDiameter;
                _monitor.InletHeight = monitor.monitorInletHeight;
                _monitor.InletOrientation = monitor.monitorInletOrientation;

                if (monitor.monitorLastServiceDate != null)
                    _monitor.LastServiceDate = monitor.monitorLastServiceDate.ToString();

                _monitor.MonitorManufacturer = monitor.monitorManufacturer;
                _monitor.MonitorModel = monitor.monitorModel;

                if (monitor.monitorPurchaseDate != null)
                    _monitor.MonitorPurchaseDate = monitor.monitorPurchaseDate.ToString();

                _monitor.MonitorPurpose = monitor.monitorPurpose;
                _monitor.Explanation = monitor.explanation;
                _monitor.SystemDescription = monitor.monitorSystemDescription;
                _monitor.CreatedDate = DateTime.Now;
                
                //SiteMonitorParameter _monitorP = new SiteMonitorParameter();
                foreach (var mp in monitor.monitorParameters)
                {
                    if (!string.IsNullOrEmpty(mp.parameterCode))
                        _monitor.Parameter = Helper.ToInt32(mp.parameterCode) ?? 0;

                    var _monitorP = _context.SiteMonitorParameter.Where(x => x.SiteMonitorId == monitor.monitorId).FirstOrDefault();
                    if (_monitorP == null) continue; 

                    _monitorP.StartDate = mp.dateStart;
                    if (!string.IsNullOrEmpty(mp.parameterCode))
                        _monitorP.ParameterId = Helper.ToInt32(mp.parameterCode) ?? 0;
                    if (!string.IsNullOrEmpty(mp.parameterDetectionRangeUnits))
                        _monitorP.DetectionRangeUnitId = Helper.ToInt32(mp.parameterDetectionRangeUnits);
                    if (!string.IsNullOrEmpty(mp.parameterLowerDetectionLimit))
                        _monitorP.LowerDetectionLimit = Helper.ToDouble(mp.parameterLowerDetectionLimit);
                    if (!string.IsNullOrEmpty(mp.parameterMeasurementTechnique))
                        _monitorP.MeasurementTechniqueId = Helper.ToInt32(mp.parameterMeasurementTechnique);
                    if (!string.IsNullOrEmpty(mp.parameterMethodDetectionLimit))
                        _monitorP.MethodDetectionLimit = Helper.ToDouble(mp.parameterMethodDetectionLimit);
                    if (!string.IsNullOrEmpty(mp.parameterMeasurementUnits))
                        _monitorP.MeasurementUnitId = Helper.ToInt32(mp.parameterMeasurementUnits) ?? 0;

                    //Invalid column name 'MeasurementResolution'.
                    //Invalid column name 'MonitorPrecision'.
                    //Invalid column name 'MonitorUncertainty'.

                    //_monitorP.parameterName = mp.parameterName
                    //_monitorP.MonitorUncertainty = mp.parameterUncertainty;
                    //_monitorP.MeasurementResolution = mp.parameterMeasurementResolution;

                    _monitorP.Uncertainty = mp.parameterUncertainty;
                    if (!string.IsNullOrEmpty(mp.parameterSamplingDuration))
                        _monitorP.SampleDurationId = Helper.ToInt32(mp.parameterSamplingDuration);
                    _monitorP.SampleFrequencyId = mp.parameterSamplingFrequency;
                    if (!string.IsNullOrEmpty(mp.parameterUpperDetectionLimit))
                        _monitorP.UpperDetectionLimit = Helper.ToDouble(mp.parameterUpperDetectionLimit);

                    try
                    {
                        _monitorP.LastCalibrationTimestamp = mp.parameterLastCalibrationTimestamp;
                    }
                    catch (Exception ex) { }

                    _monitorP.SiteMonitorId = monitor.monitorId;                    
                    _monitorP.CreatedDate = DateTime.Now;
                    //_context.SiteMonitorParameter.Add(_monitorP);
                }

                //_context.Monitor.Add(_monitor);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                return BadRequest(new { Error = ex.Message, Exception = ex.InnerException });
            }

            return Ok(monitor);
        }

        [HttpPost("Relocate")]
        public async Task<IActionResult> RelocateMonitor([FromBody] RelocateMonitorDto _monitor)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                var monitor = _context.Monitor.Where(s => s.MonitorId == _monitor.monitorId).FirstOrDefault();

                if (monitor == null)
                    return BadRequest(new { Error = "No such monitor id found." });

                //TODO:: Non-editable fields
               // monitor.MonitorName = _monitor.communityName;
               // monitor.MonitorManufacturer = _monitor.monitorManufacturer;
                //monitor.MonitorModel = _monitor.monitorModel;

                monitor.Latitude = _monitor.siteLatitude;
                monitor.Longitude = _monitor.siteLongitude;
                monitor.UpdatedDate= DateTime.Now;
                monitor.SiteId = _monitor.siteId;
                monitor.Elevation = _monitor.siteElevation;
                monitor.Cfrstring = _monitor.monitorCfrSiting;
                monitor.MonitorPurpose = _monitor.monitorPurpose;
                monitor.FirmwareVersion = _monitor.monitorFirmwareVersion;
                monitor.SystemDescription = _monitor.monitorSystemDescription;
                monitor.MonitorPurchaseDate = _monitor.monitorPurchaseDate;
                monitor.LastServiceDate = _monitor.monitorLastServiceDate;
                monitor.InletOrientation = _monitor.monitorInletOrientation;
                monitor.InletHeight = _monitor.monitorInletHeight;
                monitor.InletDiameter = _monitor.monitorInletDiameter;
                monitor.FlowRate = _monitor.monitorFlowRate;
                monitor.Explanation = _monitor.explanation;
                monitor.RelocateStartDate = _monitor.dateStart;
                monitor.RelocateEndDate = _monitor.dateEnd;

                //monitor.SensorId=_monitor.
                //monitor.Parameter=_monitor.
                //monitor.MeasurementTechnique=_monitor.
                //monitor.SamplingFrequency=_monitor.
                //monitor.SamplingDuration=_monitor.
                //monitor.UpperDetectionLimit=_monitor.
                //monitor.LowerDetectionLimit=_monitor.
                //monitor.MethodDetectionLimit=_monitor.
                //monitor.DetectionRangeUnits=_monitor.
                //monitor.MonitorUncertainty=_monitor.un
                //monitor.Precision=_monitor.pre
                //monitor.LastCalibrationTimestamp=_monitor.tim
                //monitor.LastEntryId=_monitor.
                //monitor.UpdatedBy = _monitor
                //monitor.MeasurementResolution=_monitor.res
                //monitor.EffectiveDate=_monitor.eff
                //monitor.Active=_monitor.ac

                await _context.SaveChangesAsync();
                return Ok(monitor);
            }
            catch (Exception ex)
            {
                return BadRequest(new { Error = ex.Message, Exception = ex.InnerException });
            }
        }

        [HttpPost("Deactivate")]
        public async Task<IActionResult> DeactivateMonitor([FromBody] Monitors _monitor)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                var monitor = _context.Monitor.Where(s => s.MonitorId == _monitor.MonitorId).FirstOrDefault();

                if (monitor == null)
                    return BadRequest(new { Error = "No such monitor id found." });

                monitor.Active = false;
                monitor.UpdatedDate = DateTime.Now;
                await _context.SaveChangesAsync();
                return Ok(monitor);
            }
            catch (Exception ex)
            {
                return BadRequest(new { Error = ex.Message, Exception = ex.InnerException });
            }
        }

        // GET: api/Monitors
        [HttpGet]
        public IEnumerable<Monitors> GetMonitor()
        {
            return _context.Monitor;
        }

        // GET: api/Monitors/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMonitors([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var monitors = await _context.Monitor.FindAsync(id);

            if (monitors == null)
            {
                return NotFound();
            }

            return Ok(monitors);
        }

        // PUT: api/Monitors/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMonitors([FromRoute] string id, [FromBody] Monitors monitors)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != monitors.MonitorId)
            {
                return BadRequest();
            }

            _context.Entry(monitors).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MonitorsExists(id))
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

        // POST: api/Monitors
        [HttpPost]
        public async Task<IActionResult> PostMonitors([FromBody] Monitors monitors)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Monitor.Add(monitors);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMonitors", new { id = monitors.MonitorId }, monitors);
        }

        // DELETE: api/Monitors/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMonitors([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var monitors = await _context.Monitor.FindAsync(id);
            if (monitors == null)
            {
                return NotFound();
            }

            _context.Monitor.Remove(monitors);
            await _context.SaveChangesAsync();

            return Ok(monitors);
        }

        private bool MonitorsExists(string id)
        {
            return _context.Monitor.Any(e => e.MonitorId == id);
        }
        
    }
}