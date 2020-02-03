using ExampleProject.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleProject.Application.IntregationTest.Common
{
    public class CommandTestBase : IDisposable
    {
        public CommandTestBase()
        {
            Context = ApplicationDbContextFactory.Create();
        }

        public ApplicationDbContext Context { get; }

        public void Dispose()
        {
            ApplicationDbContextFactory.Destroy(Context);
        }
    }
}
