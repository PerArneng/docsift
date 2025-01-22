

using Microsoft.Extensions.DependencyInjection;
using DocSift.Library;
using System.CommandLine;

var services = new ServiceCollection();
services.AddTransient<ISourceDocumentExtractor, DummySourceDocumentExtractor>();
var serviceProvider = services.BuildServiceProvider();


var fileOption = new Option<string>(
    name: "--file",
    description: "The source document file path",
    getDefaultValue: () => string.Empty)
{
    IsRequired = true
};
fileOption.AddAlias("-f");

var renameCommand = new Command("rename", "Rename files based on source document");
renameCommand.AddOption(fileOption);

var rootCommand = new RootCommand();
rootCommand.Name = "docsift";
rootCommand.Description = "A tool to sift through source documents";
rootCommand.AddCommand(renameCommand);

await rootCommand.InvokeAsync(args);



ISourceDocumentExtractor extractor = serviceProvider.GetRequiredService<ISourceDocumentExtractor>();
var result = await extractor.ExtractSourceInfoAsync("");


Console.WriteLine("Hello, World!");
