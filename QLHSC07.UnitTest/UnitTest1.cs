using System;
using QLHSC07.CORE.Helper;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace QLHSC07.UnitTest
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void TestMethod2()
        {
            //var path = @"D:\Freelancer\MaoND\BMBSoft\CGISDongTrieuBE\BMBSOFT.GIS.ApiGateway\Uploads\cgis\";
            //var geo = "domain=http://127.0.0.1:8015/geoserver/rest;username=admin;password=geoserver";
            //var conc = "User ID=postgres;Password=Bmbsoft@2020;Server=42.112.210.46;Port=5432;Database=dongtrieu2020_001;Integrated Security=true;Pooling=true;";

            //var buildShp = CUrlHelper.Tb2WMS(geo, conc, path, "public.test_col", "qhdongtrieu");
            //var run = GeoTaskHelper.RunBatchFile(path, buildShp);

            //Console.WriteLine(run);

            var random = new Random();
            var color = String.Format("#{0:X6}", random.Next(0x1000000));


            Console.WriteLine(color);
        }

    }
}
