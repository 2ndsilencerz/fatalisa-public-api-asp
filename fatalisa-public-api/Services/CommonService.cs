using fatalisa_public_api.Model;
using System;
using System.ComponentModel.Design;

namespace fatalisa_public_api.Services
{
    public class CommonService(ILogger<CommonService> logger)
    {
        public Body Get()
        {
            return VersionChecker(); 
        }

        private Body VersionChecker() {
            var res = new Body();
        	var buildDate = Environment.GetEnvironmentVariable("BUILD_DATE");
            if (buildDate != null && buildDate.Length > 0) {
		        res.Message = buildDate;
                return res;
            }

            try { 
                FileStream file = new FileStream("/build-date.txt", FileMode.Create, FileAccess.Write);
                StreamReader streamReader = new StreamReader(file);
                buildDate = streamReader.ReadToEnd();
                if (buildDate.Length > 0)
                {
                    res.Message = buildDate;
                    return res;
                }
            } catch (Exception e) { logger.LogError("{}", e.StackTrace); }
            return res;
        }
    }
}
