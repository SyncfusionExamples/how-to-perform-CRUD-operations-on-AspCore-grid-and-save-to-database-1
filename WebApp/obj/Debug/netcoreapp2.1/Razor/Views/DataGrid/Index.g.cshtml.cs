#pragma checksum "C:\Users\DhivyaRajendran\source\repos\WebApp\WebApp\Views\DataGrid\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2d9ad0a69e34a453b168cb52639edbbba321c9e0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DataGrid_Index), @"mvc.1.0.view", @"/Views/DataGrid/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/DataGrid/Index.cshtml", typeof(AspNetCore.Views_DataGrid_Index))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\DhivyaRajendran\source\repos\WebApp\WebApp\Views\_ViewImports.cshtml"
using WebApp;

#line default
#line hidden
#line 2 "C:\Users\DhivyaRajendran\source\repos\WebApp\WebApp\Views\_ViewImports.cshtml"
using WebApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d9ad0a69e34a453b168cb52639edbbba321c9e0", @"/Views/DataGrid/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6801eda217975cc5cdc0751d9aa9c0d764a9fd20", @"/Views/_ViewImports.cshtml")]
    public class Views_DataGrid_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("url", "/DataGrid/UrlDataSource", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("adaptor", "UrlAdaptor", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("insertUrl", "/DataGrid/Insert", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("updateUrl", "/DataGrid/Update", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("removeUrl", "/DataGrid/Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("field", "OrderID", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("headerText", "OrderID", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("field", "CustomerID", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("headerText", "CustomerID", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", "Grid", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", "272", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Syncfusion.EJ2.Grids.Grid __Syncfusion_EJ2_Grids_Grid;
        private global::Syncfusion.EJ2.DataManager __Syncfusion_EJ2_DataManager;
        private global::Syncfusion.EJ2.Grids.GridEditSettings __Syncfusion_EJ2_Grids_GridEditSettings;
        private global::Syncfusion.EJ2.Grids.GridColumns __Syncfusion_EJ2_Grids_GridColumns;
        private global::Syncfusion.EJ2.Grids.GridColumn __Syncfusion_EJ2_Grids_GridColumn;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 720, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ejs-grid", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7876f569e74e42e7925ddbba389e644e", async() => {
                BeginContext(150, 4, true);
                WriteLiteral("\r\n  ");
                EndContext();
                BeginContext(154, 171, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-data-manager", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "53e2bd76e3f843fdaaec41e9dbe6552e", async() => {
                }
                );
                __Syncfusion_EJ2_DataManager = CreateTagHelper<global::Syncfusion.EJ2.DataManager>();
                __tagHelperExecutionContext.Add(__Syncfusion_EJ2_DataManager);
                __Syncfusion_EJ2_DataManager.Url = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Syncfusion_EJ2_DataManager.Adaptor = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Syncfusion_EJ2_DataManager.InsertUrl = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Syncfusion_EJ2_DataManager.UpdateUrl = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Syncfusion_EJ2_DataManager.RemoveUrl = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(325, 4, true);
                WriteLiteral("\r\n  ");
                EndContext();
                BeginContext(329, 117, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-grid-editSettings", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "973908692e8a4752bc7fc9c2335787e2", async() => {
                }
                );
                __Syncfusion_EJ2_Grids_GridEditSettings = CreateTagHelper<global::Syncfusion.EJ2.Grids.GridEditSettings>();
                __tagHelperExecutionContext.Add(__Syncfusion_EJ2_Grids_GridEditSettings);
#line 3 "C:\Users\DhivyaRajendran\source\repos\WebApp\WebApp\Views\DataGrid\Index.cshtml"
__Syncfusion_EJ2_Grids_GridEditSettings.AllowAdding = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("allowAdding", __Syncfusion_EJ2_Grids_GridEditSettings.AllowAdding, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 3 "C:\Users\DhivyaRajendran\source\repos\WebApp\WebApp\Views\DataGrid\Index.cshtml"
__Syncfusion_EJ2_Grids_GridEditSettings.AllowDeleting = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("allowDeleting", __Syncfusion_EJ2_Grids_GridEditSettings.AllowDeleting, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 3 "C:\Users\DhivyaRajendran\source\repos\WebApp\WebApp\Views\DataGrid\Index.cshtml"
__Syncfusion_EJ2_Grids_GridEditSettings.AllowEditing = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("allowEditing", __Syncfusion_EJ2_Grids_GridEditSettings.AllowEditing, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 3 "C:\Users\DhivyaRajendran\source\repos\WebApp\WebApp\Views\DataGrid\Index.cshtml"
__Syncfusion_EJ2_Grids_GridEditSettings.Mode = global::Syncfusion.EJ2.Grids.EditMode.Normal;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("mode", __Syncfusion_EJ2_Grids_GridEditSettings.Mode, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(446, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(452, 255, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-grid-columns", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f89d945545a749c0a2bd33ebb9391477", async() => {
                    BeginContext(468, 10, true);
                    WriteLiteral("\r\n        ");
                    EndContext();
                    BeginContext(478, 122, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-grid-column", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bcbb4d72b73f49c4b007524c0e636915", async() => {
                    }
                    );
                    __Syncfusion_EJ2_Grids_GridColumn = CreateTagHelper<global::Syncfusion.EJ2.Grids.GridColumn>();
                    __tagHelperExecutionContext.Add(__Syncfusion_EJ2_Grids_GridColumn);
                    __Syncfusion_EJ2_Grids_GridColumn.Field = (string)__tagHelperAttribute_5.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                    __Syncfusion_EJ2_Grids_GridColumn.HeaderText = (string)__tagHelperAttribute_6.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
#line 5 "C:\Users\DhivyaRajendran\source\repos\WebApp\WebApp\Views\DataGrid\Index.cshtml"
__Syncfusion_EJ2_Grids_GridColumn.IsIdentity = true;

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("isIdentity", __Syncfusion_EJ2_Grids_GridColumn.IsIdentity, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 5 "C:\Users\DhivyaRajendran\source\repos\WebApp\WebApp\Views\DataGrid\Index.cshtml"
__Syncfusion_EJ2_Grids_GridColumn.DefaultValue = 0;

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("defaultValue", __Syncfusion_EJ2_Grids_GridColumn.DefaultValue, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 5 "C:\Users\DhivyaRajendran\source\repos\WebApp\WebApp\Views\DataGrid\Index.cshtml"
__Syncfusion_EJ2_Grids_GridColumn.IsPrimaryKey = true;

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("isPrimaryKey", __Syncfusion_EJ2_Grids_GridColumn.IsPrimaryKey, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(600, 9, true);
                    WriteLiteral("\r\n       ");
                    EndContext();
                    BeginContext(609, 75, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-grid-column", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "49537222563146699ac02e581e8afab9", async() => {
                    }
                    );
                    __Syncfusion_EJ2_Grids_GridColumn = CreateTagHelper<global::Syncfusion.EJ2.Grids.GridColumn>();
                    __tagHelperExecutionContext.Add(__Syncfusion_EJ2_Grids_GridColumn);
                    __Syncfusion_EJ2_Grids_GridColumn.Field = (string)__tagHelperAttribute_7.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                    __Syncfusion_EJ2_Grids_GridColumn.HeaderText = (string)__tagHelperAttribute_8.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(684, 6, true);
                    WriteLiteral("\r\n    ");
                    EndContext();
                }
                );
                __Syncfusion_EJ2_Grids_GridColumns = CreateTagHelper<global::Syncfusion.EJ2.Grids.GridColumns>();
                __tagHelperExecutionContext.Add(__Syncfusion_EJ2_Grids_GridColumns);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(707, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            __Syncfusion_EJ2_Grids_Grid = CreateTagHelper<global::Syncfusion.EJ2.Grids.Grid>();
            __tagHelperExecutionContext.Add(__Syncfusion_EJ2_Grids_Grid);
            __Syncfusion_EJ2_Grids_Grid.Id = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            __Syncfusion_EJ2_Grids_Grid.Height = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
#line 1 "C:\Users\DhivyaRajendran\source\repos\WebApp\WebApp\Views\DataGrid\Index.cshtml"
__Syncfusion_EJ2_Grids_Grid.AllowPaging = true;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("allowPaging", __Syncfusion_EJ2_Grids_Grid.AllowPaging, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 1 "C:\Users\DhivyaRajendran\source\repos\WebApp\WebApp\Views\DataGrid\Index.cshtml"
__Syncfusion_EJ2_Grids_Grid.AllowSorting = true;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("allowSorting", __Syncfusion_EJ2_Grids_Grid.AllowSorting, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 1 "C:\Users\DhivyaRajendran\source\repos\WebApp\WebApp\Views\DataGrid\Index.cshtml"
__Syncfusion_EJ2_Grids_Grid.Toolbar = (new List<string>() { "Add", "Edit", "Delete","Update","Cancel" });

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("toolbar", __Syncfusion_EJ2_Grids_Grid.Toolbar, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(720, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
