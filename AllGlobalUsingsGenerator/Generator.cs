using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Text;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading;

namespace AllGlobalUsingsGenerator;

[Generator]
public class Generator : IIncrementalGenerator
{
    public void Initialize(IncrementalGeneratorInitializationContext context)
    {
        var data = context.CompilationProvider.Select(
            static (compilation, _) =>
            {
                var namespaces = FindNamespaces(compilation);
                return namespaces;
            });

        context.RegisterSourceOutput(data, GenerateSource);
    }

    private static ImmutableHashSet<string> FindNamespaces(Compilation c)
    {
        return ImmutableHashSet.CreateRange(GetTypes(c.GlobalNamespace));

        IEnumerable<string> GetTypes(INamespaceSymbol ns)
        {
            foreach (var innerNamespace in ns.GetNamespaceMembers())
            {
                foreach (var innerType in GetTypes(innerNamespace))
                {
                    yield return innerType;
                }
            }

            // Don't output empty namespaces, or the global namespace
            if (!ns.IsGlobalNamespace &&
                ns.GetTypeMembers().FirstOrDefault() is { } type &&
               !SymbolEqualityComparer.Default.Equals(type.ContainingAssembly, c.Assembly))
            {
                yield return ns.ToDisplayString(SymbolDisplayFormat.FullyQualifiedFormat);
            }
        }
    }

    private static void GenerateSource(SourceProductionContext context, ImmutableHashSet<string> namespaces)
    {
        var sb = new StringBuilder();
        sb.AppendLine();
        foreach (var ns in namespaces.OrderBy(n => n))
        {
            sb.AppendLine($"global using {ns};");
        }

        context.AddSource($"all_global_usings.generated.cs", SourceText.From(sb.ToString(), Encoding.UTF8));
    }
}
