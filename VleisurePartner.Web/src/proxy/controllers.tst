${
    using Typewriter.Extensions.Types;
    using Typewriter.Extensions.WebApi;

    string param(Typewriter.CodeModel.Parameter c)
    {
        if (c.Type.IsPrimitive){
            if(c.Type.Name == "Date"){
                return c.name + ": "+c.Type.Name + " | " + "string";
            }

            if (c.Type.IsEnum){
                return c.name + ": number";
            }

            return c.name + ": "+c.Type.Name;
        }
        else{
            return c.name + ": "+ "ProxyModel." + c.Type.Name + "";
        }
    }
    string ReturnType(Method m){
       if (m.Type.Name.Contains("ProxyResult") && m.Type.IsGeneric)
       {
            return string.Format("OperationResult<{0}>",GetTypeName(m.Type.Unwrap()));
       }
        return "OperationResult<any>";
    }

    string GetTypeName(Type type){
        if (type.IsGeneric && !type.IsEnumerable){
            var name = type.Name;
            if (name.IndexOf("<") > 0){
                name = name.Substring(0,type.Name.IndexOf("<"));
            }
            return string.Format("ProxyModel.{0}<{1}>", name, GetTypeName(type.Unwrap()));
        }

        if (type.IsPrimitive){
            return type.Name;
        }

        return string.Format("ProxyModel.{0}", type.Name);;
    }

    string ActionLinkMethod(Method c) => $"{c.name}Link";
}

/* tslint:disable */

import { HttpService } from '@infrastructure/transport/httpservice'
import OperationResult from '@infrastructure/OperationResult'
import { AppConfig } from '@infrastructure/config/config'

$Classes(c => c.Name.EndsWith("Controller") && !c.Attributes.Any(att=>att.Name.Contains("TSControllerIgnore")))[
export class $Name {
    $Methods(c=> !c.Attributes.Any(att=>att.Name.Contains("TSActionIgnore") || att.Name.Contains("TSActionLink") || att.Name.Contains("TSFileResult")))[
        public $name = ($Parameters[$param][, ]): Promise<$ReturnType> => {
            const route = `$Url`;
            return HttpService.Instance.request({
                url: this.GetUrl(route, '$Parent','$Name'),
                method: "$HttpMethod",
                data: $RequestData,
                headers: {'X-Requested-With': 'XMLHttpRequest'}
            });
        };
    ]
    $Methods(c=> c.Attributes.Any(att=>att.Name.Contains("TSActionLink")) && c.Attributes.Any(att=>att.Name.Contains("HttpPost")))[
        public $ActionLinkMethod = (): string => {
            const route = `$Url`;
            return `/${AppConfig.Instance.getTenant()}/${this.GetUrl(route, "$Parent","$Name")}`;
        };
    ]
    $Methods(c=> c.Attributes.Any(att=>att.Name.Contains("TSActionLink")) && !c.Attributes.Any(att=>att.Name.Contains("HttpPost")))[
        public $ActionLinkMethod = ($Parameters[$param][, ]): string => {
            const route = `$Url`;
            return `/${AppConfig.Instance.getTenant()}/${this.GetUrl(route, "$Parent","$Name")}`;
        };
    ]
    private GetUrl(route: string, controller : string,  action : string): string {
        controller = controller.replace('Controller','');

        const param : string[] = route.split("?");
        if(param[1]){
            return `${controller}/${action}?${param[1]}`;
        }

        return `${controller}/${action}`;
    }
}]
