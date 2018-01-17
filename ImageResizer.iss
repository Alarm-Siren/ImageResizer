[Setup]
AppName=Image Resizer
AppVerName=Image Resizer; Release: 1.0.1.3
AppPublisher=Shady Industries
AppPublisherURL=http://www.shadyindustries.com/
AppSupportURL=http://www.shadyindustries.com/programs/imageresizer/help.php?v=1.0.1.3
AppUpdatesURL=http://www.shadyindustries.com/programs/imageresizer/version.php?v=1.0.1.3
AppVersion=1.0.1.3
DefaultDirName={pf}\Shady Industries\Image Resizer
DefaultGroupName=Shady Industries\Image Resizer
OutputDir=bin
OutputBaseFilename=setup
Compression=lzma/max
PrivilegesRequired=admin
SolidCompression=yes
LicenseFile=src\license.txt

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
;Main Files
Source: "src\Image Resizer.exe"; DestDir: "{app}";
Source: "src\Image Resizer.exe.config"; DestDir: "{app}";
Source: "src\Image Resizer.pdb"; DestDir: "{app}";
Source: "src\License.txt"; DestDir: "{app}";

[Icons]
Name: "{group}\Image Resizer"; Filename: "{app}\Image Resizer.exe"
Name: "{group}\{cm:UninstallProgram,Image Resizer}"; Filename: "{uninstallexe}"
Name: "{commondesktop}\Image Resizer"; Filename: "{app}\Image Resizer.exe"; Tasks: desktopicon

[Run]
Filename: "{app}\Image Resizer.exe"; Description: "{cm:LaunchProgram,Image Resizer}"; Flags: nowait postinstall skipifsilent

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




