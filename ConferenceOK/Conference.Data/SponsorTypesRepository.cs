using Conference.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Conference.Data
{
    public interface ISponsorTypesRepository
    {

        IEnumerable<SponsorTypes> GetSponsorTypes();
        SponsorTypes GetById(int id);
        SponsorTypes CreateSponsorTypes(SponsorTypes sponsorTypes);
        SponsorTypes Update(SponsorTypes sponsorTypes);
        void Delete(SponsorTypes sponsorTypes);
       


    }


    public class SponsorTypesRepository:ISponsorTypesRepository
    {

        private readonly ConferenceContext conferenceContext;


        public SponsorTypesRepository(ConferenceContext conferenceContext)
        {
            this.conferenceContext = conferenceContext;
        }

        public IEnumerable<SponsorTypes> GetSponsorTypes()
        {
            return conferenceContext.SponsorTypes.ToList();
        }

        public SponsorTypes GetById(int id)
        {
            var getById = conferenceContext.SponsorTypes.Find(id);
            return getById;
        }

        public SponsorTypes CreateSponsorTypes(SponsorTypes sponsorTypes)
        {
            var create = conferenceContext.SponsorTypes.Add(sponsorTypes);
            conferenceContext.SaveChanges();
            return create.Entity;
        }

        public SponsorTypes Update(SponsorTypes sponsorTypes)
        {
            var up = conferenceContext.SponsorTypes.Update(sponsorTypes);
            conferenceContext.SaveChanges();
            return up.Entity;

        }

        public void Delete(SponsorTypes sponsorTypes)
        {
            var del = conferenceContext.SponsorTypes.Remove(sponsorTypes);
            conferenceContext.SaveChanges();

        }

      


        

        }
}
