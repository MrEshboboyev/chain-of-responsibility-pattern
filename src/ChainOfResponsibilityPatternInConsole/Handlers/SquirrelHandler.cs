﻿using ChainOfResponsibilityPatternInConsole.Abstracts;

namespace ChainOfResponsibilityPatternInConsole.Handlers;

public class SquirrelHandler : AbstractHandler
{
    public override object Handle(object request)
    {
        if (request.ToString() == "Nut")
        {
            return $"Squirrel: I'll eat the {request.ToString()}\n";
        }
        else
        {
            return base.Handle(request);
        }
    }
}
