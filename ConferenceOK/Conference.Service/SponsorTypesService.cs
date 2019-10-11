using Conference.Data;
using Conference.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Conference.Service
{
    public interface ISponsorTypesService
    {

        IEnumerable<SponsorTypes> GetSponsorTypes();
        SponsorTypes GetById(int id);
        SponsorTypes Create(SponsorTypes sponsorTypes);
        SponsorTypes Update(SponsorTypes sponsorTypes);
        void DeleteSponsorTypes(SponsorTypes sponsorTypes);


    }

    public class SponsorTypesService:ISponsorTypesService
    {

        private readonly ISponsorTypesRepository sponsor;

        public SponsorTypesService(ISponsorTypesRepository sponsor)
        {
            this.sponsor = sponsor;
        }

        public IEnumerable<SponsorTypes> GetSponsorTypes()
        {
            return sponsor.GetSponsorTypes();
        }

        public SponsorTypes GetById(int id)
        {
            var getById = sponsor.GetById(id);
            return getById;
        }

        public SponsorTypes Create(SponsorTypes sponsorTypes)
        {
           
         return sponsor.CreateSponsorTypes(sponsorTypes);
            
        }

        public SponsorTypes Update(SponsorTypes sponsorTypes)
        {
            var up = sponsor.Update(sponsorTypes);
            return up;

        }

        public void DeleteSponsorTypes(SponsorTypes sponsorTypes)
        {
            sponsor.Delete(sponsorTypes);


        }

    }
}
