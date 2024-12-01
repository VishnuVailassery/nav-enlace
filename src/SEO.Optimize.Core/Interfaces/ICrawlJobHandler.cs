﻿using SEO.Optimize.Core.Models.Jobs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEO.Optimize.Core.Interfaces
{
    public interface ICrawlJobHandler
    {
        Task ProcessJobAsync(JobInfo jobInfo);
    }
}