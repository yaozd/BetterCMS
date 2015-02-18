﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
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
    
    #line 1 "..\..\Views\Category\CategoryTreeEdit.cshtml"
    using BetterCms.Module.Root;
    
    #line default
    #line hidden
    
    #line 2 "..\..\Views\Category\CategoryTreeEdit.cshtml"
    using BetterCms.Module.Root.Content.Resources;
    
    #line default
    #line hidden
    
    #line 3 "..\..\Views\Category\CategoryTreeEdit.cshtml"
    using BetterCms.Module.Root.Controllers;
    
    #line default
    #line hidden
    
    #line 4 "..\..\Views\Category\CategoryTreeEdit.cshtml"
    using BetterCms.Module.Root.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 5 "..\..\Views\Category\CategoryTreeEdit.cshtml"
    using BetterCms.Module.Root.ViewModels.Category;
    
    #line default
    #line hidden
    
    #line 6 "..\..\Views\Category\CategoryTreeEdit.cshtml"
    using Microsoft.Web.Mvc;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Category/CategoryTreeEdit.cshtml")]
    public partial class _Views_Category_CategoryTreeEdit_cshtml : System.Web.Mvc.WebViewPage<CategoryTreeViewModel>
    {
        public _Views_Category_CategoryTreeEdit_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("<div");

WriteLiteral(" class=\"bcms-tab-header\"");

WriteLiteral(">\r\n    <a");

WriteLiteral(" class=\"bcms-tab bcms-tab-active\"");

WriteLiteral(" data-name=\"#bcms-tab-1\"");

WriteLiteral(">");

            
            #line 9 "..\..\Views\Category\CategoryTreeEdit.cshtml"
                                                           Write(RootGlobalization.CategoryTree_EditDialog_PropertiesTab_Title);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n    <a");

WriteLiteral(" class=\"bcms-tab\"");

WriteLiteral(" data-name=\"#bcms-tab-2\"");

WriteLiteral(">");

            
            #line 10 "..\..\Views\Category\CategoryTreeEdit.cshtml"
                                           Write(RootGlobalization.CategoryTree_EditDialog_NodesTab_Title);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n</div>\r\n<div");

WriteLiteral(" id=\"bcms-categorytree-addnode\"");

WriteLiteral(">\r\n");

WriteLiteral("    ");

            
            #line 13 "..\..\Views\Category\CategoryTreeEdit.cshtml"
Write(Html.TabbedContentMessagesBox());

            
            #line default
            #line hidden
WriteLiteral("\r\n    ");

WriteLiteral("\r\n");

            
            #line 15 "..\..\Views\Category\CategoryTreeEdit.cshtml"
    
            
            #line default
            #line hidden
            
            #line 15 "..\..\Views\Category\CategoryTreeEdit.cshtml"
     using (Html.BeginForm<CategoryController>(f => f.EditCategoryTree(null), FormMethod.Post, new
        {
            @class = "bcms-categorytree-form bcms-ajax-form",
            data_readonly = Model.IsReadOnly.ToString().ToLower()
        }))
    {

            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" id=\"bcms-tab-1\"");

WriteLiteral(" class=\"bcms-tab-single\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"bcms-padded-content\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"bcms-input-list-holder\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 24 "..\..\Views\Category\CategoryTreeEdit.cshtml"
               Write(Html.Tooltip(RootGlobalization.CategoryTree_EditDialog_Title_Tooltip_Description));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    <div");

WriteLiteral(" class=\"bcms-content-titles\"");

WriteLiteral(">");

            
            #line 25 "..\..\Views\Category\CategoryTreeEdit.cshtml"
                                                Write(RootGlobalization.CategoryTree_EditDialog_Title_Title);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                    <div");

WriteLiteral(" class=\"bcms-input-box\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 27 "..\..\Views\Category\CategoryTreeEdit.cshtml"
                   Write(Html.TextBoxFor(model => model.Title, new { @class = "bcms-editor-field-box", data_bind = "value: title, valueUpdate: 'afterkeydown', hasfocus: true" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                        ");

            
            #line 28 "..\..\Views\Category\CategoryTreeEdit.cshtml"
                   Write(Html.BcmsValidationMessageFor(f => f.Title));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                        ");

            
            #line 29 "..\..\Views\Category\CategoryTreeEdit.cshtml"
                   Write(Html.HiddenFor(m => m.Id));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                        ");

            
            #line 30 "..\..\Views\Category\CategoryTreeEdit.cshtml"
                   Write(Html.HiddenFor(m => m.Version));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div");

WriteLiteral(" class=\"bcms-input-list-holder\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 34 "..\..\Views\Category\CategoryTreeEdit.cshtml"
               Write(Html.Tooltip(RootGlobalization.CategoryTree_EditDialog_UsedFor_Tooltip_Description));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    <div");

WriteLiteral(" class=\"bcms-content-titles\"");

WriteLiteral(">");

            
            #line 35 "..\..\Views\Category\CategoryTreeEdit.cshtml"
                                                Write(RootGlobalization.CategoryTree_EditDialog_UsedFor_Title);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                    <!-- ko foreach: categorizableItems -->\r\n            " +
"        <div");

WriteLiteral(" class=\"bcms-checkbox-holder\"");

WriteLiteral(">\r\n                        <input");

WriteLiteral(" type=\"checkbox\"");

WriteLiteral(" data-bind=\"checked: isSelected\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"bcms-edit-label\"");

WriteLiteral(" data-bind=\"text: name, click: inverseSelection\"");

WriteLiteral("></div>\r\n                    </div>\r\n                    <!-- /ko -->\r\n          " +
"      </div>\r\n");

            
            #line 43 "..\..\Views\Category\CategoryTreeEdit.cshtml"
                
            
            #line default
            #line hidden
            
            #line 43 "..\..\Views\Category\CategoryTreeEdit.cshtml"
                 if (Model.ShowMacros)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <div");

WriteLiteral(" class=\"bcms-input-list-holder\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 46 "..\..\Views\Category\CategoryTreeEdit.cshtml"
                   Write(Html.Tooltip(RootGlobalization.CategoryTree_EditDialog_Macro_Tooltip_Message));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        <div");

WriteLiteral(" class=\"bcms-content-titles\"");

WriteLiteral(">");

            
            #line 47 "..\..\Views\Category\CategoryTreeEdit.cshtml"
                                                    Write(RootGlobalization.CategoryTree_EditDialog_Macro_Title);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                        <div");

WriteLiteral(" class=\"bcms-input-box\"");

WriteLiteral(">\r\n");

WriteLiteral("                            ");

            
            #line 49 "..\..\Views\Category\CategoryTreeEdit.cshtml"
                       Write(Html.TextBoxFor(model => model.Macro, new
                       {
                           @class = "bcms-editor-field-box",
                           placeholder = RootGlobalization.CategoryTree_Macro_Placeholder_Message,
                           data_bind = "value: macro, valueUpdate: 'afterkeydown', hasfocus: true"
                       }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                            ");

            
            #line 55 "..\..\Views\Category\CategoryTreeEdit.cshtml"
                       Write(Html.BcmsValidationMessageFor(m => m.Macro));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n");

            
            #line 58 "..\..\Views\Category\CategoryTreeEdit.cshtml"
                }
                
            
            #line default
            #line hidden
            
            #line 59 "..\..\Views\Category\CategoryTreeEdit.cshtml"
                                                                    
                
            
            #line default
            #line hidden
            
            #line 60 "..\..\Views\Category\CategoryTreeEdit.cshtml"
                                     
                
            
            #line default
            #line hidden
            
            #line 61 "..\..\Views\Category\CategoryTreeEdit.cshtml"
                                                                                                
                
            
            #line default
            #line hidden
            
            #line 62 "..\..\Views\Category\CategoryTreeEdit.cshtml"
                                     

            
            #line default
            #line hidden
WriteLiteral("            </div>\r\n        </div>\r\n");

WriteLiteral("        <div");

WriteLiteral(" id=\"bcms-tab-2\"");

WriteLiteral(" class=\"bcms-tab-single\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"bcms-scroll-window\"");

WriteLiteral(">\r\n\r\n                <div");

WriteLiteral(" class=\"bcms-columns-container\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"bcms-sitemap-filter-holder\"");

WriteLiteral(">\r\n                        ");

WriteLiteral("\r\n                        ");

WriteLiteral("\r\n                        ");

WriteLiteral("\r\n                        ");

WriteLiteral("\r\n                        ");

WriteLiteral("\r\n                        ");

WriteLiteral("\r\n                        <div");

WriteLiteral(" class=\"bcms-language-bar\"");

WriteLiteral(">\r\n                            <div");

WriteLiteral(" class=\"bcms-filter-text bcms-table-middle-box bcms-btn-links-main\"");

WriteLiteral(" data-bind=\"click: addNewNode\"");

WriteLiteral(">Add New +</div>\r\n                        </div>\r\n\r\n                        <div");

WriteLiteral(" class=\"bcms-expand-link-holder\"");

WriteLiteral(" ");

WriteLiteral(">\r\n                            <div");

WriteLiteral(" class=\"bcms-expand-link\"");

WriteLiteral(" data-bind=\"click: expandAll\"");

WriteLiteral(">");

            
            #line 81 "..\..\Views\Category\CategoryTreeEdit.cshtml"
                                                                                  Write(RootGlobalization.CategoryTree_Button_ExpandAll);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                            <div");

WriteLiteral(" class=\"bcms-expand-link\"");

WriteLiteral(" data-bind=\"click: collapseAll\"");

WriteLiteral(">");

            
            #line 82 "..\..\Views\Category\CategoryTreeEdit.cshtml"
                                                                                    Write(RootGlobalization.CategoryTree_Button_CollapseAll);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                        </div>\r\n                    </div>\r\n\r\n           " +
"         <div");

WriteLiteral(" class=\"bcms-rightcol\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"bcms-sitemap-holder bcms-sitemap-edit\"");

WriteLiteral(">\r\n                            <div");

WriteAttribute("class", Tuple.Create(" class=\"", 5518), Tuple.Create("\"", 5603)
, Tuple.Create(Tuple.Create("", 5526), Tuple.Create("bcms-addnode-placement-holder", 5526), true)
            
            #line 88 "..\..\Views\Category\CategoryTreeEdit.cshtml"
, Tuple.Create(Tuple.Create("", 5555), Tuple.Create<System.Object, System.Int32>(Model.IsReadOnly ? "-readonly" : string.Empty
            
            #line default
            #line hidden
, 5555), false)
);

WriteLiteral(">\r\n");

WriteLiteral("                                ");

            
            #line 89 "..\..\Views\Category\CategoryTreeEdit.cshtml"
                           Write(Html.Partial("Partial/CategoryTree", new CategoryTreeNodeViewModel()));

            
            #line default
            #line hidden
WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n           " +
"         </div>\r\n                </div>\r\n\r\n            </div>\r\n        </div>\r\n");

            
            #line 97 "..\..\Views\Category\CategoryTreeEdit.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

            
            #line 99 "..\..\Views\Category\CategoryTreeEdit.cshtml"
Write(Html.Partial("Partial/CategoryTreeTemplate", new CategoryTreeNodeViewModel()));

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591