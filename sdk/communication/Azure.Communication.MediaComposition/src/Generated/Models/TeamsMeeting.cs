// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Communication.MediaComposition
{
    /// <summary> The TeamsMeeting. </summary>
    public partial class TeamsMeeting
    {
        /// <summary> Initializes a new instance of TeamsMeeting. </summary>
        public TeamsMeeting()
        {
        }

        /// <summary> Initializes a new instance of TeamsMeeting. </summary>
        /// <param name="teamsJoinUrl"></param>
        internal TeamsMeeting(string teamsJoinUrl)
        {
            TeamsJoinUrl = teamsJoinUrl;
        }

        /// <summary> Gets or sets the teams join url. </summary>
        public string TeamsJoinUrl { get; set; }
    }
}
