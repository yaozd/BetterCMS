﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18449
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BetterCms.Module.Pages.Views.Filter
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    
    #line 1 "..\..\Views\Filter\PagesFilterTemplate.cshtml"
    using BetterCms.Module.Pages.Content.Resources;
    
    #line default
    #line hidden
    
    #line 2 "..\..\Views\Filter\PagesFilterTemplate.cshtml"
    using BetterCms.Module.Root.Content.Resources;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Filter/PagesFilterTemplate.cshtml")]
    public partial class PagesFilterTemplate : System.Web.Mvc.WebViewPage<BetterCms.Module.Pages.ViewModels.Filter.PagesGridViewModel<BetterCms.Module.Pages.ViewModels.SiteSettings.SiteSettingPageViewModel>>
    {
        public PagesFilterTemplate()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

WriteLiteral("    <div");

WriteLiteral(" id=\"bcms-filter-template\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 7 "..\..\Views\Filter\PagesFilterTemplate.cshtml"
   Write(Html.HiddenFor(m => m.ContentId));

            
            #line default
            #line hidden
WriteLiteral("\r\n        <div");

WriteLiteral(" class=\"bcms-grid-filtering\"");

WriteLiteral(" data-bind=\"css: { \'bcms-active-filter\': isVisible() }\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"bcms-filterbox\"");

WriteLiteral(" data-bind=\"click: toggleFilter\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 10 "..\..\Views\Filter\PagesFilterTemplate.cshtml"
           Write(PagesGlobalization.SiteSettings_Pages_Filter);

            
            #line default
            #line hidden
WriteLiteral("\r\n                <div");

WriteLiteral(" class=\"bcms-filter-modified\"");

WriteLiteral(" data-bind=\"style: { display: isEdited() ? \'inline-block\' : \'none\' }\"");

WriteLiteral(">");

            
            #line 11 "..\..\Views\Filter\PagesFilterTemplate.cshtml"
                                                                                                                  Write(PagesGlobalization.SiteSettings_Pages_FilterIsModified);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n            </div>\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"bcms-tags-block\"");

WriteLiteral(" style=\"display: none;\"");

WriteLiteral(" data-bind=\"visible: isVisible(), enterPress: searchWithFilter\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"bcms-featured-tags\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"bcms-clearfix\"");

WriteLiteral(">\r\n\r\n                    <div");

WriteLiteral(" class=\"bcms-filter-options\"");

WriteLiteral(" data-bind=\"with: tags\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"bcms-filter-text\"");

WriteLiteral(">");

            
            #line 19 "..\..\Views\Filter\PagesFilterTemplate.cshtml"
                                                 Write(PagesGlobalization.SiteSettings_Pages_FilterByTags);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                        <div");

WriteLiteral(" class=\"bcms-filter-field-holder\"");

WriteLiteral(">\r\n                            <input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" class=\"bcms-add-tags-field\"");

WriteLiteral(@" data-bind=""
                            css: { 'bcms-tag-validation-error': newItem.hasError() },
                            value: newItem,
                            valueUpdate: 'afterkeydown',
                            escPress: clearItem,
                            autocompleteList: 'onlyExisting'""");

WriteLiteral(" />\r\n                            <!-- ko if: newItem.hasError()  -->\r\n           " +
"                 <span");

WriteLiteral(" class=\"bcms-tag-field-validation-error\"");

WriteLiteral(">\r\n                                <span");

WriteLiteral(" data-bind=\"text: newItem.validationMessage()\"");

WriteLiteral("></span>\r\n                            </span>\r\n                            <!-- /" +
"ko -->\r\n                        </div>\r\n                    </div>\r\n\r\n          " +
"          <div");

WriteLiteral(" class=\"bcms-filter-options\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"bcms-filter-text\"");

WriteLiteral(">");

            
            #line 36 "..\..\Views\Filter\PagesFilterTemplate.cshtml"
                                                 Write(PagesGlobalization.SiteSettings_Pages_FilterByCategory);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                        <select");

WriteLiteral(" class=\"bcms-global-select\"");

WriteLiteral(" name=\"CategoryId\"");

WriteLiteral(" data-bind=\"options: categories, value: categoryId, optionsText: \'Value\', options" +
"Value: \'Key\'\"");

WriteLiteral(" />\r\n                    </div>\r\n\r\n");

            
            #line 40 "..\..\Views\Filter\PagesFilterTemplate.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 40 "..\..\Views\Filter\PagesFilterTemplate.cshtml"
                     if (Model.Languages != null && Model.Languages.Any())
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <div");

WriteLiteral(" class=\"bcms-filter-options\"");

WriteLiteral(">\r\n                            <div");

WriteLiteral(" class=\"bcms-filter-text\"");

WriteLiteral(">");

            
            #line 43 "..\..\Views\Filter\PagesFilterTemplate.cshtml"
                                                     Write(PagesGlobalization.SiteSettings_Pages_FilterByLanguage);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                            <select");

WriteLiteral(" class=\"bcms-global-select\"");

WriteLiteral(" name=\"LanguageId\"");

WriteLiteral(" data-bind=\"options: languages, value: languageId, optionsText: \'Value\', optionsV" +
"alue: \'Key\'\"");

WriteLiteral(" />\r\n                        </div>\r\n");

            
            #line 46 "..\..\Views\Filter\PagesFilterTemplate.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("\r\n                    <div");

WriteLiteral(" class=\"bcms-filter-options\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"bcms-filter-text\"");

WriteLiteral(">");

            
            #line 49 "..\..\Views\Filter\PagesFilterTemplate.cshtml"
                                                 Write(PagesGlobalization.SiteSettings_Pages_FilterByStatus);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

WriteLiteral("                        ");

            
            #line 50 "..\..\Views\Filter\PagesFilterTemplate.cshtml"
                   Write(Html.DropDownListFor(m => m.Status, new List<SelectListItem>(), new
                                                                      {
                                                                          data_bind = "options: statuses, value: status, optionsText: 'Value', optionsValue: 'Key'",
                                                                          @class = "bcms-global-select"
                                                                      }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </div>\r\n\r\n                    <div");

WriteLiteral(" class=\"bcms-filter-options\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"bcms-filter-text\"");

WriteLiteral(">");

            
            #line 58 "..\..\Views\Filter\PagesFilterTemplate.cshtml"
                                                 Write(PagesGlobalization.SiteSettings_Pages_FilterBySEO);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

WriteLiteral("                        ");

            
            #line 59 "..\..\Views\Filter\PagesFilterTemplate.cshtml"
                   Write(Html.DropDownListFor(m => m.SeoStatus, new List<SelectListItem>(), new
                                                                                            {
                                                                                                data_bind = "options: seoStatuses, value: seoStatus, optionsText: 'Value', optionsValue: 'Key'",
                                                                                                @class = "bcms-global-select"
                                                                                            }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </div>\r\n                    \r\n                    <div");

WriteLiteral(" class=\"bcms-filter-options\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"bcms-filter-text\"");

WriteLiteral(">");

            
            #line 67 "..\..\Views\Filter\PagesFilterTemplate.cshtml"
                                                 Write(PagesGlobalization.SiteSettings_Pages_FilterByLayout);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

WriteLiteral("                        ");

            
            #line 68 "..\..\Views\Filter\PagesFilterTemplate.cshtml"
                   Write(Html.DropDownListFor(m => m.Layout, new List<SelectListItem>(), new
                                                                      {
                                                                          data_bind = "options: layouts, value: layout, optionsText: 'Value', optionsValue: 'Key'",
                                                                          @class = "bcms-global-select"
                                                                      }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </div>\r\n\r\n                </div>\r\n\r\n                <div");

WriteLiteral(" class=\"bcms-single-tag-holder\"");

WriteLiteral(" data-bind=\"foreach: tags.items()\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"bcms-single-tag\"");

WriteLiteral(" data-bind=\"css: { \'bcms-single-tag-active\': isActive() }\"");

WriteLiteral(">\r\n                        <span");

WriteLiteral(" data-bind=\"text: name()\"");

WriteLiteral("></span><a");

WriteLiteral(" data-bind=\"    click: remove\"");

WriteLiteral(">");

            
            #line 79 "..\..\Views\Filter\PagesFilterTemplate.cshtml"
                                                                                          Write(RootGlobalization.Button_Remove);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n                    </div>\r\n                    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-bind=\"attr: { name: getItemInputName($index()) + \'.Key\', value: id() }\"");

WriteLiteral(" />\r\n                    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-bind=\"attr: { name: getItemInputName($index()) + \'.Value\', value: name() }\"" +
"");

WriteLiteral(" />\r\n                </div>\r\n\r\n            </div>\r\n\r\n            <div");

WriteLiteral(" class=\"bcms-clearfix\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"bcms-check-field-holder\"");

WriteLiteral(" style=\"float: none;\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 89 "..\..\Views\Filter\PagesFilterTemplate.cshtml"
               Write(Html.CheckBoxFor(model => model.IncludeArchived, new { data_bind = "checked: includeArchived" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    <span");

WriteLiteral(" class=\"bcms-pointer\"");

WriteLiteral(" data-bind=\"click: changeIncludeArchived\"");

WriteLiteral(">");

            
            #line 90 "..\..\Views\Filter\PagesFilterTemplate.cshtml"
                                                                                   Write(PagesGlobalization.SiteSettings_Pages_FilterIncludeArchived);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                </div>\r\n");

            
            #line 92 "..\..\Views\Filter\PagesFilterTemplate.cshtml"
                
            
            #line default
            #line hidden
            
            #line 92 "..\..\Views\Filter\PagesFilterTemplate.cshtml"
                 if (!Model.HideMasterPagesFiltering)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <div");

WriteLiteral(" class=\"bcms-check-field-holder\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 95 "..\..\Views\Filter\PagesFilterTemplate.cshtml"
                   Write(Html.CheckBoxFor(model => model.IncludeMasterPages, new { data_bind = "checked: includeMasterPages" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        <span");

WriteLiteral(" class=\"bcms-pointer\"");

WriteLiteral(" data-bind=\"click: changeIncludeMasterPages\"");

WriteLiteral(">");

            
            #line 96 "..\..\Views\Filter\PagesFilterTemplate.cshtml"
                                                                                          Write(PagesGlobalization.SiteSettings_Pages_FilterIncludeMasterPages);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                    </div>\r\n");

            
            #line 98 "..\..\Views\Filter\PagesFilterTemplate.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("\r\n                <div");

WriteLiteral(" class=\"bcms-btn-field-holder\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"bcms-btn-links-small\"");

WriteLiteral(" data-bind=\"click: clearFilter\"");

WriteLiteral(">");

            
            #line 101 "..\..\Views\Filter\PagesFilterTemplate.cshtml"
                                                                                Write(PagesGlobalization.SiteSettings_Pages_FilterClear);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                    <div");

WriteLiteral(" class=\"bcms-btn-small\"");

WriteLiteral(" data-bind=\"click: searchWithFilter\"");

WriteLiteral(">");

            
            #line 102 "..\..\Views\Filter\PagesFilterTemplate.cshtml"
                                                                               Write(PagesGlobalization.SiteSettings_Pages_FilterSearch);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");

        }
    }
}
#pragma warning restore 1591