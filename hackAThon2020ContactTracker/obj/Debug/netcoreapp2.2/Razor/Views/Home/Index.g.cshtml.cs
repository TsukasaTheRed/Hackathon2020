#pragma checksum "C:\Users\Tsuka\Desktop\WozU\projects\practice\Hackathon2020\hackAThon2020ContactTracker\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "291223773703956320c98b85675ba4c366516db9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\Tsuka\Desktop\WozU\projects\practice\Hackathon2020\hackAThon2020ContactTracker\Views\_ViewImports.cshtml"
using hackAThon2020ContactTracker;

#line default
#line hidden
#line 2 "C:\Users\Tsuka\Desktop\WozU\projects\practice\Hackathon2020\hackAThon2020ContactTracker\Views\_ViewImports.cshtml"
using hackAThon2020ContactTracker.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"291223773703956320c98b85675ba4c366516db9", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"02cbbe0b4a85164977a6d13cf00cb75c055fcd01", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 229, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n    <!-- THIS IS THE FIRST DRAFT, FOREVER TO LEFT HERE IN THE VOID. IT SERVED A GOOD PURPOSE, AND FOR THAT REASON IT SHALL BE FOREVER PRESERVED HERE, IN AN INBETWEEN ACCESSIBLE ONLY TO THE NOSEY -->\r\n    ");
            EndContext();
            BeginContext(229, 83, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "291223773703956320c98b85675ba4c366516db93965", async() => {
                BeginContext(235, 70, true);
                WriteLiteral("\r\n        <title>New York State COVID-19 Contact Tracker</title>\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(312, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(318, 3068, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "291223773703956320c98b85675ba4c366516db95222", async() => {
                BeginContext(324, 884, true);
                WriteLiteral(@"
        <nav id=""navbar"">
            <ul id=""navList"">
                <li><a href=""#"">Helpful Sources</a>
                    <ul class=""dropdown"" id=""sources"">
                        <li><a href=""https://www.mayoclinic.org/diseases-conditions/coronavirus/symptoms-causes/syc-20479963"">Mayo Clinic</a></li>
                        <li><a href=""https://coronavirus.health.ny.gov/protect-yourself-and-your-family-coronavirus-covid-19"">NYS Department of Health</a></li>
                        <li><a href=""https://www.cdc.gov/coronavirus/2019-ncov/index.html"">Centers for Disease Control and Prevention</a></li>
                        <li><a href=""https://www.nih.gov/health-information/coronavirus"">National Institute of Health</a></li>
                    </ul>
                </li>    
            </ul>
        </nav>
        <div class=""container"">
            ");
                EndContext();
                BeginContext(1208, 1295, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "291223773703956320c98b85675ba4c366516db96509", async() => {
                    BeginContext(1214, 1282, true);
                    WriteLiteral(@"
                <label for=""firstName"">First Name: </label>
                    <input type=""text"" id=""firstName"" />
                <label for=""relation"">Relation: </label>
                    <input type=""text"" id=""relation"" />
                <label for=""date"">Date: </label> 
                    <input type=""date"" id=""date"" placeholder=""dd/mm/yyyy"" />
                <h3>Time of the Day</h3>    
                <input type=""radio"" id=""am"" name=""amPM"" /> 
                    <label for=""am"">A.M.</label>
                <input type=""radio"" id=""pm"" name=""amPM"" />
                    <label for=""pm"">P.M.</label><br>
                <input type=""radio"" id=""range1"" name=""time"" />
                    <label for=""range1"">12:00-3:00</label><br>       
                <input type=""radio"" id=""range2"" name=""time"" />
                    <label for=""range2"">3:00-6:00</label><br>
                <input type=""radio"" id=""range3"" name=""time"" />
                    <label for=""range3"">6:00-9:00</label><br> ");
                    WriteLiteral(@"       
                <input type=""radio"" id=""range4"" name=""time"" />
                    <label for=""range4"">9:00-12:00</label>    
                location
                livingWith
                showingSymptoms        
            
            ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2503, 876, true);
                WriteLiteral(@"
        </div>
        <!--Symptoms Lists-->
        <div class=""row"" style="" text-align: left"" id=""commonSymptoms"">
            <ul> 
                <p>Common Symptoms:</p>
                <li>Fever</li>
                <li>Cough</li>
                <li>Shortness of Breath</li>
            </ul>
            <ul> 
                <p>Other Symptoms are:</p>
                <li>Chills</li>
                <li>Repeated Shaking</li>
                <li>Muscle Pain</li>
                <li>Headache</li>
                <li>Sore Throat</li>
                <li>New loss of taste or smell</li>
                <li>Fatigue </li>
                <li>Diarrhea</li>
                <li>Vomiting</li>
                <li>Experience confusion or trouble waking up</li>
                <li>Bluish lips or face</li>
            </ul>
        </div>    
    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3386, 9, true);
            WriteLiteral("\r\n</html>");
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
