@{
    RootModule           = 'AVClub.dll'
    ModuleVersion        = '1.0.0'
    GUID                 = 'cfd557eb-ce63-4b3b-a4d3-f740a8336d6b'
    Author               = 'Phil Silva'
    Copyright            = 'Copyright (c) Phil Silva. All rights reserved.'
    Description          = 'A PowerShell module for working with metadata of audio and video files'
    PowerShellVersion    = '7.0'
    CompatiblePSEditions = @('Core')
    CmdletsToExport      = @(
        'Get-FileMetadata'
        'Set-FileMetadata'
    )
    FileList = @(
        'AVClub.dll-Help.xml'
    )
    PrivateData          = @{
        PSData = @{
            Tags       = @(
                'audio'
                'video'
                'metadata'
                'powershell'
            )
            LicenseUri = 'https://github.com/philgs/AVClub/blob/main/LICENSE'
            ProjectUri = 'https://github.com/philgs/AVClub'
        }
    }
}