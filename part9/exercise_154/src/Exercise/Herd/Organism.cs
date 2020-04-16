using System;
using System.Collections.Generic;

namespace Exercise
{
  public class Organism : IMovable
  {
    public int x;
    public int y;
    public Organism(int x, int y)
    {
      this.x = x;
      this.y = y;
    }
    public void Move(int dx, int dy)
    {
      this.x += dx;
      this.y += dy;
    }

    public override string ToString()
    {
      return "x: " + this.x + " ; y: " + this.y;
    }
  }
}