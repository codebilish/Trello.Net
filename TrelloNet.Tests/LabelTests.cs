using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ExpectedObjects;
using NUnit.Framework;

namespace TrelloNet.Tests
{
    [TestFixture]
    public class LabelTests: TrelloTestBase
    {
        [Test]
        public void ForBoard_WelcomeBoard_ReturnsAllLabelsForWelcomeBoard()
        {
            var expectedLabels = CreateExpectedLabels();

            var labels = _trelloReadOnly.Labels.ForBoard(new BoardId(Constants.WelcomeBoardId));

            expectedLabels.ShouldEqual(labels);

        }

        private ExpectedObject CreateExpectedLabels()
        {

            var expectedLabels = new List<Label>
			{
            new Label { Id = "545a6bdb74d650d567cc6c5a", IdBoard = "4f2b8b4d4f2cb9d16d3684c9", Name = "label name",Color = Color.Green,Uses = 1},
            new Label { Id = "545a6bdb74d650d567cc6c5d", IdBoard = "4f2b8b4d4f2cb9d16d3684c9", Name = "",Color = Color.Red,Uses = 1},
            new Label { Id = "545a6bdb74d650d567cc6c5f", IdBoard = "4f2b8b4d4f2cb9d16d3684c9", Name = "",Color = Color.Blue,Uses = 0},
            new Label { Id = "545a6bdb74d650d567cc6c5c", IdBoard = "4f2b8b4d4f2cb9d16d3684c9", Name = "",Color = Color.Orange,Uses = 0},
            new Label { Id = "545a6bdb74d650d567cc6c5e", IdBoard = "4f2b8b4d4f2cb9d16d3684c9", Name = "",Color = Color.Purple,Uses = 0},
            new Label { Id = "545a6bdb74d650d567cc6c5b", IdBoard = "4f2b8b4d4f2cb9d16d3684c9", Name = "",Color = Color.Yellow,Uses = 0}
			}.ToExpectedObject();

            return expectedLabels;
        }
    }
}
