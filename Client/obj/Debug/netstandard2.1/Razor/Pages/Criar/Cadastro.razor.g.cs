#pragma checksum "D:\Users\User\source\repos\forms\Client\Pages\Criar\Cadastro.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8298a2de31c859b8f73281c9509481d669e96edd"
// <auto-generated/>
#pragma warning disable 1591
namespace Forms.Client.Pages.Criar
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Users\User\source\repos\forms\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Users\User\source\repos\forms\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Users\User\source\repos\forms\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Users\User\source\repos\forms\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Users\User\source\repos\forms\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Users\User\source\repos\forms\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Users\User\source\repos\forms\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Users\User\source\repos\forms\Client\_Imports.razor"
using Forms.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Users\User\source\repos\forms\Client\_Imports.razor"
using Forms.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Users\User\source\repos\forms\Client\Pages\Criar\Cadastro.razor"
using Forms.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Users\User\source\repos\forms\Client\Pages\Criar\Cadastro.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Criar/Cadastro")]
    public partial class Cadastro : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Cadastro do Usuário</h3>\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 9 "D:\Users\User\source\repos\forms\Client\Pages\Criar\Cadastro.razor"
                 usuario

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 9 "D:\Users\User\source\repos\forms\Client\Pages\Criar\Cadastro.razor"
                                     Create

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(5, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(6);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\r\n    ");
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "form-group");
                __builder2.AddMarkupContent(10, "\r\n        ");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "form-row row");
                __builder2.AddAttribute(13, "style", "margin:30px 0");
                __builder2.AddMarkupContent(14, "\r\n            ");
                __builder2.OpenElement(15, "div");
                __builder2.AddAttribute(16, "class", "form-group col-md-3");
                __builder2.AddMarkupContent(17, "\r\n                ");
                __Blazor.Forms.Client.Pages.Criar.Cadastro.TypeInference.CreateInputSelect_0(__builder2, 18, 19, "form-control", 20, 
#nullable restore
#line 14 "D:\Users\User\source\repos\forms\Client\Pages\Criar\Cadastro.razor"
                                                                usuario.Title

#line default
#line hidden
#nullable disable
                , 21, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => usuario.Title = __value, usuario.Title)), 22, () => usuario.Title, 23, (__builder3) => {
                    __builder3.AddMarkupContent(24, "\r\n                    ");
                    __builder3.AddMarkupContent(25, "<option value>Selecione o seu Titulo...</option>\r\n                    ");
                    __builder3.AddMarkupContent(26, "<option value=\"Senhor\">Sr.</option>\r\n                    ");
                    __builder3.AddMarkupContent(27, "<option value=\"Senhora\">Sra.</option>\r\n                ");
                }
                );
                __builder2.AddMarkupContent(28, "\r\n                ");
                __Blazor.Forms.Client.Pages.Criar.Cadastro.TypeInference.CreateValidationMessage_1(__builder2, 29, 30, 
#nullable restore
#line 19 "D:\Users\User\source\repos\forms\Client\Pages\Criar\Cadastro.razor"
                                          () => usuario.Title

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(31, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(32, "\r\n            ");
                __builder2.OpenElement(33, "div");
                __builder2.AddAttribute(34, "class", "form-group col");
                __builder2.AddMarkupContent(35, "\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(36);
                __builder2.AddAttribute(37, "class", "form-control");
                __builder2.AddAttribute(38, "placeholder", "Primeiro Nome");
                __builder2.AddAttribute(39, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 22 "D:\Users\User\source\repos\forms\Client\Pages\Criar\Cadastro.razor"
                                                                                          usuario.First

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(40, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => usuario.First = __value, usuario.First))));
                __builder2.AddAttribute(41, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => usuario.First));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(42, "\r\n                ");
                __Blazor.Forms.Client.Pages.Criar.Cadastro.TypeInference.CreateValidationMessage_2(__builder2, 43, 44, 
#nullable restore
#line 23 "D:\Users\User\source\repos\forms\Client\Pages\Criar\Cadastro.razor"
                                          () => usuario.First

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(45, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(46, "\r\n            ");
                __builder2.OpenElement(47, "div");
                __builder2.AddAttribute(48, "class", "form-group col");
                __builder2.AddMarkupContent(49, "\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(50);
                __builder2.AddAttribute(51, "class", "form-control");
                __builder2.AddAttribute(52, "placeholder", "Ultimo Nome");
                __builder2.AddAttribute(53, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 26 "D:\Users\User\source\repos\forms\Client\Pages\Criar\Cadastro.razor"
                                                              usuario.Last

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(54, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => usuario.Last = __value, usuario.Last))));
                __builder2.AddAttribute(55, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => usuario.Last));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(56, "\r\n                ");
                __Blazor.Forms.Client.Pages.Criar.Cadastro.TypeInference.CreateValidationMessage_3(__builder2, 57, 58, 
#nullable restore
#line 27 "D:\Users\User\source\repos\forms\Client\Pages\Criar\Cadastro.razor"
                                          () => usuario.Last

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(59, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(60, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(61, "\r\n        ");
                __builder2.OpenElement(62, "div");
                __builder2.AddAttribute(63, "class", "form-row row");
                __builder2.AddAttribute(64, "style", "margin:30px 0");
                __builder2.AddMarkupContent(65, "\r\n            ");
                __builder2.OpenElement(66, "div");
                __builder2.AddAttribute(67, "class", "form-group col");
                __builder2.AddMarkupContent(68, "\r\n                ");
                __Blazor.Forms.Client.Pages.Criar.Cadastro.TypeInference.CreateInputDate_4(__builder2, 69, 70, "form-control", 71, 
#nullable restore
#line 32 "D:\Users\User\source\repos\forms\Client\Pages\Criar\Cadastro.razor"
                                        usuario.Birthday

#line default
#line hidden
#nullable disable
                , 72, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => usuario.Birthday = __value, usuario.Birthday)), 73, () => usuario.Birthday);
                __builder2.AddMarkupContent(74, "\r\n                ");
                __Blazor.Forms.Client.Pages.Criar.Cadastro.TypeInference.CreateValidationMessage_5(__builder2, 75, 76, 
#nullable restore
#line 33 "D:\Users\User\source\repos\forms\Client\Pages\Criar\Cadastro.razor"
                                          () => usuario.Birthday

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(77, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(78, "\r\n            ");
                __builder2.OpenElement(79, "div");
                __builder2.AddAttribute(80, "class", "form-group col");
                __builder2.AddMarkupContent(81, "\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(82);
                __builder2.AddAttribute(83, "class", "form-control");
                __builder2.AddAttribute(84, "placeholder", "Email");
                __builder2.AddAttribute(85, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 36 "D:\Users\User\source\repos\forms\Client\Pages\Criar\Cadastro.razor"
                                                                                  usuario.Email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(86, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => usuario.Email = __value, usuario.Email))));
                __builder2.AddAttribute(87, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => usuario.Email));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(88, "\r\n                ");
                __Blazor.Forms.Client.Pages.Criar.Cadastro.TypeInference.CreateValidationMessage_6(__builder2, 89, 90, 
#nullable restore
#line 37 "D:\Users\User\source\repos\forms\Client\Pages\Criar\Cadastro.razor"
                                          () => usuario.Email

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(91, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(92, "\r\n            ");
                __builder2.OpenElement(93, "div");
                __builder2.AddAttribute(94, "class", "form-group col");
                __builder2.AddMarkupContent(95, "\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(96);
                __builder2.AddAttribute(97, "class", "form-control");
                __builder2.AddAttribute(98, "type", "password");
                __builder2.AddAttribute(99, "placeholder", "Senha");
                __builder2.AddAttribute(100, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 40 "D:\Users\User\source\repos\forms\Client\Pages\Criar\Cadastro.razor"
                                                                                                  usuario.Password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(101, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => usuario.Password = __value, usuario.Password))));
                __builder2.AddAttribute(102, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => usuario.Password));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(103, "\r\n                ");
                __Blazor.Forms.Client.Pages.Criar.Cadastro.TypeInference.CreateValidationMessage_7(__builder2, 104, 105, 
#nullable restore
#line 41 "D:\Users\User\source\repos\forms\Client\Pages\Criar\Cadastro.razor"
                                          () => usuario.Password

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(106, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(107, "\r\n            ");
                __builder2.OpenElement(108, "div");
                __builder2.AddAttribute(109, "class", "form-group col");
                __builder2.AddMarkupContent(110, "\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(111);
                __builder2.AddAttribute(112, "class", "form-control");
                __builder2.AddAttribute(113, "type", "password");
                __builder2.AddAttribute(114, "placeholder", "Confirmar a Senha");
                __builder2.AddAttribute(115, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 44 "D:\Users\User\source\repos\forms\Client\Pages\Criar\Cadastro.razor"
                                                                                                              usuario.Confirm

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(116, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => usuario.Confirm = __value, usuario.Confirm))));
                __builder2.AddAttribute(117, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => usuario.Confirm));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(118, "\r\n                ");
                __Blazor.Forms.Client.Pages.Criar.Cadastro.TypeInference.CreateValidationMessage_8(__builder2, 119, 120, 
#nullable restore
#line 45 "D:\Users\User\source\repos\forms\Client\Pages\Criar\Cadastro.razor"
                                          () => usuario.Confirm

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(121, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(122, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(123, "\r\n        ");
                __builder2.OpenElement(124, "div");
                __builder2.AddAttribute(125, "class", "form-group col");
                __builder2.AddMarkupContent(126, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputCheckbox>(127);
                __builder2.AddAttribute(128, "class", "form-check-input");
                __builder2.AddAttribute(129, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 49 "D:\Users\User\source\repos\forms\Client\Pages\Criar\Cadastro.razor"
                                                                  usuario.Terms

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(130, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => usuario.Terms = __value, usuario.Terms))));
                __builder2.AddAttribute(131, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.Boolean>>>(() => usuario.Terms));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(132, "\r\n            ");
                __builder2.AddMarkupContent(133, "<label for=\"Terms\" class=\"form-check-label\">Aceitar os termos e condições de uso</label>\r\n            ");
                __Blazor.Forms.Client.Pages.Criar.Cadastro.TypeInference.CreateValidationMessage_9(__builder2, 134, 135, 
#nullable restore
#line 51 "D:\Users\User\source\repos\forms\Client\Pages\Criar\Cadastro.razor"
                                      () => usuario.Terms

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(136, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(137, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(138, "\r\n    ");
                __builder2.AddMarkupContent(139, @"<div class=""form-row row"">
        <div class=""form-group col"" style=""text-align:right;"">
            <button style="" margin-left:20px; background-color:dodgerblue; color:aliceblue;"" class=""btn btn-submit"" type=""submit"">Salvar</button>
        </div>
    </div>
");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 61 "D:\Users\User\source\repos\forms\Client\Pages\Criar\Cadastro.razor"
       
    private Usuario usuario = new Usuario();
    private void Create() {
        if (usuario.Password == usuario.Confirm)
        {
            Console.WriteLine($"Titulo : {usuario.Title}\nNome : {$"{usuario.First} {usuario.Last}"}\nData de Nascimento : {usuario.Birthday}\nEmail : {usuario.Email}\nSenha : {usuario.Password}");
            
        }
    }


#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.Forms.Client.Pages.Criar.Cadastro
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputSelect_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
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
        public static void CreateInputDate_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_6<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_7<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_8<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_9<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
