using Conference.Data;
using Conference.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Conference.Service
{
    public interface ISponsorService
    {
        IEnumerable<Sponsors> GetSponsor();
        Sponsors GetById(int id);
        Sponsors Create(Sponsors sponsor);
        Sponsors Update(Sponsors sponsor);

        void DeleteSponsor(Sponsors sponsor);
    }

    public class SponsorService : ISponsorService
    {

        private readonly ISponsorsRepository sponsorRepository;

        public SponsorService(ISponsorsRepository sponsorRepository)
        {
            this.sponsorRepository = sponsorRepository;
        }

        public IEnumerable<Sponsors> GetSponsor()
        {
            return sponsorRepository.GetSponsor();
        }

        public Sponsors GetById(int id)
        {
            var getById = sponsorRepository.GetById(id);
            return getById;
        }

        public Sponsors Create(Sponsors sponsor)
        {
            if (IsUnique(sponsor.SponsorTypeId))
            {
                return sponsorRepository.CreateSponsor(sponsor);
            }
            return null;
        }

        public Sponsors Update(Sponsors sponsor)
        {
            var up = sponsorRepository.Update(sponsor);
            return up;

        }


        public bool IsUnique(int id)
        {

            return sponsorRepository.IsUnique(id);

        }

        public void DeleteSponsor(Sponsors sponsor)
        {
            sponsorRepository.Delete(sponsor);


        }
    }
}