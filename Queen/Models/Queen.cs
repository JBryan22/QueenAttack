using System;

namespace Queens.Models
{
  public class Queen
  {
    private int _x;
    private int _y;

    public Queen(int x, int y)
    {
      _x = x;
      _y = y;
    }

    public int GetX()
    {
      return _x;
    }
    public int GetY()
    {
      return _y;
    }
    public bool CanAttack(int x, int y)
    {
      if(_x == x || _y == y || CanAttackDiagonal(x, y))
      {
        return true;
      }
      else
      {
        return false;
      }
    }

    public bool CanAttackDiagonal(int x, int y)
    {
      //Downleft
      int checkXs = _x;
      int checkYs = _y;
      while(checkXs >= x && checkYs >= y)
      {
        if (x == checkXs && y == checkYs)
        {
          return true;
        }
        checkXs--;
        checkYs--;
      }
      //UpLeft
      checkXs = _x;
      checkYs = _y;
      while(checkXs >= x && checkYs <= y)
      {
        if (x == checkXs && y == checkYs)
        {
          return true;
        }
        checkXs--;
        checkYs++;
      }
      //UpRight
      checkXs = _x;
      checkYs = _y;
      while(checkXs <= x && checkYs <= y)
      {
        if (x == checkXs && y == checkYs)
        {
          return true;
        }
        checkXs++;
        checkYs++;
      }
      //DownRight
      checkXs = _x;
      checkYs = _y;
      while(checkXs <= x && checkYs >= y)
      {
        if (x == checkXs && y == checkYs)
        {
          return true;
        }
        checkXs++;
        checkYs--;
      }
      return false;
    }
  }
}
