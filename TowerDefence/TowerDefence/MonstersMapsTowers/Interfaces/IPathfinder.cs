using System.Collections.Generic;

namespace MonstersMapsTowers.Interfaces
{
    public interface IPathfinder
    {
        Stack<string> CalculatePath(object rawPath);
    }
}