using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using CAQM.Entities;
using CAQM.IServices;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


namespace CAQM.Services
{
    public interface IUploadService
    {
        List<Monitors> UploadMonitor(List<JObject> monitorsList);
        List<SiteData> UploadSiteData(List<JObject> siteData);
        DataTable GetCSVDataTable(string csvPath);
        DataTable GetJsonDataTable(string jsonPath);
        String GetCSVText(string csvPath);
    }

    public class UploadService : IUploadService
    {
        private DataContext _context;

        public UploadService(DataContext context)
        {
            _context = context;
        }



        public List<Monitors> UploadMonitor(List<JObject> monitorsList)
        {
            List<Monitors> MonitorsList = new List<Monitors>();
            List<SiteMonitorParameter> SiteMonitorParameterList = new List<SiteMonitorParameter>();
            try
            {
                foreach (var data in monitorsList)
                {
                    var _monitorList = data.ToObject<Dictionary<string, string>>();
                    int i = 1;
                    Monitors m = new Monitors();
                    SiteMonitorParameter _monitorP = new SiteMonitorParameter();
                    string TransactionType = "";

                    foreach (KeyValuePair<string, string> _monitor in _monitorList)
                    {
                        var _value = _monitor.Value == null ? "" : _monitor.Value.ToString().Trim();
                        _value = Regex.Replace(_value, @"\t|\n|\r", "");

                        try
                        {
                            if (i == 1 && !Helper.HasMonitorType(_value))
                            {
                                i++;
                                break;
                            }
                            if (i == 1) TransactionType = _value;
                            if (i == 3) m.MonitorName = _value;
                            if (i == 4) m.SiteId = _value;
                            if (i == 5) m.Latitude = Helper.ToDecimal(_value);
                            if (i == 6) m.Longitude = Helper.ToDecimal(_value);
                            if (i == 7) m.Elevation = _value;
                            if (i == 8) m.Cfrstring = _value;
                            if (i == 9) m.MonitorPurpose = _value;

                            if (i == 10) m.MonitorId = _value;

                            if (i == 11) m.SensorId = _value;
                            if (i == 12) m.MonitorManufacturer = _value;
                            if (i == 13) m.MonitorModel = _value;
                            if (i == 14) m.FirmwareVersion = _value;
                            if (i == 15) m.Parameter = Helper.ToInt32(_value) ?? 0;
                            if (i == 16) m.MeasurementTechnique = _value;
                            if (i == 17) m.SamplingFrequency = _value;
                            if (i == 18) m.SamplingDuration = _value;
                            if (i == 19) m.UpperDetectionLimit = _value;
                            if (i == 20) m.LowerDetectionLimit = _value;
                            if (i == 21) m.MethodDetectionLimit = _value;
                            if (i == 22) m.DetectionRangeUnits = _value;
                            if (i == 23) m.MonitorUncertainty = _value;
                            if (i == 24) m.Precision = _value;
                            if (i == 25) m.SystemDescription = _value;
                            if (i == 26) m.MonitorPurchaseDate = _value;
                            if (i == 27) m.LastCalibrationTimestamp = _value;
                            if (i == 28) m.LastServiceDate = _value;
                            if (i == 29) m.InletOrientation = _value;
                            if (i == 30) m.InletHeight = _value;
                            if (i == 31) m.InletDiameter = _value;
                            if (i == 32) m.FlowRate = _value;
                            if (i == 33) m.MeasurementResolution = _value;
                            if (i == 34) m.Explanation = _value;
                            m.Active = true;
                            m.CreatedDate = DateTime.Now;
                            m.UpdatedDate = DateTime.Now;
                            //if (i == 35) m.EffectiveDate = Convert.ToDateTime(_value);
                        }
                        catch (Exception ex)
                        {
                        }

                        //add monitor
                        if (i == 34 && (Helper.AMType(TransactionType) || Helper.CSType(TransactionType)))
                        {
                            var _Monitor = _context.Monitor.Where(x => x.MonitorId == m.MonitorId).FirstOrDefault();
                            if (_Monitor == null)
                            {
                                MonitorsList.Add(m);
                                //---
                                // _monitorP.StartDate = m.dateStart;
                                try
                                {
                                    _monitorP.DetectionRangeUnitId = Helper.ToInt32(m.DetectionRangeUnits);
                                    _monitorP.LastCalibrationTimestamp = Helper.ToDateTime(m.LastCalibrationTimestamp);
                                    _monitorP.LowerDetectionLimit = Helper.ToDouble(m.LowerDetectionLimit);
                                    _monitorP.MeasurementTechniqueId = Helper.ToInt32(m.MeasurementTechnique);
                                    _monitorP.MethodDetectionLimit = Helper.ToDouble(m.MethodDetectionLimit);
                                    //_monitorP.MeasurementUnitId = Convert.ToInt32(m.MeasurementUnit);
                                    _monitorP.SampleDurationId = Helper.ToInt32(m.SamplingDuration);
                                    _monitorP.SampleFrequencyId = m.SamplingFrequency;
                                    _monitorP.UpperDetectionLimit = Helper.ToDouble(m.UpperDetectionLimit);

                                    _monitorP.SiteMonitorId = m.MonitorId;
                                    _monitorP.ParameterId = m.Parameter;
                                    _monitorP.CreatedDate = DateTime.Now;

                                    SiteMonitorParameterList.Add(_monitorP);
                                }
                                catch (Exception ex)
                                {
                                }
                            }
                            //else return null;
                        }
                        else if (i == 34 && Helper.UMType(TransactionType))
                        {
                            var _Monitor = _context.Monitor.Where(x => x.MonitorId == m.MonitorId).FirstOrDefault();
                            if (_Monitor != null)
                            {
                                try
                                {
                                    _Monitor.MonitorName = m.MonitorName;
                                    _Monitor.SiteId = m.SiteId;
                                    _Monitor.Latitude = m.Latitude;
                                    _Monitor.Longitude = m.Longitude;
                                    _Monitor.Elevation = m.Elevation;
                                    _Monitor.Cfrstring = m.Cfrstring;
                                    _Monitor.MonitorPurpose = m.MonitorPurpose;
                                    _Monitor.SensorId = m.SensorId;
                                    _Monitor.MonitorManufacturer = m.MonitorManufacturer;
                                    _Monitor.MonitorModel = m.MonitorModel;
                                    _Monitor.FirmwareVersion = m.FirmwareVersion;
                                    _Monitor.Parameter = m.Parameter;
                                    _Monitor.MeasurementTechnique = m.MeasurementTechnique;
                                    _Monitor.SamplingFrequency = m.SamplingFrequency;
                                    _Monitor.SamplingDuration = m.SamplingDuration;
                                    _Monitor.UpperDetectionLimit = m.UpperDetectionLimit;
                                    _Monitor.LowerDetectionLimit = m.LowerDetectionLimit;
                                    _Monitor.MethodDetectionLimit = m.MethodDetectionLimit;
                                    _Monitor.DetectionRangeUnits = m.DetectionRangeUnits;
                                    _Monitor.MonitorUncertainty = m.MonitorUncertainty;
                                    _Monitor.Precision = m.Precision;
                                    _Monitor.SystemDescription = m.SystemDescription;
                                    _Monitor.MonitorPurchaseDate = m.MonitorPurchaseDate;
                                    _Monitor.LastCalibrationTimestamp = m.LastCalibrationTimestamp;
                                    _Monitor.LastServiceDate = m.LastServiceDate;
                                    _Monitor.InletOrientation = m.InletOrientation;
                                    _Monitor.InletHeight = m.InletHeight;
                                    _Monitor.InletDiameter = m.InletDiameter;
                                    _Monitor.FlowRate = m.FlowRate;
                                    _Monitor.MeasurementResolution = m.MeasurementResolution;
                                    _Monitor.Explanation = m.Explanation;
                                    _Monitor.UpdatedDate = DateTime.Now;

                                    try
                                    {
                                        _context.SaveChanges();
                                    }
                                    catch (Exception ex)
                                    {
                                        throw ex;
                                    }
                                }
                                catch (Exception ex)
                                {

                                }
                            }
                        }

                        else if (i == 34 && Helper.DPType(TransactionType))
                        {
                            
                            var _Parameter = _context.SiteMonitorParameter.Where(x => x.ParameterId == m.Parameter).FirstOrDefault();
                            if (_Parameter != null)
                            {
                                try
                                {
                                    _Parameter.IsActive = false;
                              
                                    
                                    try
                                    {
                                        _context.SaveChanges();
                                    }
                                    catch (Exception ex)
                                    {
                                        throw ex;
                                    }
                                }
                                catch (Exception ex)
                                {

                                }
                            }
                        }

                        else if (i == 34 && Helper.APType(TransactionType))
                        {
                            var _monitorAP = _context.Monitor.Where(x => x.MonitorId == m.MonitorId.Trim()).FirstOrDefault();
                            if (_monitorAP != null)
                            {
                                try
                                {
                                    SiteMonitorParameter smp = new SiteMonitorParameter();
                                    smp.DetectionRangeUnitId = Helper.ToInt32(m.DetectionRangeUnits);
                                    smp.LastCalibrationTimestamp = Helper.ToDateTime(m.LastCalibrationTimestamp);
                                    smp.LowerDetectionLimit = Helper.ToDouble(m.LowerDetectionLimit);
                                    smp.MeasurementTechniqueId = Helper.ToInt32(m.MeasurementTechnique);
                                    smp.MethodDetectionLimit = Helper.ToDouble(m.MethodDetectionLimit);
                                    //smp.MeasurementUnitId = Convert.ToInt32(m.MeasurementUnit);
                                    smp.SampleDurationId = Helper.ToInt32(m.SamplingDuration);
                                    smp.SampleFrequencyId = m.SamplingFrequency;
                                    smp.UpperDetectionLimit = Helper.ToDouble(m.UpperDetectionLimit);

                                    smp.SiteMonitorId = m.MonitorId;
                                    smp.ParameterId = m.Parameter;
                                    smp.CreatedDate = DateTime.Now;

                                    SiteMonitorParameterList.Add(smp);
                                    _context.SaveChanges();
                                }
                                catch (Exception ex)
                                {
                                    throw ex;
                                }
                            }
                          
                        }
                        i++;                      

                        //
                    }
                    //var test = ((_monitor).Keys.Items[0]).Value;
                }
                try
                {
                    _context.Monitor.AddRange(MonitorsList);
                    _context.SiteMonitorParameter.AddRange(SiteMonitorParameterList);
                    _context.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            catch (Exception ex)
            {
                //throw ex;
            }

            return MonitorsList;
        }

        
        public List<SiteData> UploadSiteData(List<JObject> siteData)
        {
            List<SiteData> SiteDataList = new List<SiteData>();
            try
            {
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
                            if (i == 1 && (_value != "AS" && _value != "CS"))                     
                            {
                                i++;
                                break;
                            }
                            if (i == 2) site.CommunityProjectName = _value;
                            if (i == 3) site.SiteName = _value;
                            if (i == 4) site.SiteId = _value;
                            if (i == 5) site.Latitude = Helper.ToDecimal(_value);
                            if (i == 6) site.Longitude = Helper.ToDecimal(_value);
                            if (i == 7) site.Elevation = _value;


                            site.CreatedDate = DateTime.Now;
                            site.UpdatedDate = DateTime.Now;
                            site.Active = true;
                            site.UserId = 1;
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
                    throw ex;
                }
            }
            catch (Exception ex)
            {
                // throw ex;
            }

            return SiteDataList;
        }

        public String GetCSVText(string csvPath)
        {
            try
            {
                using (var reader = new StreamReader(csvPath))
                {
                    while (!reader.EndOfStream)
                    {
                        return reader.ReadToEnd().ToString(); //read full file text  
                                                              //string[] rows = Fulltext.Split('\n'); //split full file text into rows  
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return "";
        }

        public DataTable GetCSVDataTable(string csvPath)
        {
            DataTable dtCSV = new DataTable();
            try
            {
                using (var reader = new StreamReader(csvPath))
                {
                    String Fulltext;
                    while (!reader.EndOfStream)
                    {
                        Fulltext = reader.ReadToEnd().ToString(); //read full file text  
                        string[] rows = Fulltext.Split('\n'); //split full file text into rows  
                        for (int i = 0; i < rows.Count() - 1; i++)
                        {
                            string[] rowValues = rows[i].Split(','); //split each row with comma to get individual values  
                            {
                                if (i == 0)
                                {
                                    for (int j = 0; j < rowValues.Count(); j++)
                                    {
                                        dtCSV.Columns.Add(rowValues[j]); //add headers  
                                    }
                                }
                                else
                                {
                                    DataRow dr = dtCSV.NewRow();
                                    for (int k = 0; k < rowValues.Count(); k++)
                                    {
                                        dr[k] = rowValues[k].ToString();
                                    }
                                    dtCSV.Rows.Add(dr); //add other rows  
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return dtCSV;

        }

        public DataTable GetJsonDataTable(string jsonPath)
        {
            DataTable dtCSV = new DataTable();
            try
            {
                using (StreamReader file = File.OpenText(jsonPath))
                using (JsonTextReader reader = new JsonTextReader(file))
                {
                    JObject o2 = (JObject)JToken.ReadFrom(reader);
                    //String Fulltext;
                    //while (!reader.EndOfStream)
                    //{
                    //    Fulltext = reader.ReadToEnd().ToString(); //read full file text  
                    //    string[] rows = Fulltext.Split('\n'); //split full file text into rows  
                    //    for (int i = 0; i < rows.Count() - 1; i++)
                    //    {
                    //        string[] rowValues = rows[i].Split(','); //split each row with comma to get individual values  
                    //        {
                    //            if (i == 0)
                    //            {
                    //                for (int j = 0; j < rowValues.Count(); j++)
                    //                {
                    //                    dtCSV.Columns.Add(rowValues[j]); //add headers  
                    //                }
                    //            }
                    //            else
                    //            {
                    //                DataRow dr = dtCSV.NewRow();
                    //                for (int k = 0; k < rowValues.Count(); k++)
                    //                {
                    //                    dr[k] = rowValues[k].ToString();
                    //                }
                    //                dtCSV.Rows.Add(dr); //add other rows  
                    //            }
                    //        }
                    //    }
                    //}
                }
            }
            catch (Exception ex)
            {

            }
            return dtCSV;

        }
    }
}