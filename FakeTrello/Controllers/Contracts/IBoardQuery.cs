using System.Collections.Generic;
using FakeTrello.Models;

namespace FakeTrello.Controllers.Contracts
{
    public interface IBoardQuery
    {
        List<Board> GetBoardsFromUser(string userId);
        Board GetBoard(int boardId);
    }
}