﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.AI.QuestionAnswering.Models
{
    public partial class CreateKnowledgebaseContents
    {
        /// <summary>
        /// Gets a list of questions and associated answers to add to the knowledgebase.
        /// </summary>
        /// <remarks>
        /// <see cref="QuestionAnswerContent.Id"/> is generated by the service and should be omitted.
        /// </remarks>
        [CodeGenMember("QnaList")]
        public IList<QuestionAnswerContent> QuestionAnswers { get; }

        /// <summary>
        /// Gets a list of <see cref="Uri"/>s to files to add to the knowledgebase.
        /// </summary>
        [CodeGenMember("Urls")]
        public IList<Uri> Uris { get; }

        /// <summary>
        /// Gets a list of files to add to the knowledgebase.
        /// </summary>
        public IList<KnowledgebaseFileContent> Files { get; }
    }
}
