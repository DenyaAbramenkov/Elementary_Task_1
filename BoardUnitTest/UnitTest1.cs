using System;
using Elementary_Task_1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BoardUnitTest
{
    [TestClass]
    public class BoardUnitTest
    {
        [TestMethod]
        [DataRow(8, 8, 8, 8)]
        public void BoardCorrectBuild(int height, int width, int expectedheight, int expectedwidth)
        {
            //Arrange

            //Act
            Board board = Board.Initialize(height, width);

            //Assert
            Assert.AreEqual(expectedheight, board.Board_Height);
        }
       
        [TestMethod]
        [DataRow(-3, 2)]
        [DataRow(3, 4)]
        [ExpectedException(typeof(ArgumentException))]
        public void BoardBuild_ExceptionThrow(int height, int width)
        {
            //Arrange

            //Act
            Board board = Board.Initialize(height, width);

            //Assert
        }

        [TestMethod]
        [DataRow(8, 8, 1, 1, Colors.White)]
        [DataRow(8, 8, 3, 2, Colors.Black)]
        public void CellCorrectColor(int height, int width, int cellHeight, int cellWidth, Colors colors)
        {
            //Arrange

            //Act
            Board board = Board.Initialize(height, width);

            //Assert
            Assert.AreEqual(colors, board.Cells[cellHeight, cellWidth].Color);
        }

    }
}
