#define AppVer GetFileVersion(AddBackslash(SourcePath) + "ImageResizer.exe")

[Setup]
AppName=ImageResizer
AppVerName=ImageResizer {#AppVer}
AppPublisher=Nicholas Parks Young
AppPublisherURL=https://github.com/Alarm-Siren/ImageResizer
AppSupportURL=https://github.com/Alarm-Siren/ImageResizer/issues
AppUpdatesURL=https://github.com/Alarm-Siren/ImageResizer/releases
AppVersion={#AppVer}
DefaultDirName={pf}\ImageResizer
DefaultGroupName=ImageResizer
OutputDir=ImageResizer\bin\Release
OutputBaseFilename=ImageResizer-{#AppVer}-setup
Compression=lzma/max
PrivilegesRequired=admin
SolidCompression=yes
LicenseFile=LICENSE.txt

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
Source: "ImageResizer\bin\Release\ImageResizer.exe"; DestDir: "{app}";
Source: "ImageResizer\bin\Release\ImageResizer.exe.config"; DestDir: "{app}";
Source: "ImageResizer\bin\Release\ImageResizer.pdb"; DestDir: "{app}";
Source: "LICENSE.txt"; DestDir: "{app}";
Source: "README.md"; DestDir: "{app}";

[Icons]
Name: "{group}\ImageResizer"; Filename: "{app}\ImageResizer.exe"
Name: "{group}\{cm:UninstallProgram,Image Resizer}"; Filename: "{uninstallexe}"
Name: "{commondesktop}\ImageResizer"; Filename: "{app}\ImageResizer.exe"; Tasks: desktopicon

[Run]
Filename: "{app}\ImageResizer.exe"; Description: "{cm:LaunchProgram,ImageResizer}"; Flags: nowait postinstall skipifsilent

[CustomMessages]
dotnetmissing=This application needs Microsoft .NET Framework 3.5 which is not yet installed. Would you like to download it now?

[Code]
function InitializeSetup(): Boolean;
var
    ErrorCode: Integer;
    netFrameWorkInstalled : Boolean;
    isInstalled: Cardinal;
begin
  result := true;

    // Check for the .Net 3.5 framework
  isInstalled := 0;
  netFrameworkInstalled := RegQueryDWordValue(HKLM, 'SOFTWARE\Microsoft\NET Framework Setup\NDP\v3.5', 'Install', isInstalled);
  if ((netFrameworkInstalled)  and (isInstalled <> 1)) then netFrameworkInstalled := false;

  if netFrameworkInstalled = false then
  begin
    if (MsgBox(ExpandConstant('{cm:dotnetmissing}'),
        mbConfirmation, MB_YESNO) = idYes) then
    begin
      ShellExec('open',
      'http://www.microsoft.com/downloads/details.aspx?FamilyID=333325fd-ae52-4e35-b531-508d977d32a6&DisplayLang=en',
      '','',SW_SHOWNORMAL,ewNoWait,ErrorCode);
    end;
    result := false;
  end;

end;




