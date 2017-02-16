@REM nuget install -outputDirectory Packages %1 -version %2
@REM console: Update-Package -Reinstall

nuget install -outputDirectory Packages   NUnit            -version 3.5.0
nuget install -outputDirectory Packages   NUnit.Runners    -version 3.2.1
nuget install -outputDirectory Packages   NUnitTestAdapter -version 2.0.0

nuget restore Xwt.sln
  
@PAUSE