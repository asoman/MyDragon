using UnityEngine;
using UnityEditor;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

public class GridHandlerTest {

    [Test]
    public void GridHandlerStartPosIsZero()
    {
        GridHandler grid = new GridHandler();
        Vector2 zero = grid.GetWorldCoordsOfCell(new Vector2(0, 0));
        Assert.IsTrue(zero.x == 0 && zero.y == 0, zero.ToString());
    }

    [Test]
    public void GridHandlerTopPosLargerThanZero()
    {
        GridHandler grid = new GridHandler();
        Vector2 top = grid.GetWorldCoordsOfCell(new Vector2(0, 1));
        Assert.IsTrue(top.x == 0 && top.y > 0, top.ToString());
    }

    [Test]
    public void GridHandlerTopPosLessThanZero()
    {
        GridHandler grid = new GridHandler();
        Vector2 bottom = grid.GetWorldCoordsOfCell(new Vector2(0, -1));
        Assert.IsTrue(bottom.x == 0 && bottom.y < 0, bottom.ToString());
    }

    [Test]
    public void GridHandlerLeftPosLessThanZero()
    {
        GridHandler grid = new GridHandler();
        Vector2 left = grid.GetWorldCoordsOfCell(new Vector2(-1, 0));
        Assert.IsTrue(left.x < 0 && left.y == 0, left.ToString());
    }

    [Test]
    public void GridHandlerRightPosLessThanZero()
    {
        GridHandler grid = new GridHandler();
        Vector2 right = grid.GetWorldCoordsOfCell(new Vector2(1, 0));
        Assert.IsTrue(right.x > 0 && right.y == 0, right.ToString());
    }

    [Test]
    public void GridHandlerMultiply()
    {
        GridHandler grid = new GridHandler(150,3);
        Vector2 pos = grid.GetWorldCoordsOfCell(new Vector2(1, 0));
        Assert.IsTrue(pos.y == 0 && pos.x == (150/3), pos.ToString());
    }
}
