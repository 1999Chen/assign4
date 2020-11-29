#pragma checksum "D:\Assignment-3-main\Cllient\Pages\AddPerson.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "044a9ac58df1e2f6d344f7bb8e63c028525c7f62"
// <auto-generated/>
#pragma warning disable 1591
namespace Assignment.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Assignment-3-main\Cllient\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Assignment-3-main\Cllient\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Assignment-3-main\Cllient\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Assignment-3-main\Cllient\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Assignment-3-main\Cllient\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Assignment-3-main\Cllient\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Assignment-3-main\Cllient\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Assignment-3-main\Cllient\_Imports.razor"
using Assignment;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Assignment-3-main\Cllient\_Imports.razor"
using Assignment.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Assignment-3-main\Cllient\Pages\AddPerson.razor"
using global::Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Assignment-3-main\Cllient\Pages\AddPerson.razor"
using Assignment.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Assignment-3-main\Cllient\Pages\AddPerson.razor"
using FileData;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Assignment-3-main\Cllient\Pages\AddPerson.razor"
using System.Data.Common;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/ManagerPerson")]
    public partial class AddPerson : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>AddPerson</h3>\n\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(1);
            __builder.AddAttribute(2, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(3, "\n        ");
                __builder2.AddMarkupContent(4, "<p>You don\'t have permission to access!</p>\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(5, "\n\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(6);
            __builder.AddAttribute(7, "Policy", "Admin");
            __builder.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(9, "\n\n    ");
                __builder2.OpenElement(10, "div");
                __builder2.AddAttribute(11, "class", "form-group");
                __builder2.AddMarkupContent(12, "\n        ");
                __builder2.AddMarkupContent(13, "<label>Firstname：</label>\n        ");
                __builder2.OpenElement(14, "input");
                __builder2.AddAttribute(15, "type", "text");
                __builder2.AddAttribute(16, "placeholder", "firstname");
                __builder2.AddAttribute(17, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 19 "D:\Assignment-3-main\Cllient\Pages\AddPerson.razor"
                                                                firstname

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(18, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => firstname = __value, firstname));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(19, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(20, "\n\n    ");
                __builder2.OpenElement(21, "div");
                __builder2.AddAttribute(22, "class", "form-group");
                __builder2.AddMarkupContent(23, "\n        ");
                __builder2.AddMarkupContent(24, "<label>Lastname：</label>\n        ");
                __builder2.OpenElement(25, "input");
                __builder2.AddAttribute(26, "type", "text");
                __builder2.AddAttribute(27, "placeholder", "lastname");
                __builder2.AddAttribute(28, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 24 "D:\Assignment-3-main\Cllient\Pages\AddPerson.razor"
                                                               lastname

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(29, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => lastname = __value, lastname));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(31, "\n    ");
                __builder2.OpenElement(32, "div");
                __builder2.AddAttribute(33, "class", "form-group");
                __builder2.AddMarkupContent(34, "\n        ");
                __builder2.AddMarkupContent(35, "<label>Age:</label>\n        ");
                __builder2.OpenElement(36, "input");
                __builder2.AddAttribute(37, "type", "text");
                __builder2.AddAttribute(38, "placeholder", "age");
                __builder2.AddAttribute(39, "oninput", "value=value.replace(/[^\\d]/g,\'\')");
                __builder2.AddAttribute(40, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 28 "D:\Assignment-3-main\Cllient\Pages\AddPerson.razor"
                                                                                                     age

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(41, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => age = __value, age));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(42, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(43, "\n\n\n    ");
                __builder2.OpenElement(44, "div");
                __builder2.AddAttribute(45, "class", "form-group");
                __builder2.AddMarkupContent(46, "\n        ");
                __builder2.AddMarkupContent(47, "<label>Sex:</label>\n        ");
                __builder2.OpenElement(48, "select");
                __builder2.AddAttribute(49, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 34 "D:\Assignment-3-main\Cllient\Pages\AddPerson.razor"
                            setSex

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(50, "\n            ");
                __builder2.OpenElement(51, "option");
                __builder2.AddAttribute(52, "value", "M");
                __builder2.AddContent(53, "M");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(54, "\n            ");
                __builder2.OpenElement(55, "option");
                __builder2.AddAttribute(56, "value", "F");
                __builder2.AddContent(57, "F");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(58, "\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(59, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(60, "\n\n    ");
                __builder2.OpenElement(61, "div");
                __builder2.AddAttribute(62, "class", "form-group");
                __builder2.AddMarkupContent(63, "\n        ");
                __builder2.AddMarkupContent(64, "<label>Haircolor:</label>\n        ");
                __builder2.OpenElement(65, "select");
                __builder2.AddAttribute(66, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 42 "D:\Assignment-3-main\Cllient\Pages\AddPerson.razor"
                            setHair

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(67, "\n            ");
                __builder2.OpenElement(68, "option");
                __builder2.AddAttribute(69, "value", "Blond");
                __builder2.AddContent(70, "Blond");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(71, "\n            ");
                __builder2.OpenElement(72, "option");
                __builder2.AddAttribute(73, "value", "Red");
                __builder2.AddContent(74, "Red");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(75, "\n            ");
                __builder2.OpenElement(76, "option");
                __builder2.AddAttribute(77, "value", "Brown");
                __builder2.AddContent(78, "Brown");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(79, "\n            ");
                __builder2.OpenElement(80, "option");
                __builder2.AddAttribute(81, "value", "Black");
                __builder2.AddContent(82, "Black");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(83, "\n            ");
                __builder2.OpenElement(84, "option");
                __builder2.AddAttribute(85, "value", "White");
                __builder2.AddContent(86, "White");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(87, "\n            ");
                __builder2.OpenElement(88, "option");
                __builder2.AddAttribute(89, "value", "Grey");
                __builder2.AddContent(90, "Grey");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(91, "\n            ");
                __builder2.OpenElement(92, "option");
                __builder2.AddAttribute(93, "value", "Blue");
                __builder2.AddContent(94, "Blue");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(95, "\n            ");
                __builder2.OpenElement(96, "option");
                __builder2.AddAttribute(97, "value", "Green");
                __builder2.AddContent(98, "Green");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(99, "\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(100, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(101, "\n    \n    ");
                __builder2.OpenElement(102, "div");
                __builder2.AddAttribute(103, "class", "form-group");
                __builder2.AddMarkupContent(104, "\n        ");
                __builder2.AddMarkupContent(105, "<label>Eyecolor:</label>\n        ");
                __builder2.OpenElement(106, "select");
                __builder2.AddAttribute(107, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 56 "D:\Assignment-3-main\Cllient\Pages\AddPerson.razor"
                            setEye

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(108, "\n            ");
                __builder2.OpenElement(109, "option");
                __builder2.AddAttribute(110, "value", "Brown");
                __builder2.AddContent(111, "Brown");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(112, "\n            ");
                __builder2.OpenElement(113, "option");
                __builder2.AddAttribute(114, "value", "Amber");
                __builder2.AddContent(115, "Amber");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(116, "\n            ");
                __builder2.OpenElement(117, "option");
                __builder2.AddAttribute(118, "value", "Hazel");
                __builder2.AddContent(119, "Hazel");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(120, "\n            ");
                __builder2.OpenElement(121, "option");
                __builder2.AddAttribute(122, "value", "Grey");
                __builder2.AddContent(123, "Grey");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(124, "\n            ");
                __builder2.OpenElement(125, "option");
                __builder2.AddAttribute(126, "value", "Blue");
                __builder2.AddContent(127, "Blue");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(128, "\n            ");
                __builder2.OpenElement(129, "option");
                __builder2.AddAttribute(130, "value", "Green");
                __builder2.AddContent(131, "Green");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(132, "\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(133, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(134, "\n    \n    ");
                __builder2.OpenElement(135, "div");
                __builder2.AddAttribute(136, "class", "form-group");
                __builder2.AddMarkupContent(137, "\n        ");
                __builder2.AddMarkupContent(138, "<label>Height:</label>\n        ");
                __builder2.OpenElement(139, "input");
                __builder2.AddAttribute(140, "type", "text");
                __builder2.AddAttribute(141, "placeholder", "height");
                __builder2.AddAttribute(142, "oninput", "value=value.replace(/[^\\d]/g,\'\')");
                __builder2.AddAttribute(143, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 68 "D:\Assignment-3-main\Cllient\Pages\AddPerson.razor"
                                                                                                        height

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(144, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => height = __value, height));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(145, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(146, "\n    ");
                __builder2.OpenElement(147, "div");
                __builder2.AddAttribute(148, "class", "form-group");
                __builder2.AddMarkupContent(149, "\n        ");
                __builder2.AddMarkupContent(150, "<label>Weight:</label>\n        ");
                __builder2.OpenElement(151, "input");
                __builder2.AddAttribute(152, "type", "text");
                __builder2.AddAttribute(153, "placeholder", "weight");
                __builder2.AddAttribute(154, "oninput", "value=value.replace(/[^\\d.]/g,\'\')");
                __builder2.AddAttribute(155, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 72 "D:\Assignment-3-main\Cllient\Pages\AddPerson.razor"
                                                                                                         weight

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(156, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => weight = __value, weight));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(157, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(158, "\n\n    ");
                __builder2.OpenElement(159, "div");
                __builder2.AddAttribute(160, "class", "form-group");
                __builder2.AddMarkupContent(161, "\n        ");
                __builder2.AddMarkupContent(162, "<label>Job:</label>\n        ");
                __builder2.OpenElement(163, "input");
                __builder2.AddAttribute(164, "type", "text");
                __builder2.AddAttribute(165, "placeholder", "job");
                __builder2.AddAttribute(166, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 77 "D:\Assignment-3-main\Cllient\Pages\AddPerson.razor"
                                                          job

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(167, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => job = __value, job));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(168, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(169, "\n\n    ");
                __builder2.OpenElement(170, "button");
                __builder2.AddAttribute(171, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 80 "D:\Assignment-3-main\Cllient\Pages\AddPerson.razor"
                      addPerson

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(172, "\n        add\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(173, "\n    ");
                __builder2.OpenElement(174, "div");
                __builder2.AddAttribute(175, "style", "color:red");
                __builder2.AddContent(176, 
#nullable restore
#line 83 "D:\Assignment-3-main\Cllient\Pages\AddPerson.razor"
                            message

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(177, "\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 86 "D:\Assignment-3-main\Cllient\Pages\AddPerson.razor"
       
    private string firstname;
    private string lastname;
    private string sex = "M";
    private int age;
    private string hairColor="Blond";
    private string eyeColor="Brown";
    private int height;
    private float weight;
    private string message;
    private string job;

    public void setHair(ChangeEventArgs args)
    {
        string result = args.Value.ToString();
        hairColor = result;
    }

    public void setEye(ChangeEventArgs args)
    {
        string result = args.Value.ToString();
        eyeColor = result;
    }

    public void setSex(ChangeEventArgs args)
    {
        string result = args.Value.ToString();
        sex = result;
    }

    public async Task addPerson()
    {
        message = "";
        try
        {
            Person person = new Person();
            Adult adult = new Adult();
            FileContext fileContext = new FileContext();
            person.id = fileContext.Adults.Count+1;
            person.firstName = firstname;
            person.lastName = lastname;
            person.sex = sex;
            person.age = age;
            person.eyeColor = eyeColor;
            person.hairColor = hairColor;
            person.height = height;
            person.weight = weight;
            adult.jobTitle = job;
            adult.Update(person);
            fileContext.Adults.Add(adult);
            ClientModel.getInstance().addAdult(adult);
            fileContext.SaveChanges();
            message = "Add succeed!";
            Console.WriteLine(adult);
        }
        catch (Exception e)
        {
            message = e.Message;
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
    }
}
#pragma warning restore 1591