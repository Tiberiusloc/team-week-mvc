#pragma checksum "/Users/peckii/Desktop/ForageMvc/ForageMvc/Views/Users/Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "243ed016cc5da704247fe4445c17f606b1644a25"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_Register), @"mvc.1.0.view", @"/Views/Users/Register.cshtml")]
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
#line 5 "/Users/peckii/Desktop/ForageMvc/ForageMvc/Views/Users/Register.cshtml"
using ForageMvc.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"243ed016cc5da704247fe4445c17f606b1644a25", @"/Views/Users/Register.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"40ea02e49d09b87f45804e478cbd7b45230b36a6", @"/Views/_ViewImports.cshtml")]
    public class Views_Users_Register : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RegisterViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/peckii/Desktop/ForageMvc/ForageMvc/Views/Users/Register.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("\n");
            WriteLiteral("<h3>Register New User</h3>\n<hr />\n");
#nullable restore
#line 10 "/Users/peckii/Desktop/ForageMvc/ForageMvc/Views/Users/Register.cshtml"
 using (Html.BeginForm("Register", "Users", FormMethod.Post))
{
  

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/Users/peckii/Desktop/ForageMvc/ForageMvc/Views/Users/Register.cshtml"
Write(Html.LabelFor(user => user.Email));

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "/Users/peckii/Desktop/ForageMvc/ForageMvc/Views/Users/Register.cshtml"
Write(Html.TextBoxFor(user => user.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br>\n");
#nullable restore
#line 15 "/Users/peckii/Desktop/ForageMvc/ForageMvc/Views/Users/Register.cshtml"
Write(Html.LabelFor(user => user.Password));

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "/Users/peckii/Desktop/ForageMvc/ForageMvc/Views/Users/Register.cshtml"
Write(Html.PasswordFor(user => user.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br>\n");
#nullable restore
#line 18 "/Users/peckii/Desktop/ForageMvc/ForageMvc/Views/Users/Register.cshtml"
Write(Html.LabelFor(user => user.ConfirmPassword));

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "/Users/peckii/Desktop/ForageMvc/ForageMvc/Views/Users/Register.cshtml"
Write(Html.PasswordFor(user => user.ConfirmPassword));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br>\n  <input type=\"submit\" value=\"Register\" />\n");
#nullable restore
#line 22 "/Users/peckii/Desktop/ForageMvc/ForageMvc/Views/Users/Register.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RegisterViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
