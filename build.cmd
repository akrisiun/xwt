@REM cd "%~dp0"

:build
@set msbuild="%ProgramFiles(x86)%\msbuild\15.0\Bin\MSBuild.exe"
@if not exist %msbuild% @set msbuild="%ProgramFiles(x86)%\MSBuild\12.0\Bin\MSBuild.exe"
@if not exist %msbuild% @set msbuild="%ProgramFiles(x86)%\msbuild\15.0\Bin\MSBuild.exe"
@if not exist %msbuild% @set msbuild="%ProgramFiles%\MSBuild\14.0\Bin\MSBuild.exe"
@if not exist %msbuild% @set msbuild="%ProgramFiles(x86)%\MSBuild\12.0\Bin\MSBuild.exe"
@if not exist %msbuild% @set msbuild="%ProgramFiles%\MSBuild\12.0\Bin\MSBuild.exe"

%msbuild% /m /nr:false /v:M /p:Configuration=Debug  /p:Platform="Any CPU" Build\Xwt-WPF.sln

%msbuild% /m /nr:false /v:M /p:Configuration=Debug  TestApps\WpfTest\Xwt.WPF\Xwt.WPF.csproj
%msbuild% /m /nr:false /v:M /p:Configuration=Debug  TestApps\WpfTest\WpfTest.csproj

@PAUSE