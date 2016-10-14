::
:: Microsoft Azure SDK for Net - Generate library code
:: Copyright (C) Microsoft Corporation. All Rights Reserved.
::

@echo off
set autoRestVersion=0.17.0-Nightly20161012
if  "%1" == "" (
    set specFile="D:\GitHub\azure-rest-api-specs\arm-cdn\2016-10-02\swagger\cdn.json"
) else (
    set specFile="%1"
)
set repoRoot=%~dp0..\..\..\..
set generateFolder=%~dp0Generated

if exist %generateFolder% rd /S /Q  %generateFolder%
call "%repoRoot%\tools\autorest.gen.cmd" %specFile% Microsoft.Azure.Management.Cdn %autoRestVersion% %generateFolder% "MICROSOFT_MIT" "-FT 2"
