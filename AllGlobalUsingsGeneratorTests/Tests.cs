using AllGlobalUsingsGenerator;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Xunit;
using Xunit.Abstractions;

namespace AllGlobalUsingsGeneratorTests;

public class Tests
{
	private readonly ITestOutputHelper _output;

	public Tests(ITestOutputHelper output)
	{
        _output = output;
	}

    [Fact]
    public void Test1()
    {
        string source = @"
namespace Foo
{
    class C
    {
        void M()
        {
        }
    }
}";

        string output = GetGeneratedOutput(source);

        // We just make sure something was output, and not our "Foo" namespace
        Assert.NotNull(output);
        Assert.NotEqual(0, output.Length);
        Assert.DoesNotContain("Foo;", output);
    }

    private string GetGeneratedOutput(string source)
    {
        var syntaxTree = CSharpSyntaxTree.ParseText(source);

        var references = new List<MetadataReference>();
        Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
        foreach (var assembly in assemblies)
        {
            if (!assembly.IsDynamic && !string.IsNullOrWhiteSpace(assembly.Location))
            {
                references.Add(MetadataReference.CreateFromFile(assembly.Location));
            }
        }

        var compilation = CSharpCompilation.Create("foo", new SyntaxTree[] { syntaxTree }, references, new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary));

        IIncrementalGenerator generator = new Generator();

        var driver = CSharpGeneratorDriver.Create(generator);
        driver.RunGeneratorsAndUpdateCompilation(compilation, out var outputCompilation, out var generateDiagnostics);
        Assert.False(generateDiagnostics.Any(d => d.Severity == DiagnosticSeverity.Error), "Failed: " + generateDiagnostics.FirstOrDefault()?.GetMessage());

        string output = outputCompilation.SyntaxTrees.Last().ToString();

        _output.WriteLine(output);

        return output;
    }
}
