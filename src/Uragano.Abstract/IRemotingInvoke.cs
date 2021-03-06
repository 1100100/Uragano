﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace Uragano.Abstractions
{
    public interface IRemotingInvoke
    {
        Task<T> InvokeAsync<T>(object[] args, string route, string serviceName, Dictionary<string, string> meta = default);

        Task InvokeAsync(object[] args, string route, string serviceName, Dictionary<string, string> meta = default);
    }
}
