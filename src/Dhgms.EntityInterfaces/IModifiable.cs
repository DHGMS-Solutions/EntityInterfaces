namespace Dhgms.EntityInterfaces
{
    using System;

    public interface IModifiable : ICreateable
    {
        DateTime Modified { get; }
    }
}