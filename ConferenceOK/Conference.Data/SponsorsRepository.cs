using Conference.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Conference.Data
{

    public interface ISponsorsRepository
    {
        IEnumerable<Sponsors> GetSponsor();
        Sponsors GetById(int id);
        Sponsors CreateSponsor(Sponsors sponsor);
        Sponsors Update(Sponsors sponsor);
        void Delete(Sponsors sponsor);
        bool IsUnique(int id);
    }







    public class SponsorsRepository:ISponsorsRepository
    {

        private readonly ConferenceContext conferenceContext;

        public SponsorsRepository(ConferenceContext conferenceContext)
        {
            this.conferenceContext = conferenceContext;
        }


        public IEnumerable<Sponsors> GetSponsor()
        {
            return conferenceContext.Sponsors.ToList();
        }

       

        public Sponsors GetById(int id)
        {
            var getById = conferenceContext.Sponsors.Find(id);
            return getById;
        }

        public Sponsors CreateSponsor(Sponsors sponsor)
        {
            var create = conferenceContext.Sponsors.Add(sponsor);
            conferenceContext.SaveChanges();
            return create.Entity;
        }

        public Sponsors Update(Sponsors sponsor)
        {
            var up = conferenceContext.Sponsors.Update(sponsor);
            conferenceContext.SaveChanges();
            return up.Entity;
        }

        public void Delete(Sponsors sponsor)
        {
            var del = conferenceContext.Sponsors.Remove(sponsor);
            conferenceContext.SaveChanges();

        }

        public bool IsUnique(int id)
        {
            var unique = conferenceContext.Sponsors.Count(x => x.SponsorTypeId == id);

            if (unique == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
