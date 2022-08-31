// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> The configuration settings of the Twitter provider. </summary>
    public partial class Twitter
    {
        /// <summary> Initializes a new instance of Twitter. </summary>
        public Twitter()
        {
        }

        /// <summary> Initializes a new instance of Twitter. </summary>
        /// <param name="isEnabled"> &lt;code&gt;false&lt;/code&gt; if the Twitter provider should not be enabled despite the set registration; otherwise, &lt;code&gt;true&lt;/code&gt;. </param>
        /// <param name="registration"> The configuration settings of the app registration for the Twitter provider. </param>
        internal Twitter(bool? isEnabled, TwitterRegistration registration)
        {
            IsEnabled = isEnabled;
            Registration = registration;
        }

        /// <summary> &lt;code&gt;false&lt;/code&gt; if the Twitter provider should not be enabled despite the set registration; otherwise, &lt;code&gt;true&lt;/code&gt;. </summary>
        public bool? IsEnabled { get; set; }
        /// <summary> The configuration settings of the app registration for the Twitter provider. </summary>
        public TwitterRegistration Registration { get; set; }
    }
}
