Module Main
    Dim steampath = ""
    Dim p() As Process
    Sub Main()
        Console.Title = "Cylops's Old Steam Friend Interface Launcher"
        Console.ForegroundColor = ConsoleColor.DarkYellow
        Console.WriteLine("Cylops's Old Steam Friend Interface Launcher")
        Console.WriteLine("---------------------------------------------")
        System.Threading.Thread.Sleep(1000)
        Console.ForegroundColor = ConsoleColor.Green
        Console.WriteLine("Auf der Suche nach Steams Standort...")
        System.Threading.Thread.Sleep(1500)
        Dim readValue = My.Computer.Registry.GetValue(
    "HKEY_LOCAL_MACHINE\SOFTWARE\Valve\Steam", "InstallPath", Nothing)
        If My.Computer.FileSystem.DirectoryExists(readValue) Then
            If My.Computer.FileSystem.FileExists(readValue & "/Steam.exe") Then
                steampath = readValue
                Console.WriteLine("Steam wurdu gefunden =>")
                Console.ForegroundColor = ConsoleColor.Red
                Console.Write(readValue + "!")
            Else
                MsgBox("Steam wurde woanders hinbewegt. Bitte ziehe zurück zu seinem alten Standort! 7781", "Error!")
                End
            End If
        Else
            MsgBox("Kann den Standort von Steam nicht lesen! Als Administrator ausführen! 93834", "Error!")
            End
        End If
        Console.ForegroundColor = ConsoleColor.DarkYellow
        Console.WriteLine(" ")
        Console.WriteLine("---------------------------------------------")
        p = Process.GetProcessesByName("Steam")
        If p.Count > 0 Then
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine("Steam wurde geöffnet. Wir werden für sie  den Program schließen")
            Try
                Process.GetProcessesByName("Steam")(0).Kill()
            Catch ex As Exception
                MsgBox("Ein Fehler ist aufgetreten. Fehler ist >>" + ex.ToString, "Error!")
            End Try
            Console.WriteLine(" ")
            Console.ForegroundColor = ConsoleColor.DarkYellow
            Console.WriteLine("Initiieren Steam [w/ Old Friends UI]")
            System.Threading.Thread.Sleep(2000)
            Process.Start(readValue + "/Steam.exe", "-nofriendsui -nochatui")
            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine("Steam begonnen mit Erfolg. Dieses Programm wird sich in 5 Sekunden schließen...")
            System.Threading.Thread.Sleep(5000)
            End
        Else
            Console.WriteLine("Initiieren Steam [w/ Old Friends UI]")
            System.Threading.Thread.Sleep(2000)
            Process.Start(readValue + "/Steam.exe", "-nofriendsui -nochatui")
            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine("Steam begonnen mit Erfolg. Dieses Programm wird sich in 5 Sekunden schließen...")
            System.Threading.Thread.Sleep(5000)
            End
        End If
    End Sub
End Module
