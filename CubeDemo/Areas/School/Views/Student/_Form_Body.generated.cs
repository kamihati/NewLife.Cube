﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
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
    using CubeDemo;
    
    #line 2 "..\..\Areas\School\Views\Student\_Form_Body.cshtml"
    using NewLife;
    
    #line default
    #line hidden
    using NewLife.Cube;
    using NewLife.Reflection;
    
    #line 5 "..\..\Areas\School\Views\Student\_Form_Body.cshtml"
    using NewLife.School.Entity;
    
    #line default
    #line hidden
    using NewLife.Web;
    
    #line 3 "..\..\Areas\School\Views\Student\_Form_Body.cshtml"
    using XCode;
    
    #line default
    #line hidden
    
    #line 4 "..\..\Areas\School\Views\Student\_Form_Body.cshtml"
    using XCode.Configuration;
    
    #line default
    #line hidden
    using XCode.Membership;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/School/Views/Student/_Form_Body.cshtml")]
    public partial class _Areas_School_Views_Student__Form_Body_cshtml : System.Web.Mvc.WebViewPage<NewLife.School.Entity.Student>
    {
        public _Areas_School_Views_Student__Form_Body_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 6 "..\..\Areas\School\Views\Student\_Form_Body.cshtml"
  
    var entity = Model;
    var fields = ViewBag.Fields as IList<FieldItem>;
    var isNew = (entity as IEntity).IsNullKey;

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" class=\"form-group col-xs-12 col-sm-6 col-lg-4\"");

WriteLiteral(">\r\n    <label");

WriteLiteral(" class=\"control-label col-xs-3 col-sm-3\"");

WriteLiteral(">班级</label>\r\n    <div");

