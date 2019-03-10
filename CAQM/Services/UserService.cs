using System;
using System.Collections.Generic;
//using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using CAQM.Entities;
using CAQM.IServices;
using Microsoft.EntityFrameworkCore;

namespace CAQM.Services
{
   
    public class UserService : IUserService
    {
        private readonly DataContext _context;
        public UserService(DataContext context)
        {
            _context = context;
        }

        public User Authenticate(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                return null;

            var user = _context.Users.SingleOrDefault(x => x.Username == username);

            // check if username exists
            if (user == null)
                return null;

            // check if password is correct
            if (!VerifyPasswordHash(password, user.PasswordHash, user.PasswordSalt))
                return null;

            // authentication successful
            return user;
        }

        public IEnumerable<User> GetAll()
        {
            return _context.Users;
        }

        public User GetById(int id)
        {
            return _context.Users.Find(id);
        }

        public UserSiteDataDTO GetUserDataById(int id)
        {
            try
            {
                var UserData = new UserSiteDataDTO
                {
                    userId = id,
                    userSites = new List<UserSites>()
                };

                UserData.userSites = this.UserSites(id); 
                return UserData;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private List<UserSites> UserSites(int userID)
        {
            try
            {
                var data = (from site in _context.SiteData
                            where site.UserId == userID
                            select new UserSites
                            {

                                active = site.Active,
                                communityProjectName = site.CommunityProjectName,
                                siteName = site.SiteName,
                                siteId = site.SiteId,
                                siteLatitude = site.Latitude,
                                siteLongitude = site.Longitude,
                                siteElevation = site.Elevation,
                                //siteMonitors = this.SiteMonitors(site.SiteId.Trim())
                            }).ToListAsync().Result;

                foreach (var sm in data)
                {
                    sm.siteMonitors = this.SiteMonitors(sm.siteId.Trim());
                }
                return data;
            }
            catch (Exception ex)
            {
                return new List<UserSites>();
            }
        }

        private List<SiteMonitor> SiteMonitors(string siteID)
        {
            var data = (from mo in _context.Monitor
                        where mo.SiteId == siteID
                        select new SiteMonitor
                        {
                            dateStart = mo.EffectiveDate,
                            monitorId = mo.MonitorId,
                            Parameter = mo.Parameter,
                            monitorName = mo.MonitorName,
                            monitorPurpose = mo.MonitorPurpose,
                            monitorManufacturer = mo.MonitorManufacturer,
                            monitorModel = mo.MonitorModel,
                            monitorFirmwareVersion = mo.FirmwareVersion,
                            monitorPurchaseDate = mo.MonitorPurchaseDate,
                            monitorLastServiceDate = mo.LastServiceDate,
                            monitorCfrstring = mo.Cfrstring,
                            monitorFlowRate = mo.FlowRate,
                            monitorInletHeight = mo.InletHeight,
                            monitorInletOrientation = mo.InletOrientation,
                            monitorInletDiameter = mo.InletDiameter,
                            monitorSystemDescription = mo.SystemDescription,
                            active= mo.Active



                        }).Distinct().ToListAsync().Result;

            foreach (var sm in data)
            {
                sm.monitorParameters = this.MonitorParameters(sm.monitorId);
            }
            return data;
        }

        private List<MonitorParameters> MonitorParameters(string siteMonitorID)
        {
            return (from siteP in _context.SiteMonitorParameter
                    where siteP.SiteMonitorId == siteMonitorID
                    select new MonitorParameters
                    {
                        parameterIsActive = siteP.IsActive,
                        parameterCode = siteP.ParameterId,
                        //parameterName = "PM",
                        parameterMeasurementTechnique = siteP.MeasurementTechniqueId,
                        parameterMeasurementUnits = siteP.MeasurementUnitId,
                        parameterSamplingDuration = siteP.SampleDurationId,
                        parameterSamplingFrequency = siteP.SampleFrequencyId,
                        parameterUpperDetectionLimit = siteP.UpperDetectionLimit,
                        parameterLowerDetectionLimit = siteP.LowerDetectionLimit,
                        parameterMethodDetectionLimit = siteP.MethodDetectionLimit,
                        parameterDetectionRangeUnits = siteP.DetectionRangeUnitId,
                        parameterUncertainty = "", //siteP.MonitorUncertainty,
                        parameterPrecision = "", //siteP.MonitorPrecision,
                        parameterMeasurementResolution = "", //siteP.MeasurementResolution,
                        parameterLastCalibrationTimestamp = siteP.LastCalibrationTimestamp,
                        parameterDateStart = siteP.StartDate
                    }).Distinct().ToList();
        }


        public User Create(User user, string password)
        {
            // validation
            if (string.IsNullOrWhiteSpace(password))
                throw new AppException("Password is required");

            if (_context.Users.Any(x => x.Username == user.Username))
                throw new AppException("Username '" + user.Username + "' is already taken");

            byte[] passwordHash, passwordSalt;
            CreatePasswordHash(password, out passwordHash, out passwordSalt);

            user.PasswordHash = passwordHash;
            user.PasswordSalt = passwordSalt;

            //for testing
            if (_context.Role.ToList().Count == 0)
            {
                _context.Role.Add(new Roles { Role = "Administrator", CreatedDate = DateTime.Now });
                _context.SaveChanges();
            }

            user.RoleId = 1;

            _context.Users.Add(user);
            _context.SaveChanges();

            return user;
        }

        public void Update(User userParam, string password = null)
        {
            var user = _context.Users.Find(userParam.UserId);

            if (user == null)
                throw new AppException("User not found");

            if (userParam.Username != user.Username)
            {
                // username has changed so check if the new username is already taken
                if (_context.Users.Any(x => x.Username == userParam.Username))
                    throw new AppException("Username " + userParam.Username + " is already taken");
            }

            // update user properties
            user.FirstName = userParam.FirstName;
            user.LastName = userParam.LastName;
            user.Username = userParam.Username;

            // update password if it was entered
            if (!string.IsNullOrWhiteSpace(password))
            {
                byte[] passwordHash, passwordSalt;
                CreatePasswordHash(password, out passwordHash, out passwordSalt);

                user.PasswordHash = passwordHash;
                user.PasswordSalt = passwordSalt;
            }

            _context.Users.Update(user);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var user = _context.Users.Find(id);
            if (user != null)
            {
                _context.Users.Remove(user);
                _context.SaveChanges();
            }
        }

        // private helper methods

        private static void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            if (password == null) throw new ArgumentNullException("password");
            if (string.IsNullOrWhiteSpace(password)) throw new ArgumentException("Value cannot be empty or whitespace only string.", "password");

            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }

        private static bool VerifyPasswordHash(string password, byte[] storedHash, byte[] storedSalt)
        {
            if (password == null) throw new ArgumentNullException("password");
            if (string.IsNullOrWhiteSpace(password)) throw new ArgumentException("Value cannot be empty or whitespace only string.", "password");
            if (storedHash.Length != 64) throw new ArgumentException("Invalid length of password hash (64 bytes expected).", "passwordHash");
            if (storedSalt.Length != 128) throw new ArgumentException("Invalid length of password salt (128 bytes expected).", "passwordHash");

            using (var hmac = new System.Security.Cryptography.HMACSHA512(storedSalt))
            {
                var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                for (int i = 0; i < computedHash.Length; i++)
                {
                    if (computedHash[i] != storedHash[i]) return false;
                }
            }

            return true;
        }
    }
}
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 