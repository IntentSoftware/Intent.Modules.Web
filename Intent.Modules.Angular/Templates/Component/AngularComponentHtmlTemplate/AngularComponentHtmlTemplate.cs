// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 16.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Intent.Modules.Angular.Templates.Component.AngularComponentHtmlTemplate
{
    using System.Collections.Generic;
    using System.Linq;
    using Intent.Modules.Common;
    using Intent.Modules.Common.Templates;
    using Intent.Modules.Common.Html.Templates;
    using Intent.Modules.Angular.Api;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\Dev\Intent.Modules.Web\Intent.Modules.Angular\Templates\Component\AngularComponentHtmlTemplate\AngularComponentHtmlTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public partial class AngularComponentHtmlTemplate : HtmlTemplateBase<Intent.Angular.Api.ComponentModel>
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write("<div class=\"container-fluid\" intent-manage=\"add remove\" intent-id=\"container\">\r\n " +
                    "   <h3>");
            
            #line 10 "C:\Dev\Intent.Modules.Web\Intent.Modules.Angular\Templates\Component\AngularComponentHtmlTemplate\AngularComponentHtmlTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.Name));
            
            #line default
            #line hidden
            this.Write(" loaded successfully!</h3>\r\n</div>");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
