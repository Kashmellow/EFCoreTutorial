using System;
using Xunit;

namespace EFCoreTutorial.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Count_Starts_At_Zero()
        {
            var db = new MusicContext();
            var underTest = new SongRepository(db);

            var count = underTest.Count();

            Assert.Equal(-1, count);
        }
    }
}
