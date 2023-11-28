using NoTownMusicalStore.Models.Entities;

namespace NoTownMusicalStore.Models.Repositories
{
    public class InstrumentRepository
    {
        protected readonly NoTownDbContext _context;

        public InstrumentRepository(NoTownDbContext context)
        {
            _context = context;
        }

        public List<Instrument> GetAllInstruments()
        {
            return _context.Instruments.ToList();
        }
        public Instrument GetInstrumentById(string id)
        {
            return _context.Instruments.SingleOrDefault(x => x.InstrumentID == id);
        }

        public void AddInstrument(Instrument instrument)
        {
            _context.Instruments.Add(instrument);
            _context.SaveChanges();
        }
        public void UpdateInstrument(string id)
        {
            var instrument = _context.Instruments.FirstOrDefault(x => x.InstrumentID == id);
            if (instrument != null)
            {
                _context.Instruments.Update(instrument);
                _context.SaveChanges();
            }
        }
        public void DeleteLive(string id)
        {
            var instrument = _context.Instruments.FirstOrDefault(x => x.InstrumentID == id);
            if (instrument != null)
            {
                _context.Instruments.Remove(instrument);
                _context.SaveChanges();
            }
        }
    }
}
