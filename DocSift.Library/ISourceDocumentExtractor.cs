namespace DocSift.Library;

public record struct SourceInfo(
    int Amount,
    string Currency,
    string CompanyName,
    string MainService,
    int VatAmount
);


public interface ISourceDocumentExtractor
{
    Task<SourceInfo> ExtractSourceInfoAsync(string filePath);
}
