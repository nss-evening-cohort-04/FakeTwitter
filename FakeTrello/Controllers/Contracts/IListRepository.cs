using System.Collections.Generic;
using FakeTrello.Models;

namespace FakeTrello.Controllers.Contracts
{
    interface IListRepository
    {
        #region create methods
        void AddList(string name, Board board);
        void AddList(string name, int boardId);
        #endregion

        //read methods
        List GetList(int listId);
        List<List> GetListsFromBoard(int boardId); // List of Trello Lists

        //Delete
        bool RemoveList(int listId);
    }
}
