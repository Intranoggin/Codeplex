@ECHO OFF
ECHO Copying DLL ...
xcopy /y "..\bin\debug\MyLocalBroadband.Logging.dll" .\GAC
ECHO Running WSPBuilder ...
.\WSPBuilder\wspbuilder -wspname MyLocalBroadband.Logging.wsp -BuildCas false -SolutionId 91271725-6bfe-4e15-9091-abcdb99c2c41
ECHO Copying WSP to Setup ...
xcopy /y "..\WSP\MyLocalBroadband.Logging.wsp" ..\Setup