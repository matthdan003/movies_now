#pragma checksum "D:\danie\Desktop\Projects\moviesnow\moviesnow\Views\Home\MovieDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f8b7a5c9037a0a08a5889cdbe08016087a2e0591"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MyApp.Namespace.Home.Views_Home_MovieDetails), @"mvc.1.0.view", @"/Views/Home/MovieDetails.cshtml")]
namespace MyApp.Namespace.Home
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
#line 1 "D:\danie\Desktop\Projects\moviesnow\moviesnow\Views\Home\MovieDetails.cshtml"
using moviesnow.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8b7a5c9037a0a08a5889cdbe08016087a2e0591", @"/Views/Home/MovieDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc1d1eb37dc6f0d82250bf784d7ea6a0b75ca51c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_MovieDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DetailsWrapper>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/moviestyle.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/logo.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("200"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-inline-block align-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("loading", new global::Microsoft.AspNetCore.Html.HtmlString("lazy"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/script/lightslider.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f8b7a5c9037a0a08a5889cdbe08016087a2e05916444", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1, shrink-to-fit=no"">
    <link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css"" integrity=""sha384-JcKb8q3iqJ61gNV9KGb8thSsNjpSL0n8PARn9HuZOnIxN0hoP+VmmDGMN5t9UJ0Z"" crossorigin=""anonymous"">
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f8b7a5c9037a0a08a5889cdbe08016087a2e05917056", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f8b7a5c9037a0a08a5889cdbe08016087a2e05918235", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <title>");
#nullable restore
#line 12 "D:\danie\Desktop\Projects\moviesnow\moviesnow\Views\Home\MovieDetails.cshtml"
      Write(Model.Movie.title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</title>\r\n");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f8b7a5c9037a0a08a5889cdbe08016087a2e059110367", async() => {
                WriteLiteral(@"
    <header class=""header"">
        <div class=""top-bar"">
                
            <div class=""container-fluid"">
            
                <nav class=""navbar navbar-expand-lg navbar-dark position-relative"">
                    <a class=""navbar-brand"" href=""/dashboard"">
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f8b7a5c9037a0a08a5889cdbe08016087a2e059110945", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                    </a>
                    <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#navigation"" aria-controls=""navigation"" aria-expanded=""false"" aria-label=""Toggle navigation"">
                    <span class=""navbar-toggler-icon""></span>
                    </button>
                    
                    <div class=""collapse navbar-collapse"" id=""navigation"">
                        <ul class=""navbar-nav ml-lg-auto"">
                            <li class=""nav-item active mr-lg-3 text-uppercase"">
                                <a class=""nav-link"" href=""/dashboard"">Dashboard</a>
                            </li>
                            <li class=""nav-item mr-lg-3 text-uppercase"">
                                <a class=""nav-link""");
                BeginWriteAttribute("href", " href=\"", 1798, "\"", 1805, 0);
                EndWriteAttribute();
                WriteLiteral(">All Movies</a>\r\n                            </li>\r\n                            <li>\r\n                                <a class=\"nav-link disabled\"");
                BeginWriteAttribute("href", " href=\"", 1952, "\"", 1959, 0);
                EndWriteAttribute();
                WriteLiteral(" aria-disabled=\"true\">Welcome,</a>\r\n                            </li>\r\n                            <li class=\"nav-item dropdown mr-lg-3\">\r\n                                <a class=\"nav-link dropdown-toggle\"");
                BeginWriteAttribute("href", " href=\"", 2166, "\"", 2173, 0);
                EndWriteAttribute();
                WriteLiteral(" id=\"navbarDropdown\" role=\"button\" data-toggle=\"dropdown\" aria-haspopup=\"true\" aria-expanded=\"false\">");
#nullable restore
#line 40 "D:\danie\Desktop\Projects\moviesnow\moviesnow\Views\Home\MovieDetails.cshtml"
                                                                                                                                                                           Write(Model.User.FirstName);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</a>
                                <div class=""dropdown-menu"" aria-labelledby=""navbarDropdown"">
                                    <a class=""dropdown-item"" href=""/EditProfile"">Edit Profile</a>
                                    <a class=""dropdown-item"" href=""/logout"">Logout</a>
                                </div>
                            </li>
                        </ul>
                    </div>
                    
                </nav>
            
            </div>
                
        </div>
    </header>

    <div class=""container-fluid"" id=""movie_banner""");
                BeginWriteAttribute("style", " style=\"", 2898, "\"", 3075, 11);
                WriteAttributeValue("", 2906, "background-image:", 2906, 17, true);
                WriteAttributeValue(" ", 2923, "url(https://image.tmdb.org/t/p/original/", 2924, 41, true);
#nullable restore
#line 56 "D:\danie\Desktop\Projects\moviesnow\moviesnow\Views\Home\MovieDetails.cshtml"
WriteAttributeValue("", 2964, Model.Movie.backdrop_path, 2964, 26, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2990, ");", 2990, 2, true);
                WriteAttributeValue(" ", 2992, "background-repeat:", 2993, 19, true);
                WriteAttributeValue(" ", 3011, "no-repeat;", 3012, 11, true);
                WriteAttributeValue(" ", 3022, "background-size:", 3023, 17, true);
                WriteAttributeValue(" ", 3039, "100%;", 3040, 6, true);
                WriteAttributeValue(" ", 3045, "background-position:", 3046, 21, true);
                WriteAttributeValue(" ", 3066, "50%", 3067, 4, true);
                WriteAttributeValue(" ", 3070, "25%;", 3071, 5, true);
                EndWriteAttribute();
                WriteLiteral(@">
        <div class=""container-fluid py-5"" id=""banner_overlay"">
            <div class=""container text-white"" id=""movie_details"">
                <div class=""movie-teaser media flex-column flex-md-row px-5"">
                    <img class=""movie-image mb-3 mb-md-0 mr-md-5 ml-md-0 rounded mx-auto shadow""");
                BeginWriteAttribute("src", " src=\"", 3385, "\"", 3451, 2);
                WriteAttributeValue("", 3391, "https://image.tmdb.org/t/p/original/", 3391, 36, true);
#nullable restore
#line 60 "D:\danie\Desktop\Projects\moviesnow\moviesnow\Views\Home\MovieDetails.cshtml"
WriteAttributeValue("", 3427, Model.Movie.poster_path, 3427, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 3452, "\"", 3458, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                    <div class=\"movie-body text-center text-md-left my-auto\">\r\n                        <h1 class=\"mt-0 font-weight-bold\">\r\n                            ");
#nullable restore
#line 63 "D:\danie\Desktop\Projects\moviesnow\moviesnow\Views\Home\MovieDetails.cshtml"
                       Write(Model.Movie.title);

#line default
#line hidden
#nullable disable
                WriteLiteral(@" 
                            <span class=""badge badge-primary align-middle"">
                                <svg width=""0.8em"" height=""0.8em"" viewBox=""0 0 16 16"" class=""bi bi-star align-baseline"" fill=""currentColor"" xmlns=""http://www.w3.org/2000/svg"">
                                    <path fill-rule=""evenodd"" d=""M2.866 14.85c-.078.444.36.791.746.593l4.39-2.256 4.389 2.256c.386.198.824-.149.746-.592l-.83-4.73 3.523-3.356c.329-.314.158-.888-.283-.95l-4.898-.696L8.465.792a.513.513 0 0 0-.927 0L5.354 5.12l-4.898.696c-.441.062-.612.636-.283.95l3.523 3.356-.83 4.73zm4.905-2.767l-3.686 1.894.694-3.957a.565.565 0 0 0-.163-.505L1.71 6.745l4.052-.576a.525.525 0 0 0 .393-.288l1.847-3.658 1.846 3.658a.525.525 0 0 0 .393.288l4.052.575-2.906 2.77a.564.564 0 0 0-.163.506l.694 3.957-3.686-1.894a.503.503 0 0 0-.461 0z""/>
                                </svg>
                                ");
#nullable restore
#line 68 "D:\danie\Desktop\Projects\moviesnow\moviesnow\Views\Home\MovieDetails.cshtml"
                           Write(Model.Movie.vote_average);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </span>\r\n                        </h1>\r\n                        <p><span id=\"cert\"></span> ");
#nullable restore
#line 71 "D:\danie\Desktop\Projects\moviesnow\moviesnow\Views\Home\MovieDetails.cshtml"
                                              Write(Model.Movie.release_date);

#line default
#line hidden
#nullable disable
                WriteLiteral(" | ");
#nullable restore
#line 71 "D:\danie\Desktop\Projects\moviesnow\moviesnow\Views\Home\MovieDetails.cshtml"
                                                                          Write(Model.Movie.genres.ElementAt(0).name);

#line default
#line hidden
#nullable disable
                WriteLiteral(" | ");
#nullable restore
#line 71 "D:\danie\Desktop\Projects\moviesnow\moviesnow\Views\Home\MovieDetails.cshtml"
                                                                                                                  Write(Model.Movie.runtime);

#line default
#line hidden
#nullable disable
                WriteLiteral(" Minutes</p>\r\n                        <p class=\"font-weight-light text-uppercase\"><em>");
#nullable restore
#line 72 "D:\danie\Desktop\Projects\moviesnow\moviesnow\Views\Home\MovieDetails.cshtml"
                                                                   Write(Model.Movie.tagline);

#line default
#line hidden
#nullable disable
                WriteLiteral("</em></p>\r\n                        <div class=\"bio mb-3\"><strong>Overview: </strong>");
#nullable restore
#line 73 "D:\danie\Desktop\Projects\moviesnow\moviesnow\Views\Home\MovieDetails.cshtml"
                                                                    Write(Model.Movie.overview);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                        <p><strong>Language: </strong>");
#nullable restore
#line 74 "D:\danie\Desktop\Projects\moviesnow\moviesnow\Views\Home\MovieDetails.cshtml"
                                                 Write(Model.Movie.original_language);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                        <p><strong>Status: </strong>");
#nullable restore
#line 75 "D:\danie\Desktop\Projects\moviesnow\moviesnow\Views\Home\MovieDetails.cshtml"
                                               Write(Model.Movie.status);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                    </div>\r\n                </div>\r\n                \r\n            </div>\r\n        </div>\r\n");
                WriteLiteral("    </div>\r\n\r\n\r\n    <script src=\"https://code.jquery.com/jquery-3.5.1.js\"");
                BeginWriteAttribute("integrity", " integrity=\"", 5447, "\"", 5459, 0);
                EndWriteAttribute();
                WriteLiteral(" crossorigin=\"anonymous\"></script>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f8b7a5c9037a0a08a5889cdbe08016087a2e059121822", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <script src=""https://cdn.jsdelivr.net/npm/popper.js@1.16.1/dist/umd/popper.min.js"" integrity=""sha384-9/reFTGAW83EW2RDu2S0VKaIzap3H66lZH81PoYlFhbGU+6BZp6G7niu735Sk7lN"" crossorigin=""anonymous""></script>
    <script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js"" integrity=""sha384-B4gt1jrGC7Jh4AgTPSdUtOBvfO8shuf57BaghqFfPlYxofvL8/KUEfYiJOMMV+rV"" crossorigin=""anonymous""></script>

    <script>
        $(document).ready(function(){
            $('#autoWidth').lightSlider({
                autoWidth:true,
                loop:true,
                onSliderLoad: function() {
                    $('#autoWidth').removeClass('cS-hidden');
                } 
            });
            
            $.get(""https://api.themoviedb.org/3/movie/");
#nullable restore
#line 100 "D:\danie\Desktop\Projects\moviesnow\moviesnow\Views\Home\MovieDetails.cshtml"
                                                 Write(Model.Movie.id);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"?api_key=002100dd35529be2881e0dbc97008958&language=en-US&append_to_response=release_dates"", function(res) {
                var html_str = ""<strong>""
                var cert = res.release_dates
                var results = cert.results
                
                var index = 0
                for (var i=0; i<results.length; i++){
                    var values = Object.values(results[i])
                    
                    if (values.includes(""US"")){
                        index = i
                        break;
                    }
                }

                var object = results[index]
                var release_dates = object.release_dates
                var content = release_dates[0]
                var certification = content.certification

                if (certification == """"){
                    certification = ""NR""
                }
                html_str += certification
                html_str += ""</strong> | ""
                $(""#cert"").html(h");
                WriteLiteral("tml_str)\r\n            }, \"json\");\r\n        });\r\n    </script>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DetailsWrapper> Html { get; private set; }
    }
}
#pragma warning restore 1591
