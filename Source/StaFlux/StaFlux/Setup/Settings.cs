using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaFlux.Setup
{
    public class Settings
    {
        public bool IsRepositoryActive
        {
            get;
            set;
        }

        public RepositoryType RepositoryType
        {
            get;
            set;
        }


    }

    public enum RepositoryType
    {
        JsonFile,
        XmlFile,
        StaFluxStructureFile,
        EfCoreSqlServer,
        EfCoreSqlLite,
        EfCoreMySql
    }
}
