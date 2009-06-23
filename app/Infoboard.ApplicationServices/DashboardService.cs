using System.Collections.Generic;
using Infoboard.Core;
using Infoboard.Core.DataInterfaces;

namespace Infoboard.ApplicationServices
{
    public interface IDashboardService
    {
        List<Chart> GetChartsByBoardId(int boardId);
    }

    public class DashboardService : IDashboardService
    {
        private readonly IBoardRepository _boardRepository;
        private readonly IChartRepository _chartRepository;

        public DashboardService(IBoardRepository boardRepository, IChartRepository chartRepository) {
            _boardRepository = boardRepository;
            _chartRepository = chartRepository;
        }

        public List<Chart> GetChartsByBoardId(int boardId) {
            return new List<Chart>();
        }
    }
}
