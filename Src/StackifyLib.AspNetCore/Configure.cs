﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StackifyLib.Models;

namespace StackifyLib.AspNetCore
{
    internal class Configure
    {

        internal static IServiceProvider ServiceProvider { get; set; }

        internal static void SubscribeToWebRequestDetails(IServiceProvider serviceProvider)
        {
            if (ServiceProvider != null)
                return;

            ServiceProvider = serviceProvider;

            WebRequestDetail.SetWebRequestDetail += WebRequestDetailMapper.WebRequestDetail_SetWebRequestDetail;
        }
    }

}
