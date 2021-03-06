﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
using Shared;

namespace MyEngine
{
    public class EngineServiceProvider : ServiceProviderBase
    {
        public EngineServiceProvider(IUserContext userContext) : base(userContext)
        {
            serviceCollection.AddScoped<IMyEngine, MyEngine>();
        }
    }
}
