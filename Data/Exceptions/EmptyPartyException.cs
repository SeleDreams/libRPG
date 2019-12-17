// Copyright - SeleDreams - 2019
namespace SeleDreams.libRPG.Exceptions
{
    using System;
    /// <summary>
    /// Exception thrown when attempting to use an empty party
    /// </summary>
    public class EmptyPartyException : InvalidOperationException
    {
        public EmptyPartyException()
        {
        }
    }
}
