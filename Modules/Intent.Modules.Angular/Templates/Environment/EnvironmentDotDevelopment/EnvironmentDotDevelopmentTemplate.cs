// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 17.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Intent.Modules.Angular.Templates.Environment.EnvironmentDotDevelopment
{
    using System.Collections.Generic;
    using System.Linq;
    using Intent.Modules.Common;
    using Intent.Modules.Common.TypeScript.Templates;
    using Intent.Metadata.Models;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\Dev\Intent.Modules.Web\Modules\Intent.Modules.Angular\Templates\Environment\EnvironmentDotDevelopment\EnvironmentDotDevelopmentTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "17.0.0.0")]
    public partial class EnvironmentDotDevelopmentTemplate : TypeScriptTemplateBase<object>
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write("//@IntentCanAdd()\r\nexport const environment = {");
            
            #line 9 "C:\Dev\Intent.Modules.Web\Modules\Intent.Modules.Angular\Templates\Environment\EnvironmentDotDevelopment\EnvironmentDotDevelopmentTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetEnvironmentVariables()));
            
            #line default
            #line hidden
            this.Write("\r\n};\r\n");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}