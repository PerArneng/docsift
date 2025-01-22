namespace DocSift.Library;


public class DummySourceDocumentExtractor : ISourceDocumentExtractor
{
    public Task<SourceInfo> ExtractSourceInfoAsync(string filePath)
    {
        return Task.FromResult(new SourceInfo(
            Amount: 100,
            Currency: "USD",
            CompanyName: "Acme Inc.",
            MainService: "Consulting",
            VatAmount: 20
        ));
    }
}