WriteLiteral(" class=\"input-group col-xs-9 col-sm-9\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 14 "..\..\Areas\School\Views\Student\_Form_Body.cshtml"
   Write(Html.ForDropDownList("ClassID", Student.Meta.AllFields.First(e=>e.Name=="ClassName").Map.Provider.GetDataSource(), @entity.ClassID));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n</div>\r\n<div");

WriteLiteral(" class=\"form-group col-xs-12 col-sm-6 col-lg-4\"");

WriteLiteral(">\r\n    <label");

WriteLiteral(" class=\"control-label col-xs-3 col-sm-3\"");

WriteLiteral(">名称</label>\r\n    <div");

WriteLiteral(" class=\"input-group col-xs-9 col-sm-9\"");

WriteLiteral(">\r\n        <input");

WriteLiteral(" class=\"form-control\"");

WriteLiteral(" id=\"Name\"");

WriteLiteral(" name=\"Name\"");

WriteLiteral(" type=\"text\"");

WriteAttribute("value", Tuple.Create(" value=\"", 827), Tuple.Create("\"", 847)
            
            #line 20 "..\..\Areas\School\Views\Student\_Form_Body.cshtml"
, Tuple.Create(Tuple.Create("", 835), Tuple.Create<System.Object, System.Int32>(entity.Name
            
            #line default
            #line hidden
, 835), false)
);

WriteLiteral(" />\r\n    </div>\r\n</div>\r\n<div");

WriteLiteral(" class=\"form-group col-xs-12 col-sm-6 col-lg-4\"");

WriteLiteral(">\r\n    <label");

WriteLiteral(" class=\"control-label col-xs-3 col-sm-3\"");

WriteLiteral(">性别xyz</label>\r\n    <div");

WriteLiteral(" class=\"input-group col-xs-9 col-sm-9\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 26 "..\..\Areas\School\Views\Student\_Form_Body.cshtml"
   Write(Html.ForEnum("Sex", @entity.Sex));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n</div>\r\n<div");

WriteLiteral(" class=\"form-group col-xs-12 col-sm-6 col-lg-4\"");

WriteLiteral(">\r\n    <label");

WriteLiteral(" class=\"control-label col-xs-3 col-sm-3\"");

WriteLiteral(">年龄</label>\r\n    <div");

WriteLiteral(" class=\"input-group col-xs-9 col-sm-9\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 32 "..\..\Areas\School\Views\Student\_Form_Body.cshtml"
   Write(Html.TextBox("Age", @entity.Age, new { @class = "form-control", role="number" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n</div>\r\n<div");

WriteLiteral(" class=\"form-group col-xs-12 col-sm-6 col-lg-4\"");

WriteLiteral(">\r\n    <label");

WriteLiteral(" class=\"control-label col-xs-3 col-sm-3\"");

WriteLiteral(">手机</label>\r\n    <div");

WriteLiteral(" class=\"input-group col-xs-9 col-sm-9\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"input-group\"");

WriteLiteral("><span");

WriteLiteral(" class=\"input-group-addon\"");

WriteLiteral("><i");

WriteLiteral(" class=\"glyphicon glyphicon-phone\"");

WriteLiteral("></i></span><input");

WriteLiteral(" class=\"form-control\"");

WriteLiteral(" id=\"Mobile\"");

WriteLiteral(" name=\"Mobile\"");

WriteLiteral(" type=\"tel\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1725), Tuple.Create("\"", 1747)
            
            #line 38 "..\..\Areas\School\Views\Student\_Form_Body.cshtml"
                                                                                                         , Tuple.Create(Tuple.Create("", 1733), Tuple.Create<System.Object, System.Int32>(entity.Mobile
            
            #line default
            #line hidden
, 1733), false)
);

WriteLiteral(" /></div>\r\n    </div>\r\n</div>\r\n<div");

WriteLiteral(" class=\"form-group col-xs-12 col-sm-6 col-lg-4\"");

WriteLiteral(">\r\n    <label");

WriteLiteral(" class=\"control-label col-xs-3 col-sm-3\"");

WriteLiteral(">地址</label>\r\n    <div");

WriteLiteral(" class=\"input-group col-xs-9 col-sm-9\"");

WriteLiteral(">\r\n        <input");

WriteLiteral(" class=\"form-control\"");

WriteLiteral(" id=\"Address\"");

WriteLiteral(" name=\"Address\"");

WriteLiteral(" type=\"text\"");

WriteAttribute("value", Tuple.Create(" value=\"", 2020), Tuple.Create("\"", 2043)
            
            #line 44 "..\..\Areas\School\Views\Student\_Form_Body.cshtml"
   , Tuple.Create(Tuple.Create("", 2028), Tuple.Create<System.Object, System.Int32>(entity.Address
            
            #line default
            #line hidden
, 2028), false)
);

WriteLiteral(" />\r\n    </div>\r\n</div>\r\n");

            
            #line 47 "..\..\Areas\School\Views\Student\_Form_Body.cshtml"
Write(Html.Partial("_Form_Footer", entity));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 48 "..\..\Areas\School\Views\Student\_Form_Body.cshtml"
 if (this.Has(PermissionFlags.Insert, PermissionFlags.Update))
{

            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteLiteral(" class=\"clearfix form-actions col-sm-12 col-md-12\"");

WriteLiteral(">\r\n        <label");

WriteLiteral(" class=\"control-label col-xs-4 col-sm-5 col-md-5\"");

WriteLiteral("></label>\r\n        <button");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" class=\"btn btn-success btn-sm\"");

WriteLiteral("><i");

WriteAttribute("class", Tuple.Create(" class=\"", 2373), Tuple.Create("\"", 2427)
, Tuple.Create(Tuple.Create("", 2381), Tuple.Create("glyphicon", 2381), true)
, Tuple.Create(Tuple.Create(" ", 2390), Tuple.Create("glyphicon-", 2391), true)
            
            #line 52 "..\..\Areas\School\Views\Student\_Form_Body.cshtml"
            , Tuple.Create(Tuple.Create("", 2401), Tuple.Create<System.Object, System.Int32>(isNew ? "plus" : "save"
            
            #line default
            #line hidden
, 2401), false)
);

WriteLiteral("></i><strong>");

            
            #line 52 "..\..\Areas\School\Views\Student\_Form_Body.cshtml"
                                                                                                                               Write(isNew ? "新增" : "保存");

            
            #line default
            #line hidden
WriteLiteral("</strong></button>\r\n        <button");

WriteLiteral(" type=\"button\"");

WriteLiteral(" class=\"btn btn-danger btn-sm\"");

WriteLiteral(" onclick=\"history.go(-1);\"");

WriteLiteral("><i");

WriteLiteral(" class=\"glyphicon glyphicon-remove\"");

WriteLiteral("></i><strong>取消</strong></button>\r\n    </div>\r\n");

            
            #line 55 "..\..\Areas\School\Views\Student\_Form_Body.cshtml"
}
            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
