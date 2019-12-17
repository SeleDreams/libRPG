// Copyright - SeleDreams - 2019
using System;
namespace SeleDreams.libRPG.Exceptions
{
    /// <summary>
    /// Exception thrown when attempting to add more members to a party than the maximum amount authorized.
    /// </summary>
    public class FullPartyException : InvalidOperationException
    {
        public FullPartyException()
        {
        }
        public FullPartyException(string message) : base(message)
        {
        }
        public FullPartyException(string message, Exception inner) : base(message, inner)
        {
        }
    }
}
