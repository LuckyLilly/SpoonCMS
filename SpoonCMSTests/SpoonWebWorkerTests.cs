using System;
using Xunit;
using SpoonCMS.Classes;
using SpoonCMS.Workers;
using static SpoonCMS.DataClasses.Enums;
using SpoonCMS.Interfaces;
using SpoonCMS.DataClasses;

namespace SpoonCMSTests
{
    public class SpoonWebWorkerTests
    {
        [Fact]
        public void GenerateDataWorkerTestPostgres() {
            ISpoonData data = SpoonWebWorker.GenerateDataWorker(SpoonDBType.PostGres, "testDirectory");

            Assert.NotNull(data);
            Assert.True(data is PostGresData);
        }

        [Fact]
        public void GenerateDataWorkerTestLiteDB()
        {
            ISpoonData data = SpoonWebWorker.GenerateDataWorker(SpoonDBType.LiteDB, "testDirectory");

            Assert.NotNull(data);
            Assert.True(data is LiteDBData);
        }

        [Fact]
        public void GenerateDataWorkerTestDefault()
        {
            ISpoonData data = SpoonWebWorker.GenerateDataWorker((SpoonDBType)(-1), "testDirectory");

            Assert.NotNull(data);
            Assert.True(data is LiteDBData);
        }

    }
}
