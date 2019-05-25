using System;

namespace The_Algorithm
{
  public static class The_Algorithm
  {
    public static int TheAlgorithm(float i)
    {
      return (int) ((double) i + new Random().NextDouble() * 4.0 - 2.0);
    }
  }
}
