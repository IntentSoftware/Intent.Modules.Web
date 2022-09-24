//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:6.0.8
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Intent.Modules.Angular.ServiceProxies.Templates.Proxies.AngularServiceProxy {
    using System.Collections.Generic;
    using System.Linq;
    using Intent.Modules.Common;
    using Intent.Modules.Common.Templates;
    using Intent.Modules.Common.TypeScript.Templates;
    using Intent.Metadata.Models;
    using Intent.Modelers.Types.ServiceProxies.Api;
    using System;
    
    
    public partial class AngularServiceProxyTemplate : TypeScriptTemplateBase<Intent.Modelers.Types.ServiceProxies.Api.ServiceProxyModel> {
        
        public override string TransformText() {
            this.GenerationEnvironment = null;
            
            #line 10 ""
            this.Write("import { Injectable } from \'@angular/core\';\r\n\r\nimport { Observable } from \'rxjs\';" +
                    "\r\nimport { map } from \'rxjs/operators\';\r\n\r\n@Injectable()\r\nexport class ");
            
            #line default
            #line hidden
            
            #line 16 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( ClassName ));
            
            #line default
            #line hidden
            
            #line 16 ""
            this.Write(" {\r\n  constructor(\r\n    private apiService: ");
            
            #line default
            #line hidden
            
            #line 18 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( ApiServiceClassName ));
            
            #line default
            #line hidden
            
            #line 18 ""
            this.Write("\r\n  ) {\r\n  }\r\n");
            
            #line default
            #line hidden
            
            #line 21 ""
  foreach (var operation in Model.Operations) { 
            
            #line default
            #line hidden
            
            #line 22 ""
            this.Write("\r\n  public ");
            
            #line default
            #line hidden
            
            #line 23 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( operation.Name.ToCamelCase() ));
            
            #line default
            #line hidden
            
            #line 23 ""
            this.Write("(");
            
            #line default
            #line hidden
            
            #line 23 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( GetParameterDefinitions(operation)));
            
            #line default
            #line hidden
            
            #line 23 ""
            this.Write("): Observable<");
            
            #line default
            #line hidden
            
            #line 23 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( GetReturnType(operation)));
            
            #line default
            #line hidden
            
            #line 23 ""
            this.Write("> {\r\n    let url = `");
            
            #line default
            #line hidden
            
            #line 24 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( GetPath(operation) ));
            
            #line default
            #line hidden
            
            #line 24 ""
            this.Write("`;");
            
            #line default
            #line hidden
            
            #line 24 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( GetUpdateUrl(operation)));
            
            #line default
            #line hidden
            
            #line 24 ""
            this.Write("\r\n    return this.apiService.");
            
            #line default
            #line hidden
            
            #line 25 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( GetDataServiceCall(operation)));
            
            #line default
            #line hidden
            
            #line 25 ""
            this.Write("\r\n      .pipe(map((response: any) => {\r\n        return response;\r\n      }));\r\n  }" +
                    "\r\n");
            
            #line default
            #line hidden
            
            #line 30 ""
  } 
            
            #line default
            #line hidden
            
            #line 31 ""
            this.Write("}\r\n");
            
            #line default
            #line hidden
            return this.GenerationEnvironment.ToString();
        }
        
        public override void Initialize() {
            base.Initialize();
        }
    }
}
