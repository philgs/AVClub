using System.Management.Automation;

namespace AVClub
{
    [Cmdlet(VerbsCommon.Get, "FileMetadata")]
    [OutputType(typeof(PSObject))]
    public class GetFileMetadataCmdlet : PSCmdlet
    {
        [Parameter(Position = 0, Mandatory = true, ValueFromPipeline = true)]
        [ValidatePathExists]
        public string FilePath { get; set; }

        protected override void ProcessRecord()
        {
            WriteVerbose("Opening file (read-only) for metadata retrieval");
            using (var f = TagLib.File.Create(new ReadOnlyFileAbstraction(FilePath)))
            {
                var psObj = new PSObject();
                foreach (var prop in f.Tag.GetType().GetProperties())
                    psObj.Properties.Add(new PSNoteProperty(prop.Name, prop.GetValue(f.Tag)));

                WriteObject(psObj);
            }
        }
    }
}