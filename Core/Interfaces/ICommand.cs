using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Interfaces
{
    public interface ICommand<T>
    {
        IActionResult Execute(T parameter);
    }
}
