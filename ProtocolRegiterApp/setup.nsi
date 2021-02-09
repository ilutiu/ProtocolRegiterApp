; WinVer.nsh was added in the same release that RequestExecutionLevel so check
; if ___WINVER__NSH___ is defined to determine if RequestExecutionLevel is
; available.
!include /NONFATAL WinVer.nsh
!ifdef ___WINVER__NSH___
  RequestExecutionLevel user
!else
  !warning "Installer will be created without Vista compatibility.$\n            \
            Upgrade your NSIS installation to at least version 2.21 to resolve."
!endif

!define PRODUCT_NAME "ProtocolRegiterApp"
!define SETUP_NAME "ProtocolRegiterAppSetup.exe"
!define PRODUCT_VERSION "1.0"


OutFile ${SETUP_NAME}
Name "${PRODUCT_NAME} ${PRODUCT_VERSION}"


;Default installation folder
InstallDir "$PROGRAMFILES\ProtocolRegiterApp"

;Get installation folder from registry if available InstallDirRegKey HKLM 
;"Software\CP Lab" ""


ShowInstDetails show
ShowUnInstDetails show 

SetCompressor /SOLID lzma
SetCompressorDictSize 12

;Request application privileges for Windows Vista RequestExecutionLevel user 
;Could be 'admin'

Section "Dummy Section" SecDummy

SetOutPath "$INSTDIR"
# specify file to go in output path
File ProtocolRegiterApp.exe
File ProtocolRegiterApp.exe.config

;Store installation folder
WriteRegStr HKCU "Software\ProtocolRegiterApp" "" $INSTDIR


!ifdef ___WINVER__NSH___
  ${If} ${AtLeastWinVista}
!endif


;Create uninstaller
WriteUninstaller "$INSTDIR\Uninstall.exe"


!ifdef ___WINVER__NSH___
  ${Else}
    DetailPrint "This plugin only works on Windows Vista or greater"
  ${EndIf}
!endif

SectionEnd 

Page Components
Page InstFiles

!include FileFunc.nsh
!include LogicLib.nsh


Section "Register protocol" ; This example uses HKCU\Software\Classes and not HKCR so it works as non-admin
WriteRegStr HKCU "Software\Classes\PAM" "" "URL:PAM Protocol"
WriteRegStr HKCU "Software\Classes\PAM" "FriendlyTypeName" "PAM protocol"
WriteRegStr HKCU "Software\Classes\PAM" "URL Protocol" ""
; Optional: UseOriginalUrlEncoding
WriteRegExpandStr HKCU "Software\Classes\PAM\DefaultIcon" "" "%SystemRoot%\system32\shell32.dll,6"
WriteRegStr HKCU "Software\Classes\PAM\shell" "" "open"
WriteRegStr HKCU "Software\Classes\PAM\shell\open" "FriendlyAppName" "PAM app for PAM protocol"
WriteRegStr HKCU "Software\Classes\PAM\shell\open\command" "" '"$INSTDIR\\ProtocolRegiterApp.exe" /uri="%1" /params="%2 %3 %4"'
SectionEnd



Section "Uninstall"

Delete "$INSTDIR\Uninstall.exe"

RMDir "$INSTDIR"

DeleteRegKey /ifempty HKCU "Software\ProtocolRegiterApp"
DeleteRegKey HKCU "Software\Classes\PAM"

SectionEnd 

