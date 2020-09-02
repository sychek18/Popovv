using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Popovv
{
    class Quetions
    {
        public string ImageAddres;
        public string QuetionText;
        public Dictionary<bool, string> Ansvers = new Dictionary<bool, string>();

        public Quetions CreteGuetion()
        {
            Quetions quetions = new Quetions();

            quetions.ImageAddres = GetImageAsync().GetAwaiter().GetResult();
            quetions.QuetionText = "asd";
            quetions.Ansvers.Add(true, "yes");
            return quetions;
        }
        private async Task<string> GetImageAsync()
        {
            return await Task<string>.Run(() => GetImage());
        }
        private string GetImage()
        {
            return "as";
        }
    }
}
