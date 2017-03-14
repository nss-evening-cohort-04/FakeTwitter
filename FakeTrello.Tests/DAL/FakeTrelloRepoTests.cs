using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FakeTrello.DAL;
using Moq;
using FakeTrello.Models;
using System.Linq;
using System.Data.Entity;
using System.Collections.Generic;

namespace FakeTrello.Tests.DAL
{
    [TestClass]
    public class FakeTrelloRepoTests
    {
        public Mock<FakeTrelloContext> fakeContext { get; set; }
        public FakeTrelloRepository repo { get; set; }
        public Mock<DbSet<Board>> mockBoardsSet { get; set; }
        public IQueryable<Board> queryBoards { get; set; }
        public List<Board> fakeBoardTable { get; set; }

        [TestInitialize]
        public void Setup ()
        {
            fakeBoardTable = new List<Board>();
            fakeContext = new Mock<FakeTrelloContext>();
            mockBoardsSet = new Mock<DbSet<Board>>();
            repo = new FakeTrelloRepository(fakeContext.Object);
        }

        [TestMethod]
        public void CreateFakeDatabase()
        {
            queryBoards = fakeBoardTable.AsQueryable();
            mockBoardsSet.As<IQueryable<Board>>().Setup(b => b.Provider).Returns(queryBoards.Provider);
            mockBoardsSet.As<IQueryable<Board>>().Setup(b => b.Expression).Returns(queryBoards.Expression);
            mockBoardsSet.As<IQueryable<Board>>().Setup(b => b.ElementType).Returns(queryBoards.ElementType);
            mockBoardsSet.As<IQueryable<Board>>().Setup(b => b.GetEnumerator()).Returns(() => queryBoards.GetEnumerator());
            mockBoardsSet.Setup(b => b.Add(It.IsAny<Board>())).Callback((Board b) => fakeBoardTable.Add(b));
            fakeContext.Setup(c => c.Boards).Returns(mockBoardsSet.Object);

        }

        [TestMethod]
        public void EnsureICanCreateAnInstanceOfRepo()
        {
            Assert.IsNotNull(repo);
        }

        [TestMethod]
        public void EnsureIHaveNotNullContext()
        {
            Assert.IsNotNull(repo.Context);
        }


        [TestMethod]
        public void EnsureICanInjectContextInstance()
        {
            Assert.IsNotNull(repo.Context);
        }

        [TestMethod]
        public void EnsureICanAddBoard()
        {
            CreateFakeDatabase();
       
            ApplicationUser aUser = new ApplicationUser {
                Id = "test-user-id",/*using identity framework nuget package*/
                UserName = "test-user-name",
                Email = "test@user.com"
            };
            
            //Act    
            repo.AddBoard("My Board", aUser);

            //Assert
            Assert.AreEqual(1, repo.Context.Boards.Count());
        }

        [TestMethod]
        public void EnsureICanReturnBoards()
        {
            //Arrange
            fakeBoardTable.Add(new Board { Name = "My board" });

            CreateFakeDatabase();

            //Act
            int expected_board_count = 1;
            int actual_board_count = repo.Context.Boards.Count();

            //Assert
            Assert.AreEqual(expected_board_count, actual_board_count);
        }

        [TestMethod]
        public void EnsureICanFindABoard()
        {
            //Arrange
            fakeBoardTable.Add(new Board { BoardId = 1, Name = "My Board" });
            CreateFakeDatabase();

            //Act
            string expected_board_name = "My Board";
            Board actual_board = repo.GetBoard(1);
            string actual_board_name = repo.GetBoard(1).Name;

            //Assert
            Assert.IsNotNull(actual_board);
            Assert.AreEqual(expected_board_name, actual_board_name);
        }
    }
}
