// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Maps.Common;

namespace Azure.Maps.Search.Models
{
    /// <summary> Details of the returned POI including information such as the name, phone, url address, and classifications. </summary>
    public partial class PointOfInterest
    {
        /// <summary> Initializes a new instance of <see cref="PointOfInterest"/>. </summary>
        internal PointOfInterest()
        {
            CategorySets = new ChangeTrackingList<PointOfInterestCategorySet>();
            Categories = new ChangeTrackingList<string>();
            Classifications = new ChangeTrackingList<PointOfInterestClassification>();
            Brands = new ChangeTrackingList<BrandName>();
        }

        /// <summary> Initializes a new instance of <see cref="PointOfInterest"/>. </summary>
        /// <param name="name"> Name of the POI property. </param>
        /// <param name="phone"> Telephone number property. </param>
        /// <param name="urlInternal"> Website URL property. </param>
        /// <param name="categorySets"> The list of the most specific POI categories. </param>
        /// <param name="categories"> Categories array. </param>
        /// <param name="classifications"> Classification array. </param>
        /// <param name="brands"> Brands array. The name of the brand for the POI being returned. </param>
        /// <param name="operatingHours"> Opening hours for a POI (Points of Interest). </param>
        internal PointOfInterest(string name, string phone, string urlInternal, IReadOnlyList<PointOfInterestCategorySet> categorySets, IReadOnlyList<string> categories, IReadOnlyList<PointOfInterestClassification> classifications, IReadOnlyList<BrandName> brands, OperatingHours operatingHours)
        {
            Name = name;
            Phone = phone;
            UrlInternal = urlInternal;
            CategorySets = categorySets;
            Categories = categories;
            Classifications = classifications;
            Brands = brands;
            OperatingHours = operatingHours;
        }

        /// <summary> Name of the POI property. </summary>
        public string Name { get; }
        /// <summary> Telephone number property. </summary>
        public string Phone { get; }
        /// <summary> Categories array. </summary>
        public IReadOnlyList<string> Categories { get; }
        /// <summary> Classification array. </summary>
        public IReadOnlyList<PointOfInterestClassification> Classifications { get; }
        /// <summary> Brands array. The name of the brand for the POI being returned. </summary>
        public IReadOnlyList<BrandName> Brands { get; }
        /// <summary> Opening hours for a POI (Points of Interest). </summary>
        public OperatingHours OperatingHours { get; }
    }
}
