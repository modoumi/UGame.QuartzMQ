using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UGame.Quartz.Service
{
    public static class QuartzHostBuilderExtensions
    {
        public static IHostBuilder UseQuartzServer(this IHostBuilder builder)
        {
            builder.UseXxyyCommonServer<QuartzOptionsSection>();
            return builder;
        }
    }
}
