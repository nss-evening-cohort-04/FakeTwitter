﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FakeTrello.Models;

namespace FakeTrello.DAL
{
    public class FakeTrelloRepository : IRepository
    //have absolute control over how things work here.
    {
        public FakeTrelloContext Context { get; set; }

        public FakeTrelloRepository ()
        {
            Context = new FakeTrelloContext();
        }

        public FakeTrelloRepository(FakeTrelloContext context)
        {
            Context = context;
        }

        public void AddBoard(string name, ApplicationUser owner)
        {
            Board newBoard = new Board { Name = name, Owner = owner };
            Context.Boards.Add(newBoard);
            Context.SaveChanges();
        }

        public void AddCard(string name, int listId, string ownerId)
        {
            throw new NotImplementedException();
        }

        public void AddCard(string name, List list, ApplicationUser owner)
        {
            throw new NotImplementedException();
        }

        public void AddList(string name, int boardId)
        {
            throw new NotImplementedException();
        }

        public void AddList(string name, Board board)
        {
            throw new NotImplementedException();
        }

        public bool AttachUser(string userId, int cardId)
        {
            throw new NotImplementedException();
        }

        public bool CopyCard(int cardId, int newListId, string newOwnerId)
        {
            throw new NotImplementedException();
        }

        public Board GetBoard(int boardId)
        {
            Board chosenBoard = Context.Boards.FirstOrDefault(fb => fb.BoardId == boardId);
            return chosenBoard;
        }

        public List<Board> GetBoardsFromUser(string userId)
        {
             return Context.Boards.Where(b => b.Owner.Id.ToString() == userId).ToList();
        }

        public Card GetCard(int cardId)
        {
            throw new NotImplementedException();
        }

        public List<ApplicationUser> GetCardAttendees(int cardId)
        {
            throw new NotImplementedException();
        }

        public List<Card> GetCardsFromBoard(int boardId)
        {
            throw new NotImplementedException();
        }

        public List<Card> GetCardsFromList(int listId)
        {
            throw new NotImplementedException();
        }

        public List GetList(int listId)
        {
            throw new NotImplementedException();
        }

        public List<List> GetListsFromBoard(int boardId)
        {
            throw new NotImplementedException();
        }

        public bool MoveCard(int cardId, int oldListId, int newListId)
        {
            throw new NotImplementedException();
        }

        public bool RemoveBoard(int boardId)
        {
            Board foundBoard = GetBoard(boardId);
            if (foundBoard != null)
            {
                Context.Boards.Remove(foundBoard);
                Context.SaveChanges();
                return true;
            }
            return false;
        }

        public bool RemoveCard(int cardId)
        {
            throw new NotImplementedException();
        }

        public bool RemoveList(int listId)
        {
            throw new NotImplementedException();
        }
    }
}