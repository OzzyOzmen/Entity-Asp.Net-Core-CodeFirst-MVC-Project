using System.Linq;
using System.Collections.Generic;
using System;
using OzzyEntityLibraries.Repository;
using OzzyEntityLibraries.DTO.Models;
using OzzyEntityLibraries.ORM.Models;

namespace OzzyEntityLibraries.Services
{
    public class GeneralSettingsServices
    {

        GeneralSettingsRepository generalSettingsRepository;
        public GeneralSettingsServices()
        {
            if (generalSettingsRepository == null)
            {
                generalSettingsRepository = new GeneralSettingsRepository();
            }
        }

        public IEnumerable<GeneralSettingsDTO> GetAllGeneralSettingsServices()
        {
            return generalSettingsRepository.GetAll().Select(r => new GeneralSettingsDTO
            {

                GeneralSettingsId = r.GeneralSettingsId,
                WebSiteName = r.WebSiteName,
                WebSiteAddress = r.WebSiteAddress,
                Keywords = r.Keywords,
                Email = r.Email,
                EmailPassword = r.EmailPassword,
                SmtpAddress = r.SmtpAddress,
                SmtpPort=r.SmtpPort,
                CompanyAddress=r.CompanyAddress,
                Phone=r.Phone,
                SiteLogo=r.SiteLogo


            }).ToList();
        }

        public void AddNewGeneralSettingsServices(GeneralSettingsDTO entity)
        {
            GeneralSettings generalSettings = new GeneralSettings
            {
                WebSiteName = entity.WebSiteName,
                WebSiteAddress = entity.WebSiteAddress,
                Keywords = entity.Keywords,
                Email = entity.Email,
                EmailPassword = entity.EmailPassword,
                SmtpAddress = entity.SmtpAddress,
                SmtpPort=entity.SmtpPort,
                CompanyAddress = entity.CompanyAddress,
                Phone = entity.Phone,
                SiteLogo = entity.SiteLogo

            };
            generalSettingsRepository.Add(generalSettings);
        }

        public void UpdateGeneralSettingsServices(GeneralSettingsDTO entity)
        {
            var generalSettings = generalSettingsRepository.GetAll().Where(x=>x.GeneralSettingsId==entity.GeneralSettingsId).FirstOrDefault();
            generalSettings.WebSiteName=entity.WebSiteName;
            generalSettings.WebSiteAddress=entity.WebSiteAddress;
            generalSettings.Keywords=entity.Keywords;
            generalSettings.Email=entity.Email;
            generalSettings.EmailPassword=entity.EmailPassword;
            generalSettings.SmtpAddress=entity.SmtpAddress;
             generalSettings.SmtpPort=entity.SmtpPort;
            generalSettings.CompanyAddress = entity.CompanyAddress;
            generalSettings.Phone = entity.Phone;
            generalSettings.SiteLogo = entity.SiteLogo;

            generalSettingsRepository.Update(generalSettings);
        }

         public void DeleteGeneralSettingsServices(GeneralSettingsDTO entity)
        {
           var generalSettings = generalSettingsRepository.GetAll().Where(x=>x.GeneralSettingsId==entity.GeneralSettingsId).FirstOrDefault();
            generalSettings.WebSiteName=entity.WebSiteName;
            generalSettings.WebSiteAddress=entity.WebSiteAddress;
            generalSettings.Keywords=entity.Keywords;
            generalSettings.Email=entity.Email;
            generalSettings.EmailPassword=entity.EmailPassword;
            generalSettings.SmtpAddress=entity.SmtpAddress;
             generalSettings.SmtpPort=entity.SmtpPort;
            generalSettings.CompanyAddress = entity.CompanyAddress;
            generalSettings.Phone = entity.Phone;
            generalSettings.SiteLogo = entity.SiteLogo;


            generalSettingsRepository.Delete(generalSettings);
        }

        public bool DeleteGeneralSettingsServicesById(int id)
        {
            return generalSettingsRepository.DeletebyEntity(r=>r.GeneralSettingsId==id);
        }
    }
}
