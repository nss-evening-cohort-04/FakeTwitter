using System.Collections.Generic;
using FakeTrello.Models;

namespace FakeTrello.DAL
{
    public interface IBoardQuery
    {
        List<Board> GetBoardsFromUser(string userId);
        Board GetBoard(int boardId);
    }
}