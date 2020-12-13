using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Commands
{
    public interface ICommand<T>
    {
        IActionResult Execute(T parameter);
    }
}
