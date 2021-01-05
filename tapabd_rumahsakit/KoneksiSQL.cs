using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tapabd_rumahsakit
{
    // Polimorphisme
    class KoneksiSQL //Base class
    {
        public virtual string goKoneksi()
        {
            string a = "KoneksiSQL";
            return a;
        }
    }

    class KoneksiIN : KoneksiSQL // derived class , Inheritance
    {
        public override string goKoneksi()
        {
            string a = "Data Source=localhost;Initial Catalog=dbRS;User ID=sa;password=faisyal123";
            return a;
        }
    }
}
