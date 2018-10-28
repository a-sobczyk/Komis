using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Komis.Models
{
    public interface ISamochod
    {
        IEnumerable<Samochod> PobierzWszystkieSamochody();
        Samochod PobierzSamochodOId(int samochodId);
    }
}
