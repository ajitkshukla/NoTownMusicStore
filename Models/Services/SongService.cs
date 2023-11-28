using NoTownMusicalStore.Models.DTO;
using NoTownMusicalStore.Models.Entities;
using NoTownMusicalStore.Models.Repositories.Interfaces;

namespace NoTownMusicalStore.Models.Services
{
    public class SongService : ISongService
    {
        private readonly NoTownDbContext _context;
        public SongService(NoTownDbContext context)
        {
            _context = context;
        }
        public bool Add(Song song)
        {
            try
            {
                _context.Songs.Add(song);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                var data = this.GetById(id);
                if (data == null)
                    return false;
                _context.Songs.Remove(data);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public SongListViewModel GetAll(string term = "", bool paging = false, int currentPage = 0)
        {
            var list = _context.Songs.ToList();
            var data = new SongListViewModel();
            if (!string.IsNullOrEmpty(term))
            {
                term = term.ToLower();
                
                list = list.Where(a => a.Title.ToLower().StartsWith(term) || a.Musicians.ToLower().StartsWith(term) || a.Album.ToLower().StartsWith(term)).ToList();
            }
            if (paging)
            {
                // here we will apply paging
                int pageSize = 5;
                int count = list.Count;
                int TotalPages = (int)Math.Ceiling(count / (double)pageSize);
                list = list.Skip((currentPage - 1) * pageSize).Take(pageSize).ToList();
                data.PageSize = pageSize;
                data.CurrentPage = currentPage;
                data.TotalPages = TotalPages;
            }
            data.SongList = list.AsQueryable();
            return data;
        }

        public Song GetById(int id)
        {
            return _context.Songs.Find(id);
        }

        public bool Update(Song song)
        {
            try
            {
                _context.Songs.Update(song);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
