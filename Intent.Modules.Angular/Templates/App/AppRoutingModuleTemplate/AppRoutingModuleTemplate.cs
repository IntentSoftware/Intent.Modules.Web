// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 16.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Intent.Modules.Angular.Templates.App.AppRoutingModuleTemplate
{
    using System.Collections.Generic;
    using System.Linq;
    using Intent.Modules.Common;
    using Intent.Modules.Common.TypeScript.Templates;
    using Intent.Metadata.Models;
    using Intent.Modelers.WebClient.Api;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\Dev\Intent.Modules.Web\Intent.Modules.Angular\Templates\App\AppRoutingModuleTemplate\AppRoutingModuleTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public partial class AppRoutingModuleTemplate : TypeScriptTemplateBase<AngularWebAppModel>
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write("import { NgModule } from \'@angular/core\';\r\nimport { Routes, RouterModule, Preload" +
                    "AllModules } from \'@angular/router\';\r\n\r\n//@IntentMerge()\r\nconst routes: Routes =" +
                    " [\r\n");
            
            #line 14 "C:\Dev\Intent.Modules.Web\Intent.Modules.Angular\Templates\App\AppRoutingModuleTemplate\AppRoutingModuleTemplate.tt"
 foreach(var route in Routes) {
            
            #line default
            #line hidden
            this.Write("  {\r\n    path: \'");
            
            #line 16 "C:\Dev\Intent.Modules.Web\Intent.Modules.Angular\Templates\App\AppRoutingModuleTemplate\AppRoutingModuleTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetRoute(route)));
            
            #line default
            #line hidden
            this.Write("\',\r\n    loadChildren: () => import(\'./");
            
            #line 17 "C:\Dev\Intent.Modules.Web\Intent.Modules.Angular\Templates\App\AppRoutingModuleTemplate\AppRoutingModuleTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetModulePath(route)));
            
            #line default
            #line hidden
            this.Write("\').then(x => x.");
            
            #line 17 "C:\Dev\Intent.Modules.Web\Intent.Modules.Angular\Templates\App\AppRoutingModuleTemplate\AppRoutingModuleTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetTypeName(route)));
            
            #line default
            #line hidden
            this.Write(")\r\n  },\r\n");
            
            #line 19 "C:\Dev\Intent.Modules.Web\Intent.Modules.Angular\Templates\App\AppRoutingModuleTemplate\AppRoutingModuleTemplate.tt"
 } 
            
            #line default
            #line hidden
            this.Write("];\r\n\r\n@IntentMerge()\r\n@NgModule({\r\n  imports: [RouterModule.forRoot(routes, {\r\n  " +
                    "  preloadingStrategy: PreloadAllModules\r\n  })],\r\n  exports: [RouterModule]\r\n})\r\n" +
                    "export class AppRoutingModule { }\r\n");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
