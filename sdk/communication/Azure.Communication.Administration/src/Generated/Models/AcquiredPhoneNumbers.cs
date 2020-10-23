// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Communication.Administration.Models
{
    /// <summary> A wrapper of list of phone numbers. </summary>
    public partial class AcquiredPhoneNumbers
    {
        /// <summary> Initializes a new instance of AcquiredPhoneNumbers. </summary>
        internal AcquiredPhoneNumbers()
        {
            PhoneNumbers = new ChangeTrackingList<AcquiredPhoneNumber>();
        }

        /// <summary> Initializes a new instance of AcquiredPhoneNumbers. </summary>
        /// <param name="phoneNumbers"> Represents a list of phone numbers. </param>
        /// <param name="nextLink"> Represents the URL link to the next page. </param>
        internal AcquiredPhoneNumbers(IReadOnlyList<AcquiredPhoneNumber> phoneNumbers, string nextLink)
        {
            PhoneNumbers = phoneNumbers;
            NextLink = nextLink;
        }

        /// <summary> Represents a list of phone numbers. </summary>
        public IReadOnlyList<AcquiredPhoneNumber> PhoneNumbers { get; }
        /// <summary> Represents the URL link to the next page. </summary>
        public string NextLink { get; }
    }
}
