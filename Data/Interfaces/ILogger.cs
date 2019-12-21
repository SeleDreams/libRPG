using System;

namespace libRPG.Debug
{
    public interface ILogger
    {
        void Print(string message);
        void PrintDebug(object sender, string message);
        void PrintError(object sender, string message);
    }
}
