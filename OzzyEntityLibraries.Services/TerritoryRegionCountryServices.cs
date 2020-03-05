using System;
using System.Linq;
using System.Collections.Generic;
using OzzyEntityLibraries.Repository;
using OzzyEntityLibraries.DTO.Models;
using OzzyEntityLibraries.ORM.Models;
namespace OzzyEntityLibraries.Services
{
    public class TerritoryRegionCountryServices
    {
        TerritoriesRepository territoriesRepository;

        RegionsRepository regionsRepository;

        CountriesRepository countriesRepository;

        public TerritoryRegionCountryServices()
        {
            if (territoriesRepository == null)
            {
                territoriesRepository = new TerritoriesRepository();
            }
            if (regionsRepository == null)
            {
                regionsRepository = new RegionsRepository();
            }
            if (countriesRepository == null)
            {
                countriesRepository = new CountriesRepository();
            }
        }

        public IEnumerable<TerritoriesDTO> GetTerritoryService()
        {
            return territoriesRepository.GetAll().Select(x => new TerritoriesDTO
            {
                TerritoryId=x.TerritoryId,
                RegionId=x.RegionId,
                TerritoryName=x.TerritoryName

            }).ToList();
        }

        public IEnumerable<RegionsDTO> GetRegionService()
        {
            return regionsRepository.GetAll().Select(x => new RegionsDTO
            {
                RegionId = x.RegionId,
                CountryId=x.CountryId,
                RegionName=x.RegionName

            }).ToList();
        }

        public IEnumerable<CountriesDTO> GetCountryService()
        {
            return countriesRepository.GetAll().Select(x => new CountriesDTO
            {
                CountryId=x.CountryId,
                CountryName=x.CountryName

            }).ToList();
        }

        // There is no any Add, Update or Delete methods for this 
    }
}
