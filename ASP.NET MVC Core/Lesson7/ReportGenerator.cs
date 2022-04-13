using TemplateEngine.Docx;

namespace Lesson7;

internal class ReportGenerator
{
    public void GenerateReport(List<DiskStatus> diskStatusList, string output = "")
    {
        if (string.IsNullOrWhiteSpace(output))
        {
            output = Path.Combine(Directory.GetCurrentDirectory(),
                "CompanyReport.docx");
        }
        if (File.Exists(output))
        {
            File.Delete(output);
        }
        File.Copy("sample.docx", output);

        List<TableRowContent> rows = new List<TableRowContent>();
        
        foreach (var diskStatus in diskStatusList)
        {
            rows.Add(new TableRowContent(new List<FieldContent>
            {
                new FieldContent(DataConst.NameDisk, diskStatus.NameDisk),
                new FieldContent(DataConst.SizeDisk, diskStatus.SizeDisk.ToString()),
                new FieldContent(DataConst.BusyDisk, diskStatus.BusyDisk.ToString()),
                new FieldContent(DataConst.FreeDisk, diskStatus.FreeDisk.ToString())
            }));
        }

        var valuesToFill = new Content(
            new FieldContent(DataConst.TotalSizeDick, diskStatusList.Sum(x => x.SizeDisk).ToString()),
            new FieldContent(DataConst.TotalOccupiedDisk, diskStatusList.Sum(x => x.BusyDisk).ToString()),
            new FieldContent(DataConst.TotalFreeDisk, diskStatusList.Sum(x => x.FreeDisk).ToString()),
            TableContent.Create(DataConst.ConditionDisk, rows));
        using (var outputDocument = new TemplateProcessor(output)
                   .SetRemoveContentControls(true))
        {
            outputDocument.FillContent(valuesToFill);
            outputDocument.SaveChanges();

        }

    }

}
