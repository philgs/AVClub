---
document type: cmdlet
external help file: AVClub.dll-Help.xml
HelpUri: ''
Locale: en-US
Module Name: AVClub
ms.date: 01/14/2026
PlatyPS schema version: 2024-05-01
title: Get-FileMetadata
---

# Get-FileMetadata

## SYNOPSIS

Reads the tags and metadata from a given media file.

## SYNTAX

## DESCRIPTION

Reads the tag and metadata values for a given media file and returns the result as a custom object.

## EXAMPLES

### Example 1: Get the metadata of a MP3 file

Get-FileMetadata -FilePath "C:\mysong.mp3"

## PARAMETERS

### -FilePath

The location of the media file.

```yaml
Type: System.String
Aliases: []
ParameterSets:
- Name: (All)
  Position: 0
  IsRequired: true
  ValueFromPipeline: true
  ValueFromPipelineByPropertyName: false
  ValueFromRemainingArguments: false
AcceptedValues: []
HelpMessage: ''
```

### CommonParameters

This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable,
-InformationAction, -InformationVariable, -OutBuffer, -OutVariable, -PipelineVariable,
-ProgressAction, -Verbose, -WarningAction, and -WarningVariable. For more information, see
[about_CommonParameters](https://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

## OUTPUTS

## NOTES

{{ Fill in the Notes }}
