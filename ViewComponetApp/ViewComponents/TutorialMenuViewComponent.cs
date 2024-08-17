using Microsoft.AspNetCore.Mvc;
using ViewComponetApp.Repository;

namespace ViewComponetApp.ViewComponents
{
    public class TutorialMenuViewComponent : ViewComponent
    {
        private readonly ITutorialRepository _tutorialRepository;

        public TutorialMenuViewComponent(ITutorialRepository tutorialRepository)
        {
            _tutorialRepository = tutorialRepository;
        }

        public IViewComponentResult Invoke() { 
        
            var tutorials=_tutorialRepository.GetAllTutorials().OrderBy(p=>p.Name);
            return View(tutorials);
        }
    }
}
