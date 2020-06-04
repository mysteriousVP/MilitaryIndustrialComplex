﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IOSBBRepository OSBBs { get; }
        IStreetRepository Streets { get; }
        void Save();
    }
}
