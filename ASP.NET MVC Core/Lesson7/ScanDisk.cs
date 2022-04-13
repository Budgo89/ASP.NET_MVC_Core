namespace Lesson7;

internal class ScanDisk
{
    private List<DiskStatus> _disksStatusList;

    public ScanDisk()
    {
        _disksStatusList = new List<DiskStatus>();
    }

    public List<DiskStatus> GetStatus()
    {
        DriveInfo[] drives = DriveInfo.GetDrives();
        foreach (var disk in drives)
        {
            if (disk.IsReady)
            {
                _disksStatusList.Add(new DiskStatus
                {
                    NameDisk = disk.Name,
                    SizeDisk = disk.TotalSize,
                    FreeDisk = disk.TotalFreeSpace,
                    BusyDisk = disk.TotalSize - disk.TotalFreeSpace
                });
            }

        }

        return _disksStatusList;
    }
}
