@echo off
..\tools\merge-settings.exe -w settings.whitelist -u "%USERPROFILE%\Documents\Visual Studio 2012\Settings\CurrentSettings.vssettings" -t "editor.vssettings" -o merged.vssettings
