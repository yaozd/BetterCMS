﻿namespace BetterCms.Module.Api.Operations.MediaManager.MediaTree
{
    public class GetMediaTreeModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetMediaTreeModel" /> class.
        /// </summary>
        public GetMediaTreeModel()
        {
            IncludeImagesTree = true;
            IncludeVideosTree = true;
            IncludeFilesTree = true;
        }

        /// <summary>
        /// Gets or sets a value indicating whether to include images tree.
        /// </summary>
        /// <value>
        ///   <c>true</c> if include images tree; otherwise, <c>false</c>.
        /// </value>
        public bool IncludeImagesTree { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to include the files of images tree.
        /// </summary>
        /// <value>
        ///   <c>true</c> if include the files of images tree; otherwise, <c>false</c>.
        /// </value>
        public bool IncludeImages { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to include videos tree.
        /// </summary>
        /// <value>
        ///   <c>true</c> if include videos tree; otherwise, <c>false</c>.
        /// </value>
        public bool IncludeVideosTree { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to include the files of videos tree.
        /// </summary>
        /// <value>
        ///   <c>true</c> if include the files of videos  tree; otherwise, <c>false</c>.
        /// </value>
        public bool IncludeVideos { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to include files tree.
        /// </summary>
        /// <value>
        ///   <c>true</c> if include files tree; otherwise, <c>false</c>.
        /// </value>
        public bool IncludeFilesTree { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to include the files of files tree.
        /// </summary>
        /// <value>
        ///   <c>true</c> if include the files of files tree; otherwise, <c>false</c>.
        /// </value>
        public bool IncludeFiles { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to include archived medias to response.
        /// </summary>
        /// <value>
        ///   <c>true</c> if to include archived items to response; otherwise, <c>false</c>.
        /// </value>
        public bool IncludeArchived { get; set; }
    }
}