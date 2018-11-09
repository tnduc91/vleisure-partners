${
    using Typewriter.Extensions.Types;

    string propName(Typewriter.CodeModel.Property c)
    {
        if (c.Type.IsNullable){
            return c.name + "?";
        }
        else{
            return c.name;
        }
    }

    string GenericClass(Class classs)
    {
        var isGeneric = classs.IsGeneric;
        if (isGeneric){
            return "<"+classs.TypeParameters.First().Name+">";
        }
        return "";
    }

    string ExtendBaseClass(Class classs)
    {
        var isHaveBaseClass = classs.BaseClass != null;
        if (isHaveBaseClass){
            return "extends " + classs.BaseClass.Name;
        }
        return "";
    }

    string DefaultValue(Typewriter.CodeModel.Property property)
    {
        return property.Type.Default();
    }

    bool AllowType(Type type){
        return type.Interfaces.Any(i=>i.Name.Contains( "ITypeProxy")) || type.IsPrimitive || (type.IsGeneric && AllowType(type.TypeArguments.First()));
    }

    string propType(Typewriter.CodeModel.Property c)
    {
       if (c.Type.IsEnum){
          return "number";
       }
       else{
          return c.Type;
       }
    }
}
/* tslint:disable */
declare namespace ProxyModel{
    $Classes(c=> c.Interfaces.Any(i=>i.Name.Contains( "ITypeProxy")) || c.Name.EndsWith("ViewModel"))[
    export interface $Name$GenericClass $ExtendBaseClass {
        $Properties(c => !c.Attributes.Any(att => att.Name.Contains("TSPropertyIgnore")))[
        $propName: $propType;]
        }
    ]
}