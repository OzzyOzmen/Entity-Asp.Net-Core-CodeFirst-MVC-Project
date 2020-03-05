using System.Runtime.CompilerServices;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System;
using OzzyEntityLibraries.Repository;
using OzzyEntityLibraries.DTO.Models;
using OzzyEntityLibraries.ORM.Models;

namespace OzzyEntityLibraries.Services
{
    public class CustomersService
    {
        CustomersRepository customersRepository;

        public CustomersService()
        {
            if (customersRepository == null)
            {
                customersRepository = new CustomersRepository();
            }
        }

        public IEnumerable<CustomersDTO> GetAllCustomers()
        {
            return customersRepository.GetAll().Select(x => new CustomersDTO
            {
                CustomerId = x.CustomerId,
                ContactName = x.ContactName,
                ContactTitle = x.ContactTitle,
                Phone = x.Phone,
                Email = x.Email,
                Fax=x.Fax,
                CompanyName=x.CompanyName,
                Address=x.Address,
                PostalCode=x.PostalCode,
                TerritoryId=(int)x.TerritoryId,
                RegionId=(int)x.RegionId,
                CountryId=(int)x.CountryId

            }).ToList();
        }

        public void AddCustomers(CustomersDTO entity)
        {
            Customers customers = new Customers
            {
                ContactName = entity.ContactName,
                ContactTitle = entity.ContactTitle,
                Phone = entity.Phone,
                Email = entity.Email,
                Fax = entity.Fax,
                CompanyName = entity.CompanyName,
                Address = entity.Address,
                PostalCode = entity.PostalCode,
                TerritoryId = entity.TerritoryId,
                RegionId = entity.RegionId,
                CountryId = entity.CountryId

            };

            customersRepository.Add(customers);
        }

        public void UpdateCustomers(CustomersDTO entity)
        {
            var customer = customersRepository.GetAll().Where(x => x.CustomerId == entity.CustomerId).FirstOrDefault();
            customer.ContactName = entity.ContactName;
            customer.ContactTitle = entity.ContactTitle;
            customer.Phone = entity.Phone;
            customer.Email = entity.Email;
            customer.Fax = entity.Fax;
            customer.CompanyName = entity.CompanyName;
            customer.Address = entity.Address;
            customer.PostalCode = entity.PostalCode;
            customer.TerritoryId = entity.TerritoryId;
            customer.RegionId = entity.RegionId;
            customer.CountryId = entity.CountryId;

            customersRepository.Update(customer);

        }

        public void DeleteCustomers(CustomersDTO entity)
        {
            var customer = customersRepository.GetAll().Where(x => x.CustomerId == entity.CustomerId).FirstOrDefault();
            customer.ContactName = entity.ContactName;
            customer.ContactTitle = entity.ContactTitle;
            customer.Phone = entity.Phone;
            customer.Email = entity.Email;
            customer.Fax = entity.Fax;
            customer.CompanyName = entity.CompanyName;
            customer.Address = entity.Address;
            customer.PostalCode = entity.PostalCode;
            customer.TerritoryId = entity.TerritoryId;
            customer.RegionId = entity.RegionId;
            customer.CountryId = entity.CountryId;

            customersRepository.Delete(customer);

        }

        public bool DeleteCustomersById(int id)
        {
            return customersRepository.DeletebyEntity(x => x.CustomerId==id);

        } 

        
    }
}
