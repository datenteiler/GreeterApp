# GreeterApp

Dieses Programm besteht aus drei Komponenten:

1) Die Klasse mit der Anwendungslogik im Ordner "GreeterClass"
2) Das Konsolenprogramm im Ordner "GreeterCmd"
3) Das oder die PowerShell Cmdlets im Ordner "GreeterCmdlet"

Alle drei Komponenten müssen noch mit dem Befehl ```dotnet build``` kompiliert bzw. gebaut werden. 

Das funktioniert beispielsweise mit dem folgenden Befehl in der PowerShell:

```
foreach ($item in $(dir -Directory).Name )
{
  cd $item
  dotnet build
  cd ..
}
```

Sind alle drei Komponenten fertig, wird das PowerShell-Modul geladen und das Cmdlet Get-Greeting kann ausgeführt werden:

```
ipmo .\GreeterCmdlet\bin\Debug\netstandard2.0\GreeterCmdlet.dll
Get-Greeting Welt
```

Das ausführbare Programm für die Konsole cmd.exe kann im Ordner "GreeterCmd" mit dem folgenden Befehl gestartet werden:

```
dotnet run Welt
```

Oder man führt die EXE selbst aus:

```
C:\GreeterApp-main> GreeterCmd\bin\Debug\netcoreapp3.1\GreeterCmd.exe Welt
Hallo Welt!
Tschüss Welt!
```

