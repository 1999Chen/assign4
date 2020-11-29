﻿﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Models;

namespace assign3_final.Data
{
    public interface IAdultService
    {

        Task AddAdultAsync(Adult adult);

        IEnumerable<Adult> GetAdultAsync();



    }
}