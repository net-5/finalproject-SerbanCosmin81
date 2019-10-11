
using Conference.Data;
using Conference.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Conference.Service
{
    public interface ISpeakerService
    {
        void DeleteSpeaker(Speakers speakers);
        Speakers Update(Speakers speakers);
        Speakers Create(Speakers speakers);
        Speakers GetById(int id);
        IEnumerable<Speakers> GetSpeakers();
    }

    public class SpeakerService:ISpeakerService
    {

        private ISpeakersRepository speakersRepository;

        public SpeakerService(ISpeakersRepository speakersRepository)
        {
            this.speakersRepository = speakersRepository;
        }

        public IEnumerable<Speakers> GetSpeakers()
        {
            return speakersRepository.GetSpeakers();
        }

        public Speakers GetById(int id)
        {
            var getById = speakersRepository.GetById(id);
            return getById;
        }

        public Speakers Create(Speakers speakers)
        {
            
        return speakersRepository.CreateSpeakers(speakers);
            
        }

        public Speakers Update(Speakers speakers)
        {
            var up = speakersRepository.Update(speakers);
            return up;

        }

        public void DeleteSpeaker(Speakers speakers)
        {
           speakersRepository.Delete(speakers);

            
        }

    }
}
