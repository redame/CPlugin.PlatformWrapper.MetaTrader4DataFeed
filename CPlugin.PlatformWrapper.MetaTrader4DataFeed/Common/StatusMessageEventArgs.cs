﻿using System;
using System.ComponentModel;
using System.Diagnostics;

namespace CPlugin.PlatformWrapper.MetaTrader4DataFeed.Common
{
    /// <summary>
    /// 
    /// </summary>
    public class StatusMessageEventArgs : EventArgs
    {
        
        
        private readonly object _context;

        
        
        private readonly Exception _exception;

        
        
        private readonly string _status;

        /// <summary>
        /// 
        /// </summary>
        public StatusMessageEventArgs(string status, Exception exception, object context)
        {
            _status = status;
            _context = context;
            _exception = exception;
        }

        /// <summary>
        /// 
        /// </summary>
        public string Status => _status;

        /// <summary>
        /// 
        /// </summary>
        public object Context => _context;

        /// <summary>
        /// 
        /// </summary>
        public Exception Exception => _exception;
    }
}