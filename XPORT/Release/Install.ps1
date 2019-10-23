Get-ChildItem -Recurse | Unblock-File
#Uninstall
Remove-Item "C:\ProgramData\Autodesk\Revit\Addins\2018\XPORT.addin" -ErrorAction Ignore
Remove-Item "C:\ProgramData\Autodesk\Revit\Addins\2019\XPORT.addin" -ErrorAction Ignore
Remove-Item "C:\ProgramData\Autodesk\Revit\Addins\2018\XPORT" -Recurse -ErrorAction Ignore
Remove-Item "C:\ProgramData\Autodesk\Revit\Addins\2019\XPORT" -Recurse -ErrorAction Ignore
#REVIT 2018
New-Item "C:\ProgramData\Autodesk\Revit\Addins\2018\XPORT" -ItemType directory
Copy-Item "2018\XPORT\XP.png" "C:\ProgramData\Autodesk\Revit\Addins\2018\XPORT"
Copy-Item "2018\XPORT\XPORT.dll" "C:\ProgramData\Autodesk\Revit\Addins\2018\XPORT"
Copy-Item "2018\XPORT.addin" "C:\ProgramData\Autodesk\Revit\Addins\2018"
#REVIT 2019
New-Item "C:\ProgramData\Autodesk\Revit\Addins\2019\XPORT" -ItemType directory
Copy-Item "2019\XPORT\XP.png" "C:\ProgramData\Autodesk\Revit\Addins\2019\XPORT"
Copy-Item "2019\XPORT\XPORT.dll" "C:\ProgramData\Autodesk\Revit\Addins\2019\XPORT"
Copy-Item "2019\XPORT.addin" "C:\ProgramData\Autodesk\Revit\Addins\2019"

PAUSE