using ExampleProject.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleProject.Application.Common
{
    public class DateTimeService:IDateTime
    {
        public DateTime Now => DateTime.Now;
    }
}
