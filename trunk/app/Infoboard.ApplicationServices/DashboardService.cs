using System.Collections.Generic;
using Infoboard.Core;
using Infoboard.Core.DataInterfaces;
using SharpArch.Core.PersistenceSupport;
using SharpArch.Web.NHibernate;

namespace Infoboard.ApplicationServices
{
    public interface IDashboardService
    {
        List<Visualization> GetChartsByBoardId(int boardId);
        Visualization GetBoardWithId(int id);
    }

    public class DashboardService : IDashboardService
    {
        private readonly IRepository<Board> BoardRepository;
        private readonly IRepository<Visualization> VisualizationRepository;

        public DashboardService(IRepository<Board> boardRepository, IRepository<Visualization> visualizationRepository) {
            BoardRepository = boardRepository;
            VisualizationRepository = visualizationRepository;
        }

        public List<Visualization> GetChartsByBoardId(int boardId) {
            return new List<Visualization>();
        }

        [Transaction]
        public Visualization GetBoardWithId(int id) {
            
            return VisualizationRepository.Get(2);
        }
    }
}
