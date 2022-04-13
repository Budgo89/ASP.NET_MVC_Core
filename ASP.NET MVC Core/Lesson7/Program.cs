using Lesson7;

var scanDisk = new ScanDisk();
var statusList = scanDisk.GetStatus();
var reportGenerator = new ReportGenerator();
reportGenerator.GenerateReport(statusList);
Console.WriteLine();