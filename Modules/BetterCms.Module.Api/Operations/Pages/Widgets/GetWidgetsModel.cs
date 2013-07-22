﻿using System.Runtime.Serialization;

namespace BetterCms.Module.Api.Operations.Pages.Widgets
{
    [DataContract]
    public class GetWidgetsModel : DataOptions
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetWidgetsModel" /> class.
        /// </summary>
        public GetWidgetsModel()
        {
            IncludeUnpublished = true;

            FieldExceptions.Add("WidgetType");
        }

        /// <summary>
        /// Gets or sets a value indicating whether to include unpublished blog posts.
        /// </summary>
        /// <value>
        ///   <c>true</c> if to include unpublished blog posts; otherwise, <c>false</c>.
        /// </value>
        [DataMember]
        public bool IncludeUnpublished { get; set; }
    }
}