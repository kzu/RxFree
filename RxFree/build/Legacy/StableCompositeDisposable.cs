﻿using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;

namespace System
{
    /// <summary>
    /// For compatibility with Rx
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    [ExcludeFromCodeCoverage]
    internal class StableCompositeDisposable
    {
        /// <summary>
        /// For compatibility with Rx
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static IDisposable Create(params IDisposable[] disposables) => CompositeDisposable.Create(disposables);
    }
}
