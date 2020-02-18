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
    }
}
