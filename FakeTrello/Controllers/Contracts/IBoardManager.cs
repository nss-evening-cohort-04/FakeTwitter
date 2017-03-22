using FakeTrello.Models;

namespace FakeTrello.Controllers.Contracts
{
    public interface IBoardManager
    {
        void AddBoard(string name, ApplicationUser owner);
        void EditBoardName(int boardId, string newname);
        bool RemoveBoard(int boardId);
    }
}