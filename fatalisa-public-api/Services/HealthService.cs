using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.Design;
using System.Net;

namespace fatalisa_public_api.Services
{
    public class HealthService
    { 
        public string GetHealth()
        {
            return "pong";
        }
    }
}
