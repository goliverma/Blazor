#pragma checksum "/home/goli/Desktop/Blazor/EmployeeManag.Web/Pages/EditEmployee.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "861b7b148b44025698cc99a98d0a4940a381d428"
// <auto-generated/>
#pragma warning disable 1591
namespace EmployeeManag.Web.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/home/goli/Desktop/Blazor/EmployeeManag.Web/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/goli/Desktop/Blazor/EmployeeManag.Web/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/goli/Desktop/Blazor/EmployeeManag.Web/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/goli/Desktop/Blazor/EmployeeManag.Web/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/home/goli/Desktop/Blazor/EmployeeManag.Web/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/home/goli/Desktop/Blazor/EmployeeManag.Web/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/home/goli/Desktop/Blazor/EmployeeManag.Web/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/home/goli/Desktop/Blazor/EmployeeManag.Web/_Imports.razor"
using EmployeeManag.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/home/goli/Desktop/Blazor/EmployeeManag.Web/_Imports.razor"
using EmployeeManag.Web.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/home/goli/Desktop/Blazor/EmployeeManag.Web/_Imports.razor"
using EmployeeManag.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/editemployee/{id:int}")]
    public partial class EditEmployee : EditEmployeeBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 4 "/home/goli/Desktop/Blazor/EmployeeManag.Web/Pages/EditEmployee.razor"
                  EditEmployeeModel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 4 "/home/goli/Desktop/Blazor/EmployeeManag.Web/Pages/EditEmployee.razor"
                                                    HandleValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(4, "\n    ");
                __builder2.AddMarkupContent(5, "<h3>Edit Employee</h3>\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(6);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(8);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(9, "\n    <hr>\n    ");
                __builder2.OpenElement(10, "div");
                __builder2.AddAttribute(11, "class", "form-group row");
                __builder2.AddMarkupContent(12, "\n        ");
                __builder2.AddMarkupContent(13, "<label for=\"firstName\" class=\"col-sm-2 col-form-label\">First Name</label>\n        ");
                __builder2.OpenElement(14, "div");
                __builder2.AddAttribute(15, "class", "col-sm-10");
                __builder2.AddMarkupContent(16, "\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(17);
                __builder2.AddAttribute(18, "id", "firstName");
                __builder2.AddAttribute(19, "class", "form-control");
                __builder2.AddAttribute(20, "placeholder", "First Name");
                __builder2.AddAttribute(21, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 13 "/home/goli/Desktop/Blazor/EmployeeManag.Web/Pages/EditEmployee.razor"
                         EditEmployeeModel.FirstName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(22, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => EditEmployeeModel.FirstName = __value, EditEmployeeModel.FirstName))));
                __builder2.AddAttribute(23, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => EditEmployeeModel.FirstName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(24, "\n            ");
                __builder2.OpenElement(25, "span");
                __builder2.AddAttribute(26, "class", "text-danger");
                __Blazor.EmployeeManag.Web.Pages.EditEmployee.TypeInference.CreateValidationMessage_0(__builder2, 27, 28, 
#nullable restore
#line 14 "/home/goli/Desktop/Blazor/EmployeeManag.Web/Pages/EditEmployee.razor"
                                                                 ()=>EditEmployeeModel.FirstName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(29, "\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(31, "\n    ");
                __builder2.OpenElement(32, "div");
                __builder2.AddAttribute(33, "class", "form-group row");
                __builder2.AddMarkupContent(34, "\n        ");
                __builder2.AddMarkupContent(35, "<label for=\"lastName\" class=\"col-sm-2 col-form-label\">Last Name</label>\n        ");
                __builder2.OpenElement(36, "div");
                __builder2.AddAttribute(37, "class", "col-sm-10");
                __builder2.AddMarkupContent(38, "\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(39);
                __builder2.AddAttribute(40, "id", "lastName");
                __builder2.AddAttribute(41, "class", "form-control");
                __builder2.AddAttribute(42, "placeholder", "Last Name");
                __builder2.AddAttribute(43, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 21 "/home/goli/Desktop/Blazor/EmployeeManag.Web/Pages/EditEmployee.razor"
                         EditEmployeeModel.LastName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(44, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => EditEmployeeModel.LastName = __value, EditEmployeeModel.LastName))));
                __builder2.AddAttribute(45, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => EditEmployeeModel.LastName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(46, "\n            ");
                __builder2.OpenElement(47, "span");
                __builder2.AddAttribute(48, "class", "text-danger");
                __Blazor.EmployeeManag.Web.Pages.EditEmployee.TypeInference.CreateValidationMessage_1(__builder2, 49, 50, 
#nullable restore
#line 22 "/home/goli/Desktop/Blazor/EmployeeManag.Web/Pages/EditEmployee.razor"
                                                                 ()=>EditEmployeeModel.LastName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(51, "\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(52, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(53, "\n    ");
                __builder2.OpenElement(54, "div");
                __builder2.AddAttribute(55, "class", "form-group row");
                __builder2.AddMarkupContent(56, "\n        ");
                __builder2.AddMarkupContent(57, "<label for=\"emailName\" class=\"col-sm-2 col-form-label\">Email</label>\n        ");
                __builder2.OpenElement(58, "div");
                __builder2.AddAttribute(59, "class", "col-sm-10");
                __builder2.AddMarkupContent(60, "\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(61);
                __builder2.AddAttribute(62, "id", "emailName");
                __builder2.AddAttribute(63, "class", "form-control");
                __builder2.AddAttribute(64, "placeholder", "Email");
                __builder2.AddAttribute(65, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 29 "/home/goli/Desktop/Blazor/EmployeeManag.Web/Pages/EditEmployee.razor"
                         EditEmployeeModel.Email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(66, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => EditEmployeeModel.Email = __value, EditEmployeeModel.Email))));
                __builder2.AddAttribute(67, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => EditEmployeeModel.Email));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(68, "\n            ");
                __builder2.OpenElement(69, "span");
                __builder2.AddAttribute(70, "class", "text-danger");
                __Blazor.EmployeeManag.Web.Pages.EditEmployee.TypeInference.CreateValidationMessage_2(__builder2, 71, 72, 
#nullable restore
#line 30 "/home/goli/Desktop/Blazor/EmployeeManag.Web/Pages/EditEmployee.razor"
                                                                 ()=>EditEmployeeModel.Email

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(73, "\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(74, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(75, "\n    ");
                __builder2.OpenElement(76, "div");
                __builder2.AddAttribute(77, "class", "form-group row");
                __builder2.AddMarkupContent(78, "\n        ");
                __builder2.AddMarkupContent(79, "<label for=\"confirmEmail\" class=\"col-sm-2 col-form-label\">Confirm Email</label>\n        ");
                __builder2.OpenElement(80, "div");
                __builder2.AddAttribute(81, "class", "col-sm-10");
                __builder2.AddMarkupContent(82, "\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(83);
                __builder2.AddAttribute(84, "id", "confirmEmail");
                __builder2.AddAttribute(85, "class", "form-control");
                __builder2.AddAttribute(86, "placeholder", "Confirm Email");
                __builder2.AddAttribute(87, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 37 "/home/goli/Desktop/Blazor/EmployeeManag.Web/Pages/EditEmployee.razor"
                         EditEmployeeModel.ConfirmEmail

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(88, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => EditEmployeeModel.ConfirmEmail = __value, EditEmployeeModel.ConfirmEmail))));
                __builder2.AddAttribute(89, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => EditEmployeeModel.ConfirmEmail));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(90, "\n            ");
                __builder2.OpenElement(91, "span");
                __builder2.AddAttribute(92, "class", "text-danger");
                __Blazor.EmployeeManag.Web.Pages.EditEmployee.TypeInference.CreateValidationMessage_3(__builder2, 93, 94, 
#nullable restore
#line 38 "/home/goli/Desktop/Blazor/EmployeeManag.Web/Pages/EditEmployee.razor"
                                                                 ()=>EditEmployeeModel.ConfirmEmail

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(95, "\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(96, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(97, "\n    ");
                __builder2.OpenElement(98, "div");
                __builder2.AddAttribute(99, "class", "form-group row");
                __builder2.AddMarkupContent(100, "\n        ");
                __builder2.AddMarkupContent(101, "<label for=\"department\" class=\"col-sm-2 col-form-label\">Department</label>\n        ");
                __builder2.OpenElement(102, "div");
                __builder2.AddAttribute(103, "class", "col-sm-10");
                __builder2.AddMarkupContent(104, "\n            ");
                __Blazor.EmployeeManag.Web.Pages.EditEmployee.TypeInference.CreateCustomInputSelect_4(__builder2, 105, 106, "department", 107, "form-control", 108, 
#nullable restore
#line 44 "/home/goli/Desktop/Blazor/EmployeeManag.Web/Pages/EditEmployee.razor"
                                                            EditEmployeeModel.DepartmentId

#line default
#line hidden
#nullable disable
                , 109, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => EditEmployeeModel.DepartmentId = __value, EditEmployeeModel.DepartmentId)), 110, () => EditEmployeeModel.DepartmentId, 111, (__builder3) => {
                    __builder3.AddMarkupContent(112, "\n");
#nullable restore
#line 45 "/home/goli/Desktop/Blazor/EmployeeManag.Web/Pages/EditEmployee.razor"
                 foreach (var item in Departments)
                {

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(113, "                    ");
                    __builder3.OpenElement(114, "option");
                    __builder3.AddAttribute(115, "value", 
#nullable restore
#line 47 "/home/goli/Desktop/Blazor/EmployeeManag.Web/Pages/EditEmployee.razor"
                                    item.DepartmentId

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(116, 
#nullable restore
#line 47 "/home/goli/Desktop/Blazor/EmployeeManag.Web/Pages/EditEmployee.razor"
                                                        item.DepartmentName

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(117, "\n");
#nullable restore
#line 48 "/home/goli/Desktop/Blazor/EmployeeManag.Web/Pages/EditEmployee.razor"
                }

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(118, "            ");
                }
                );
                __builder2.AddMarkupContent(119, "\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(120, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(121, "\n    ");
                __builder2.OpenElement(122, "div");
                __builder2.AddAttribute(123, "class", "form-group row");
                __builder2.AddMarkupContent(124, "\n        ");
                __builder2.AddMarkupContent(125, "<label for=\"gender\" class=\"col-sm-2 col-form-label\">Gender</label>\n        ");
                __builder2.OpenElement(126, "div");
                __builder2.AddAttribute(127, "class", "col-sm-10");
                __builder2.AddMarkupContent(128, "\n            ");
                __Blazor.EmployeeManag.Web.Pages.EditEmployee.TypeInference.CreateInputSelect_5(__builder2, 129, 130, "gender", 131, "form-control", 132, 
#nullable restore
#line 55 "/home/goli/Desktop/Blazor/EmployeeManag.Web/Pages/EditEmployee.razor"
                                                  EditEmployeeModel.Gender

#line default
#line hidden
#nullable disable
                , 133, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => EditEmployeeModel.Gender = __value, EditEmployeeModel.Gender)), 134, () => EditEmployeeModel.Gender, 135, (__builder3) => {
                    __builder3.AddMarkupContent(136, "\n");
#nullable restore
#line 56 "/home/goli/Desktop/Blazor/EmployeeManag.Web/Pages/EditEmployee.razor"
                 foreach (var item in Enum.GetValues(typeof(Gender)))
                {

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(137, "                    ");
                    __builder3.OpenElement(138, "option");
                    __builder3.AddAttribute(139, "value", 
#nullable restore
#line 58 "/home/goli/Desktop/Blazor/EmployeeManag.Web/Pages/EditEmployee.razor"
                                    item

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(140, 
#nullable restore
#line 58 "/home/goli/Desktop/Blazor/EmployeeManag.Web/Pages/EditEmployee.razor"
                                           item

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(141, "\n");
#nullable restore
#line 59 "/home/goli/Desktop/Blazor/EmployeeManag.Web/Pages/EditEmployee.razor"
                }

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(142, "            ");
                }
                );
                __builder2.AddMarkupContent(143, "\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(144, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(145, "\n    ");
                __builder2.OpenElement(146, "div");
                __builder2.AddAttribute(147, "class", "form-group row");
                __builder2.AddMarkupContent(148, "\n        ");
                __builder2.AddMarkupContent(149, "<label for=\"dateOfBirth\" class=\"col-sm-2 col-form-label\">Date Of Birth</label>\n        ");
                __builder2.OpenElement(150, "div");
                __builder2.AddAttribute(151, "class", "col-sm-10");
                __builder2.AddMarkupContent(152, "\n            ");
                __Blazor.EmployeeManag.Web.Pages.EditEmployee.TypeInference.CreateInputDate_6(__builder2, 153, 154, "dateOfBirth", 155, "form-control", 156, 
#nullable restore
#line 66 "/home/goli/Desktop/Blazor/EmployeeManag.Web/Pages/EditEmployee.razor"
                                                     EditEmployeeModel.DateOfBirth

#line default
#line hidden
#nullable disable
                , 157, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => EditEmployeeModel.DateOfBirth = __value, EditEmployeeModel.DateOfBirth)), 158, () => EditEmployeeModel.DateOfBirth);
                __builder2.AddMarkupContent(159, "\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(160, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(161, "\n    ");
                __builder2.AddMarkupContent(162, "<button type=\"submit\" class=\"btn btn-primary\">Submit</button>\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.EmployeeManag.Web.Pages.EditEmployee
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateCustomInputSelect_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment __arg5)
        {
        __builder.OpenComponent<global::EmployeeManag.Web.Pages.CustomInputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.AddAttribute(__seq5, "ChildContent", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.AddAttribute(__seq5, "ChildContent", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateInputDate_6<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
