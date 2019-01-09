using System;
using Continent.Server.DataAccess.Packages;
using Continent.Server.Model.Packages;

namespace Continent.Server.Business.Pacakges
{
    public class PackageBusiness : BusinessBase<PackageRepository>
    {
        public void AddPackage(Package package)
        {
            Data.Add(package);
        }

        public void DeletePackage(Guid pacakgeId)
        {
            Data.Delete(pacakgeId);
        }
    }
}
