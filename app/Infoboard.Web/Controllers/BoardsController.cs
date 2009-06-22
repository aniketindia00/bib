#region < References >
using System.Collections.Generic;
using System.Web.Mvc;
using Infoboard.Core;
using Infoboard.Core.DataInterfaces;
using SharpArch.Core;
using SharpArch.Web.NHibernate;

#endregion

namespace Infoboard.Web.Controllers
{
    [HandleError]
    public class BoardsController : Controller
    {
        private readonly IBoardRepository _boardRepository;

        public BoardsController(IBoardRepository boardRepository)
        {
            Check.Require(boardRepository != null, "_boardRepository may not be null");
            this._boardRepository = boardRepository;
        }

        public ActionResult Show(int boardId)
        {
            Board selectedBoard = _boardRepository.Get(boardId);
            return View(selectedBoard);
        }

        [Transaction]
        public ActionResult List()
        {
            List<Board>[] boardListArray = new List<Board>[2];
            boardListArray[0] = _boardRepository.LoadByUser("TestUser");
            boardListArray[1] = _boardRepository.LoadByUser("TestAdmin");
            return View(boardListArray);
        }
    }
}