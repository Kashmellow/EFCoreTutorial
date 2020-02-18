using EFCoreTutorial.Models;
using System;
using Xunit;

namespace EFCoreTutorial.Tests
{
    public class SongRepositoryTests : IDisposable
    {
        private MusicContext db;
        private SongRepository underTest;

        public SongRepositoryTests()
        {
            db = new MusicContext();
            db.Database.BeginTransaction();

            underTest = new SongRepository(db);
        }

        public void Dispose()
        {
            db.Database.RollbackTransaction();
        }

        // Hiding the tests for brevity, but you'll need
        // to refactor them to use the db field instead of
        // the local variable.

    }
    public class UnitTest1
    {
        [Fact]
        public void Count_Starts_At_Zero()
        {
            var db = new MusicContext();
            var underTest = new SongRepository(db);

            var count = underTest.Count();

            Assert.Equal(0, count);
        }

        [Fact]
        public void Create_Increases_Count()
        {
            var db = new MusicContext();
            var underTest = new SongRepository(db);

            underTest.Create(new Song() { Title = "Foo" });

            var count = underTest.Count();
            Assert.Equal(1, count);
        }
    }
}
