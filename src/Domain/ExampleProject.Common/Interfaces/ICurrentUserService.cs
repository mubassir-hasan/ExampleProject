using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleProject.Common.Interfaces
{
    public interface ICurrentUserService
    {
        string CurrentUserIdentity { get; }
    }
}
