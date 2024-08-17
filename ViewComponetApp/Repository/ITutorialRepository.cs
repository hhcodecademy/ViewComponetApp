using ViewComponetApp.Models;

namespace ViewComponetApp.Repository
{
    public interface ITutorialRepository
    {
        Tutorial Add(Tutorial tutorail);
        Tutorial Update(Tutorial tutorail);
        Tutorial Delete(int Id);
        Tutorial GetTutorail(int Id);
        IEnumerable<Tutorial> GetAllTutorials();
    }
}
