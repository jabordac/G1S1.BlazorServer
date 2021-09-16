using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace G1S1.BlazorServer.Helpers
{
    public static class IJSRuntimeExtensionMethods
    {
        public static async ValueTask<bool> DisplayMessageCSToJS(this IJSRuntime js, string mensaje)
        {
            return await js.InvokeAsync<bool>("DisplayMessageCSToJS", mensaje);
        }
    }
}
