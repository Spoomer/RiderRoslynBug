using Microsoft.CodeAnalysis;

namespace RiderRoslynBug.Generator;

[Generator]
public class Generator : ISourceGenerator {

    public void Initialize(GeneratorInitializationContext context) {
        
    }

    public void Execute(GeneratorExecutionContext context) {
        const string content = """
                               namespace RiderRoslynBug.App;

                               public class Test {
                               
                                     public void Run() {}

                               }
                               """;

        context.AddSource("Test.g.cs", content);
    }

}