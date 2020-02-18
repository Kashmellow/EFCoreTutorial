using EFCoreTutorial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EFCoreTutorial
{
  public class SongRepository
    {
        private MusicContext db;

        public SongRepository(MusicContext db)
        {
            this.db = db;
        }

        public int Count()
        {
            return db.Songs.Count();
        }

        public void Create(Song song)
        {
            db.Songs.Add(song);
            db.SaveChanges();
        }

        public object GetById(int id)
        {
            return db.Songs.Single(s => s.Id == id);
        }

        public void Delete(Song song)
        {
            throw new NotImplementedException();
        }

        public object GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
