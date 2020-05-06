using Microsoft.Build.Evaluation;
using Microsoft.CSharp;
using System;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Northwind_Generate
{
    public class MyClassBuilder
    {

       
        Assembly asm = Assembly.GetExecutingAssembly();
        CodeTypeDeclaration myClass;
        CodeCompileUnit myAssembly;
        Project project;
        public MyClassBuilder(string ClassName, Project project)
        {
            this.project = project;
            CodeNamespace myNamespace = new CodeNamespace(asm.GetName().Name);
            myNamespace.Imports.Add(new CodeNamespaceImport("System"));
            myClass = new CodeTypeDeclaration(ClassName.Contains(" ")? ClassName.Replace(" ",""): ClassName);
            myClass.IsClass = true;
            myClass.TypeAttributes = TypeAttributes.Public;
            myNamespace.Types.Add(myClass);
            myAssembly = new CodeCompileUnit();
            myAssembly.Namespaces.Add(myNamespace);
        }
        public void AddProperties(Dictionary<string, Type> props)
        {
            foreach (KeyValuePair<string, Type> item in props)
            {
                CodeMemberField mymemberfield = new CodeMemberField(item.Value, "_"+item.Key);
                myClass.Members.Add(mymemberfield);
                var prop = new CodeMemberProperty();
                prop.Attributes = MemberAttributes.Public | MemberAttributes.Final;
                prop.Name = item.Key;
                prop.Type = new CodeTypeReference(item.Value);
                CodeSnippetExpression getsnippet = new CodeSnippetExpression("return _"+item.Key);
                CodeSnippetExpression setsnippet = new CodeSnippetExpression("_"+item.Key+"=value");
                prop.GetStatements.Add(getsnippet);
                prop.SetStatements.Add(setsnippet);
                myClass.Members.Add(prop);
            }
        }
        public void GenerateCSharpCode(string filename)
        {
            CSharpCodeProvider provider = new CSharpCodeProvider(); //Belli bir dilde kaynak kodu oluşturmak için kullanılır.
            CodeGeneratorOptions options = new CodeGeneratorOptions();
            options.BracingStyle = "C";
            
            using (StreamWriter sourceWriter = new StreamWriter(string.Format(@"C:\Users\ALTAN EMRE\source\repos\Northwind\Northwind_Generate\{0}.cs", filename)))
            {
                provider.GenerateCodeFromCompileUnit(myAssembly, sourceWriter, options);
            }
            project.AddItem("Compile", filename + ".cs");
            project.Save();

        }

    }
}
