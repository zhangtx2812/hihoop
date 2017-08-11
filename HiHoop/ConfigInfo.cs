using Sardf;

namespace HiHoop
{
    public class ConfigInfo
    {
        public string ServerWebSite { get; set; }
        public VersionInfo VersionInfo { get; set; }
        public DatabaseInfo DatabaseInfo { get; set; }
    }

    public class VersionInfo
    {
        public string VersionNo { get; set; }
        public string SourceFileUrl { get; set; }
    }
}
