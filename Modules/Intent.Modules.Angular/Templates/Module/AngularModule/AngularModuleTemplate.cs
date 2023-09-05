// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 17.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Intent.Modules.Angular.Templates.Module.AngularModule
{
    using System.Collections.Generic;
    using System.Linq;
    using Intent.Modules.Common;
    using Intent.Modules.Common.TypeScript.Templates;
    using Intent.Modules.Angular.Api;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\Dev\Intent.Modules.Web\Modules\Intent.Modules.Angular\Templates\Module\AngularModule\AngularModuleTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "17.0.0.0")]
    public partial class AngularModuleTemplate : TypeScriptTemplateBase<Intent.Modelers.WebClient.Angular.Api.ModuleModel>
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write("import { NgModule } from \'@angular/core\';");
            
            #line 8 "C:\Dev\Intent.Modules.Web\Modules\Intent.Modules.Angular\Templates\Module\AngularModule\AngularModuleTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetImports()));
            
            #line default
            #line hidden
            this.Write("\r\n\r\n");
            
            #line 10 "C:\Dev\Intent.Modules.Web\Modules\Intent.Modules.Angular\Templates\Module\AngularModule\AngularModuleTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.IntentMergeDecorator()));
            
            #line default
            #line hidden
            this.Write("\r\n@NgModule({\r\n  declarations: [");
            
            #line 12 "C:\Dev\Intent.Modules.Web\Modules\Intent.Modules.Angular\Templates\Module\AngularModule\AngularModuleTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetComponents()));
            
            #line default
            #line hidden
            this.Write("],\r\n  imports: [");
            
            #line 13 "C:\Dev\Intent.Modules.Web\Modules\Intent.Modules.Angular\Templates\Module\AngularModule\AngularModuleTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetAngularImports()));
            
            #line default
            #line hidden
            this.Write("],\r\n  providers: [");
            
            #line 14 "C:\Dev\Intent.Modules.Web\Modules\Intent.Modules.Angular\Templates\Module\AngularModule\AngularModuleTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetProviders()));
            
            #line default
            #line hidden
            this.Write("]");
            
            #line 14 "C:\Dev\Intent.Modules.Web\Modules\Intent.Modules.Angular\Templates\Module\AngularModule\AngularModuleTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.IsRootModule() ? @",
  bootstrap: [AppComponent]" : ""));
            
            #line default
            #line hidden
            this.Write("\r\n})\r\nexport class ");
            
            #line 17 "C:\Dev\Intent.Modules.Web\Modules\Intent.Modules.Angular\Templates\Module\AngularModule\AngularModuleTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write(" { }\r\n");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
