﻿using BetterCms.Core.Mvc.Commands;
using BetterCms.Module.Pages.Services;
using BetterCms.Module.Pages.ViewModels.Sitemap;
using BetterCms.Module.Root.Mvc;

namespace BetterCms.Module.Pages.Command.Sitemap.SaveSitemapNode
{
    /// <summary>
    /// Saves sitemap node data.
    /// </summary>
    public class SaveSitemapNodeCommand : CommandBase, ICommand<SitemapNodeViewModel, SitemapNodeViewModel>
    {
        /// <summary>
        /// Gets or sets the sitemap service.
        /// </summary>
        /// <value>
        /// The sitemap service.
        /// </value>
        public ISitemapService SitemapService { get; set; }

        /// <summary>
        /// Executes the specified request.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>Execution result.</returns>
        public SitemapNodeViewModel Execute(SitemapNodeViewModel request)
        {
            UnitOfWork.BeginTransaction();

            // TODO: demand write access to sitemap.
            if (!request.SitemapId.HasDefaultValue())
            {
                SitemapService.ArchiveSitemap(request.SitemapId);
            }

            var node = SitemapService.SaveNode(Repository.AsProxy<Models.Sitemap>(request.SitemapId), request.Id, request.Version, request.Url, request.Title, request.PageId, request.DisplayOrder, request.ParentId);

            UnitOfWork.Commit();

            if (request.Id.HasDefaultValue())
            {
                Events.SitemapEvents.Instance.OnSitemapNodeCreated(node);
            }
            else
            {
                Events.SitemapEvents.Instance.OnSitemapNodeUpdated(node);
            }

            Events.SitemapEvents.Instance.OnSitemapUpdated(node.Sitemap);

            return new SitemapNodeViewModel
                {
                    Id = node.Id,
                    Version = node.Version
                };
        }
    }
}