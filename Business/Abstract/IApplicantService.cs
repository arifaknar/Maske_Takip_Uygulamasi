using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IApplicantService //Interfaceler belli metod imzalarını barındırırlar.Birbirinin alternatifi olan sistemlerin farklı
        // imlematasyon yapmasını sağlar. Ayrıca Interfaceler new yapılmaz, referans tutarlar.
    {
         void ApplyForMask(Person person);

         List<Person> GetList();

         bool CheckPerson(Person person);
    }
}
