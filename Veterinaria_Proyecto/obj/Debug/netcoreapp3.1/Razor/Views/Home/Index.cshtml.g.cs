#pragma checksum "C:\basura\Veterinaria_Proyecto\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d809ace5872fb7d068699a8489140ed4c02252a9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\basura\Veterinaria_Proyecto\Views\_ViewImports.cshtml"
using Veterinaria_Proyecto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\basura\Veterinaria_Proyecto\Views\_ViewImports.cshtml"
using Veterinaria_Proyecto.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d809ace5872fb7d068699a8489140ed4c02252a9", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c458fa5f8e2338b95d77b09a176af94fa54cd5b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/index.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\basura\Veterinaria_Proyecto\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Veterinaria";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d809ace5872fb7d068699a8489140ed4c02252a94282", async() => {
                WriteLiteral(@"

    <link rel=""canonical"" href=""https://getbootstrap.com/docs/5.0/examples/carousel/""/>
    <!-- Bootstrap core CSS -->
    <link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.2.0-beta1/dist/css/bootstrap.min.css"" rel=""stylesheet"" integrity=""sha384-0evHe/X+R7YkIZDRvuzKMRqM+OrBnVFBL6DOitfPri4tjfHxaWutUpFmBp4vmVor"" crossorigin=""anonymous"">


    <style>
      .bd-placeholder-img {
        font-size: 1.125rem;
        text-anchor: middle;
        -webkit-user-select: none;
        -moz-user-select: none;
        user-select: none;
      }

    </style>

    <!-- Custom styles for this template -->
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d809ace5872fb7d068699a8489140ed4c02252a95177", async() => {
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
                WriteLiteral("\r\n  ");
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
            WriteLiteral("\r\n  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d809ace5872fb7d068699a8489140ed4c02252a97063", async() => {
                WriteLiteral(@"
    <main>
      <div id=""myCarousel"" class=""carousel slide"" data-bs-ride=""carousel"">
        <div class=""carousel-indicators"">
          <button
            type=""button""
            data-bs-target=""#myCarousel""
            data-bs-slide-to=""0""
            class=""active""
            aria-current=""true""
            aria-label=""Slide 1""
          ></button>
          <button
            type=""button""
            data-bs-target=""#myCarousel""
            data-bs-slide-to=""1""
            aria-label=""Slide 2""
          ></button>
          <button
            type=""button""
            data-bs-target=""#myCarousel""
            data-bs-slide-to=""2""
            aria-label=""Slide 3""
          ></button>
        </div>
        <div class=""carousel-inner"">
          <div class=""carousel-item active"">
            <img src=""media/carousel_01.jpg"" class=""carImg""/>

            <div class=""container"">
              <div class=""carousel-caption text-start"">
                <h1>Example headline.");
                WriteLiteral(@"</h1>
                <p>
                  Some representative placeholder content for the first slide of
                  the carousel.
                </p>
                <p>
                  <a class=""btn btn-lg btn-primary"" href=""#"">Sign up today</a>
                </p>
              </div>
            </div>
          </div>
          <div class=""carousel-item"">
                    <img src=""media/carousel_02.jpg"" class=""carImg"" />

            <div class=""container"">
              <div class=""carousel-caption"">
                <h1>Another example headline.</h1>
                <p>
                  Some representative placeholder content for the second slide
                  of the carousel.
                </p>
                <p><a class=""btn btn-lg btn-primary"" href=""#"">Learn more</a></p>
              </div>
            </div>
          </div>
          <div class=""carousel-item"">
                    <img src=""media/carousel_03.jpg"" class=""carImg"" />
               ");
                WriteLiteral(@"

            <div class=""container"">
              <div class=""carousel-caption text-end"">
                <h1>One more for good measure.</h1>
                <p>
                  Some representative placeholder content for the third slide of
                  this carousel.
                </p>
                <p>
                  <a class=""btn btn-lg btn-primary"" href=""#"">Browse gallery</a>
                </p>
              </div>
            </div>
          </div>
        </div>
        <button
          class=""carousel-control-prev""
          type=""button""
          data-bs-target=""#myCarousel""
          data-bs-slide=""prev""
        >
          <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
          <span class=""visually-hidden"">Previous</span>
        </button>
        <button
          class=""carousel-control-next""
          type=""button""
          data-bs-target=""#myCarousel""
          data-bs-slide=""next""
        >
          <span class=""carouse");
                WriteLiteral(@"l-control-next-icon"" aria-hidden=""true""></span>
          <span class=""visually-hidden"">Next</span>
        </button>
      </div>

      <!-- Marketing messaging and featurettes
  ================================================== -->
      <!-- Wrap the rest of the page in another container to center all the content. -->

      <div class=""container marketing"">
        <!-- Three columns of text below the carousel -->
        <div class=""row"">
          <div class=""col-lg-4"">
            <img src=""media/dog-bowl.png"" style=""width:45%""/>

            <h2>Comida</h2>
            <p>
              Some representative placeholder content for the three columns of
              text below the carousel. This is the first column.
            </p>
            <p>
              <a class=""btn btn-secondary"" href=""#"">View details &raquo;</a>
            </p>
          </div>
          <!-- /.col-lg-4 -->
          <div class=""col-lg-4"">
            <img src=""media/cat-toy.png"" style=""width:45%");
                WriteLiteral(@"""/>
            <h2>Accesorios</h2>
            <p>
              Another exciting bit of representative placeholder content. This
              time, we've moved on to the second column.
            </p>
            <p>
              <a class=""btn btn-secondary"" href=""#"">View details &raquo;</a>
            </p>
          </div>
          <!-- /.col-lg-4 -->
          <div class=""col-lg-4"">
            
            
              <img src=""media/pngegg.png"" style=""width:45%;"">

            <h2>Medicamentos</h2>
            <p>
              And lastly this, the third column of representative placeholder
              content.
            </p>
            <p>
              <a class=""btn btn-secondary"" href=""#"">View details &raquo;</a>
            </p>
          </div>
          <!-- /.col-lg-4 -->
        </div>
        <!-- /.row -->

        <!-- START THE FEATURETTES -->

        <hr class=""featurette-divider"" />

        <div class=""row featurette"">
          <div class=""");
                WriteLiteral(@"col-md-7"">
            <h2 class=""featurette-heading"">
              First featurette heading.
              <span class=""text-muted"">It’ll blow your mind.</span>
            </h2>
            <p class=""lead"">
              Some great placeholder content for the first featurette here.
              Imagine some exciting prose here.
            </p>
          </div>
          <div class=""col-md-5"">
            <svg
              class=""bd-placeholder-img bd-placeholder-img-lg featurette-image img-fluid mx-auto""
              width=""500""
              height=""500""
              xmlns=""http://www.w3.org/2000/svg""
              role=""img""
              aria-label=""Placeholder: 500x500""
              preserveAspectRatio=""xMidYMid slice""
              focusable=""false""
            >
              <title>Placeholder</title>
              <rect width=""100%"" height=""100%"" fill=""#eee"" />
              <text x=""50%"" y=""50%"" fill=""#aaa"" dy="".3em"">500x500</text>
            </svg>
          </div>");
                WriteLiteral(@"
        </div>

        <hr class=""featurette-divider"" />

        <div class=""row featurette"">
          <div class=""col-md-7 order-md-2"">
            <h2 class=""featurette-heading"">
              Oh yeah, it’s that good.
              <span class=""text-muted"">See for yourself.</span>
            </h2>
            <p class=""lead"">
              Another featurette? Of course. More placeholder content here to
              give you an idea of how this layout would work with some actual
              real-world content in place.
            </p>
          </div>
          <div class=""col-md-5 order-md-1"">
            <svg
              class=""bd-placeholder-img bd-placeholder-img-lg featurette-image img-fluid mx-auto""
              width=""500""
              height=""500""
              xmlns=""http://www.w3.org/2000/svg""
              role=""img""
              aria-label=""Placeholder: 500x500""
              preserveAspectRatio=""xMidYMid slice""
              focusable=""false""
            ");
                WriteLiteral(@">
              <title>Placeholder</title>
              <rect width=""100%"" height=""100%"" fill=""#eee"" />
              <text x=""50%"" y=""50%"" fill=""#aaa"" dy="".3em"">500x500</text>
            </svg>
          </div>
        </div>

        <hr class=""featurette-divider"" />

        <div class=""row featurette"">
          <div class=""col-md-7"">
            <h2 class=""featurette-heading"">
              And lastly, this one. <span class=""text-muted"">Checkmate.</span>
            </h2>
            <p class=""lead"">
              And yes, this is the last block of representative placeholder
              content. Again, not really intended to be actually read, simply
              here to give you a better view of what this would look like with
              some actual content. Your content.
            </p>
          </div>
          <div class=""col-md-5"">
            <svg
              class=""bd-placeholder-img bd-placeholder-img-lg featurette-image img-fluid mx-auto""
              width=""5");
                WriteLiteral(@"00""
              height=""500""
              xmlns=""http://www.w3.org/2000/svg""
              role=""img""
              aria-label=""Placeholder: 500x500""
              preserveAspectRatio=""xMidYMid slice""
              focusable=""false""
            >
              <title>Placeholder</title>
              <rect width=""100%"" height=""100%"" fill=""#eee"" />
              <text x=""50%"" y=""50%"" fill=""#aaa"" dy="".3em"">500x500</text>
            </svg>
          </div>
        </div>

        <hr class=""featurette-divider"" />

        <!-- /END THE FEATURETTES -->
      </div>
      <!-- /.container -->

      <!-- FOOTER -->
      <footer class=""container"">
        <p class=""float-end""><a href=""#"">Back to top</a></p>
        <p>
          &copy; 2017–2021 Company, Inc. &middot;
          <a href=""#"">Privacy</a> &middot; <a href=""#"">Terms</a>
        </p>
      </footer>
    </main>

    <script src=""https://cdn.jsdelivr.net/npm/bootstrap@5.2.0-beta1/dist/js/bootstrap.bundle.min.js"" integri");
                WriteLiteral("ty=\"sha384-pprn3073KE6tl6bjs2QrFaJGz5/SUsLqktiwsUTF55Jfv3qYSDhgCecCxMW52nD2\" crossorigin=\"anonymous\"></script>\r\n  ");
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
            WriteLiteral("\r\n</html>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
