// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Maps.Common;

namespace Azure.Maps.Weather.Models
{
    /// <summary> The GeoJsonMultiLineStringData. </summary>
    internal partial class GeoJsonMultiLineStringData
    {
        /// <summary> Initializes a new instance of <see cref="GeoJsonMultiLineStringData"/>. </summary>
        /// <param name="coordinates"> Coordinates for the `GeoJson MultiLineString` geometry. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="coordinates"/> is null. </exception>
        internal GeoJsonMultiLineStringData(IEnumerable<IList<IList<double>>> coordinates)
        {
            Argument.AssertNotNull(coordinates, nameof(coordinates));

            Coordinates = coordinates.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="GeoJsonMultiLineStringData"/>. </summary>
        /// <param name="coordinates"> Coordinates for the `GeoJson MultiLineString` geometry. </param>
        internal GeoJsonMultiLineStringData(IReadOnlyList<IList<IList<double>>> coordinates)
        {
            Coordinates = coordinates;
        }

        /// <summary> Coordinates for the `GeoJson MultiLineString` geometry. </summary>
        public IReadOnlyList<IList<IList<double>>> Coordinates { get; }
    }
}
