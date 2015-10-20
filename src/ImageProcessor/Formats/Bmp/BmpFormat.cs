﻿// <copyright file="BmpFormat.cs" company="James South">
// Copyright © James South and contributors.
// Licensed under the Apache License, Version 2.0.
// </copyright>

namespace ImageProcessor.Formats
{
    /// <summary>
    /// Encapsulates the means to encode and decode bitmap images.
    /// </summary>
    public class BmpFormat : IImageFormat
    {
        /// <inheritdoc/>
        public IImageDecoder Decoder => new BmpDecoder();

        /// <inheritdoc/>
        public IImageEncoder Encoder => new BmpEncoder();
    }
}