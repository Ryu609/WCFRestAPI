using DAL;

namespace WcfRestfulApi
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "AdventureWorkService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select AdventureWorkService.svc or AdventureWorkService.svc.cs at the Solution Explorer and start debugging.
    public class AdventureWorkService : IAdventureWorkService
    {
        private AdWorksEntities _db = new AdWorksEntities();
   
        public string GetPerson(string Id)
        {
            return _db.People.Find(int.Parse(Id)).FirstName;
        }
    }
}
