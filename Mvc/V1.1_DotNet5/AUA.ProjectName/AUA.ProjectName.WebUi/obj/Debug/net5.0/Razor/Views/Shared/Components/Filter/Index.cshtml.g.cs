#pragma checksum "F:\GitRepos2\auarelease\MVC\V1.1\4_AddAUACore\AUA.ProjectName\AUA.ProjectName.WebUI\Views\Shared\Components\Filter\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a6bbb3b293e54a1b4fd609f6e30c6df8027aaf54"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Filter_Index), @"mvc.1.0.view", @"/Views/Shared/Components/Filter/Index.cshtml")]
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
#nullable restore
#line 1 "F:\GitRepos2\auarelease\MVC\V1.1\4_AddAUACore\AUA.ProjectName\AUA.ProjectName.WebUI\Views\_ViewImports.cshtml"
using AUA.ProjectName.WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\GitRepos2\auarelease\MVC\V1.1\4_AddAUACore\AUA.ProjectName\AUA.ProjectName.WebUI\Views\_ViewImports.cshtml"
using AUA.ProjectName.Common.Consts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\GitRepos2\auarelease\MVC\V1.1\4_AddAUACore\AUA.ProjectName\AUA.ProjectName.WebUI\Views\_ViewImports.cshtml"
using AUA.ProjectName.Models.BaseModel.BaseViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "F:\GitRepos2\auarelease\MVC\V1.1\4_AddAUACore\AUA.ProjectName\AUA.ProjectName.WebUI\Views\Shared\Components\_ViewImports.cshtml"
using AUA.ProjectName.Models.ViewModels.BaseViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\GitRepos2\auarelease\MVC\V1.1\4_AddAUACore\AUA.ProjectName\AUA.ProjectName.WebUI\Views\Shared\Components\_ViewImports.cshtml"
using AUA.ProjectName.Common.Extensions;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a6bbb3b293e54a1b4fd609f6e30c6df8027aaf54", @"/Views/Shared/Components/Filter/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ecd20c5cdc8433efb4c0aaffe0eff514ba9ef8b", @"/Views/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be3433f8630e9d71b9530ef9a7fc255f3d5fd313", @"/Views/Shared/Components/_ViewImports.cshtml")]
    public class Views_Shared_Components_Filter_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FilterFormVm>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""card"">
    <h6 class=""card-header"">
        <a class=""d-block"" data-toggle=""collapse"" href=""#collapse-collapsed"" aria-expanded=""true"" aria-controls=""collapse-collapsed"" id=""heading-collapsed"">
            <i class=""fa fa-chevron-down pull-right""></i>
            ");
#nullable restore
#line 6 "F:\GitRepos2\auarelease\MVC\V1.1\4_AddAUACore\AUA.ProjectName\AUA.ProjectName.WebUI\Views\Shared\Components\Filter\Index.cshtml"
       Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </a>\r\n    </h6>\r\n    <div id=\"collapse-collapsed\" class=\"collapse show\" aria-labelledby=\"heading-collapsed\">\r\n        <div class=\"card-body\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a6bbb3b293e54a1b4fd609f6e30c6df8027aaf545115", async() => {
                WriteLiteral("\r\n                ");
#nullable restore
#line 12 "F:\GitRepos2\auarelease\MVC\V1.1\4_AddAUACore\AUA.ProjectName\AUA.ProjectName.WebUI\Views\Shared\Components\Filter\Index.cshtml"
           Write(Model.ViewContent.DynamicInvoke(ViewContext));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                <div class=\"p-1\">\r\n                    <button type=\"submit\" class=\"btn btn-warning btn-sm\">");
#nullable restore
#line 14 "F:\GitRepos2\auarelease\MVC\V1.1\4_AddAUACore\AUA.ProjectName\AUA.ProjectName.WebUI\Views\Shared\Components\Filter\Index.cshtml"
                                                                    Write(Model.BtnTitle);

#line default
#line hidden
#nullable disable
                WriteLiteral("</button>\r\n                </div>\r\n\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 11 "F:\GitRepos2\auarelease\MVC\V1.1\4_AddAUACore\AUA.ProjectName\AUA.ProjectName.WebUI\Views\Shared\Components\Filter\Index.cshtml"
                  WriteLiteral(Model.ActionName);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-action", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FilterFormVm> Html { get; private set; }
    }
}
#pragma warning restore 1591
