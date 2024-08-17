using ViewComponetApp.Data;
using ViewComponetApp.Models;

namespace ViewComponetApp.Repository
{
    public class TutorialRepository : ITutorialRepository
    {
        private readonly TutorialContext _context;

        public TutorialRepository(TutorialContext context)
        {
            _context = context;
        }

        public Tutorial Add(Tutorial tutorail)
        {
            _context.Tutorials.Add(tutorail);
            _context.SaveChanges();
            return tutorail;
        }

        public Tutorial Delete(int Id)
        {
            Tutorial tutorial = _context.Tutorials.Find(Id);
            if (tutorial != null)
            {
                _context.Tutorials.Remove(tutorial);
                _context.SaveChanges(true);
            }
            return tutorial;
        }

        public IEnumerable<Tutorial> GetAllTutorials()
        {
            return _context.Tutorials;
        }

        public Tutorial GetTutorail(int Id)
        {
            return _context.Tutorials.Find(Id);
        }

        public Tutorial Update(Tutorial tutorail)
        {
            _context.Update(tutorail);
            _context.SaveChanges();
            return tutorail;
        }
    }
}
