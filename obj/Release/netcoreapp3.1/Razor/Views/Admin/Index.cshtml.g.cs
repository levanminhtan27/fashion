#pragma checksum "F:\CASESTUDY_3\MVC_Fashion\Views\Admin\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5e05bec807a06d901b1c12075ae7538db3db9cd8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Index), @"mvc.1.0.view", @"/Views/Admin/Index.cshtml")]
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
#line 1 "F:\CASESTUDY_3\MVC_Fashion\Views\_ViewImports.cshtml"
using MVC_Fashion;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\CASESTUDY_3\MVC_Fashion\Views\_ViewImports.cshtml"
using MVC_Fashion.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\CASESTUDY_3\MVC_Fashion\Views\_ViewImports.cshtml"
using MVC_Fashion.Models.CartSessions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\CASESTUDY_3\MVC_Fashion\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\CASESTUDY_3\MVC_Fashion\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "F:\CASESTUDY_3\MVC_Fashion\Views\_ViewImports.cshtml"
using MVC_Fashion.Models.ViewAccount;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e05bec807a06d901b1c12075ae7538db3db9cd8", @"/Views/Admin/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af3e77f03def57e9cb6ce76d2e4bb14fc542c4d9", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "F:\CASESTUDY_3\MVC_Fashion\Views\Admin\Index.cshtml"
   
    Layout = "_LayoutAdmin";
 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<section class=""wrapper"">
    <!-- //market-->
    <div class=""market-updates"">
        <div class=""col-md-3 market-update-gd"">
            <div class=""market-update-block clr-block-2"">
                <div class=""col-md-4 market-update-right"">
                    <i class=""fa fa-eye""> </i>
                </div>
                <div class=""col-md-8 market-update-left"">
                    <h4>Visitors</h4>
                    <h3>13,500</h3>
                    <p>Other hand, we denounce</p>
                </div>
                <div class=""clearfix""> </div>
            </div>
        </div>
        <div class=""col-md-3 market-update-gd"">
            <div class=""market-update-block clr-block-1"">
                <div class=""col-md-4 market-update-right"">
                    <i class=""fa fa-users""></i>
                </div>
                <div class=""col-md-8 market-update-left"">
                    <h4>Users</h4>
                    <h3>1,250</h3>
                    <p>Other hand, ");
            WriteLiteral(@"we denounce</p>
                </div>
                <div class=""clearfix""> </div>
            </div>
        </div>
        <div class=""col-md-3 market-update-gd"">
            <div class=""market-update-block clr-block-3"">
                <div class=""col-md-4 market-update-right"">
                    <i class=""fa fa-usd""></i>
                </div>
                <div class=""col-md-8 market-update-left"">
                    <h4>Sales</h4>
                    <h3>1,500</h3>
                    <p>Other hand, we denounce</p>
                </div>
                <div class=""clearfix""> </div>
            </div>
        </div>
        <div class=""col-md-3 market-update-gd"">
            <div class=""market-update-block clr-block-4"">
                <div class=""col-md-4 market-update-right"">
                    <i class=""fa fa-shopping-cart"" aria-hidden=""true""></i>
                </div>
                <div class=""col-md-8 market-update-left"">
                    <h4>Orders</h4>
       ");
            WriteLiteral(@"             <h3>1,500</h3>
                    <p>Other hand, we denounce</p>
                </div>
                <div class=""clearfix""> </div>
            </div>
        </div>
        <div class=""clearfix""> </div>
    </div>
    <!-- //market-->
    <!-- calendar -->
    <div class=""col-md-6 agile-calendar"">
        <div class=""calendar-widget"">
            <div class=""panel-heading ui-sortable-handle"">
                <span class=""panel-icon"">
                    <i class=""fa fa-calendar-o""></i>
                </span>
                <span class=""panel-title""> Calendar Widget</span>
            </div>
            <!-- grids -->
            <div class=""agile-calendar-grid"">
                <div class=""page"">

                    <div class=""w3l-calendar-left"">
                        <div class=""calendar-heading"">

                        </div>
                        <div class=""monthly"" id=""mycalendar""></div>
                    </div>

                    <div class=""cl");
            WriteLiteral(@"earfix""> </div>
                </div>
            </div>
        </div>
    </div>
    <!-- //calendar -->
    <div class=""col-md-6 w3agile-notifications"">
        <div class=""notifications"">
            <!--notification start-->

            <header class=""panel-heading"">
                Notification
            </header>
            <div class=""notify-w3ls"">
                <div class=""alert alert-info clearfix"">
                    <span class=""alert-icon""><i class=""fa fa-envelope-o""></i></span>
                    <div class=""notification-info"">
                        <ul class=""clearfix notification-meta"">
                            <li class=""pull-left notification-sender""><span><a href=""#"">Jonathan Smith</a></span> send you a mail </li>
                            <li class=""pull-right notification-time"">1 min ago</li>
                        </ul>
                        <p>
                            Urgent meeting for next proposal
                        </p>
           ");
            WriteLiteral(@"         </div>
                </div>
                <div class=""alert alert-danger"">
                    <span class=""alert-icon""><i class=""fa fa-facebook""></i></span>
                    <div class=""notification-info"">
                        <ul class=""clearfix notification-meta"">
                            <li class=""pull-left notification-sender""><span><a href=""#"">Jonathan Smith</a></span> mentioned you in a post </li>
                            <li class=""pull-right notification-time"">7 Hours Ago</li>
                        </ul>
                        <p>
                            Very cool photo jack
                        </p>
                    </div>
                </div>
                <div class=""alert alert-success "">
                    <span class=""alert-icon""><i class=""fa fa-comments-o""></i></span>
                    <div class=""notification-info"">
                        <ul class=""clearfix notification-meta"">
                            <li class=""pull-left no");
            WriteLiteral(@"tification-sender"">You have 5 message unread</li>
                            <li class=""pull-right notification-time"">1 min ago</li>
                        </ul>
                        <p>
                            <a href=""#"">Anjelina Mewlo, Jack Flip</a> and <a href=""#"">3 others</a>
                        </p>
                    </div>
                </div>
                <div class=""alert alert-warning "">
                    <span class=""alert-icon""><i class=""fa fa-bell-o""></i></span>
                    <div class=""notification-info"">
                        <ul class=""clearfix notification-meta"">
                            <li class=""pull-left notification-sender"">Domain Renew Deadline 7 days ahead</li>
                            <li class=""pull-right notification-time"">5 Days Ago</li>
                        </ul>
                        <p>
                            Next 5 July Thursday is the last day
                        </p>
                    </div>
             ");
            WriteLiteral(@"   </div>
                <div class=""alert alert-info clearfix"">
                    <span class=""alert-icon""><i class=""fa fa-envelope-o""></i></span>
                    <div class=""notification-info"">
                        <ul class=""clearfix notification-meta"">
                            <li class=""pull-left notification-sender""><span><a href=""#"">Jonathan Smith</a></span> send you a mail </li>
                            <li class=""pull-right notification-time"">1 min ago</li>
                        </ul>
                        <p>
                            Urgent meeting for next proposal
                        </p>
                    </div>
                </div>

            </div>

            <!--notification end-->
        </div>
    </div>
    <div class=""clearfix""> </div>
    
    <!-- tasks -->

</section>");
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
