using AgentyApplication.App_Start;
using AgentyApplication.Models;
using LiteDB;
using System.Linq;
using System.Web.Http;

namespace AgentyApplication.Controllers
{
    public class AgentyJobApplicationController : ApiController
    {
        private LiteDatabase _db;
        public AgentyJobApplicationController()
        {
            _db = DatabaseConfig.Db;
        }
        [HttpPost]
        public ObjectId Post(MyResume myResume)
        {
            myResume.Id = ObjectId.NewObjectId();
            var resumes = _db.GetCollection<MyResume>();
            resumes.EnsureIndex(r => r.Id);

            resumes.Insert(myResume);

            return myResume.Id;
        }

        [HttpGet]
        public MyResume Get(ObjectId id)
        {
            return _db.GetCollection<MyResume>().Find(r => r.Id == id).Single();
        }
    }
}
