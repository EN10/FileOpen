Module Module1

    Dim File As String = "Sample.txt"
    Dim TextLine As String

    Sub Main()
        Dim Choice As String = ""
        While Choice <> "q"
            Console.WriteLine("(r)ead or (w)rite or (q)uit")
            Choice = Console.ReadLine
            Console.Clear()
            If Choice = "r" Then ReadFile()
            If Choice = "w" Then WriteFile()
        End While
    End Sub

    Sub ReadFile()
        ' Open file.
        FileOpen(1, File, OpenMode.Input)
        ' Loop until end of file.
        While Not EOF(1)
            ' Read line into variable.
            TextLine = LineInput(1)
            ' Print to the console.
            Console.WriteLine(TextLine)
        End While
        FileClose(1)
    End Sub

    Sub WriteFile()
        ' Open file.
        FileOpen(1, File, OpenMode.Output)
        ' Stop writing on condition
        ' Read line into variable.
        TextLine = Console.ReadLine
        ' Print text to file.
        PrintLine(1, TextLine)
        FileClose(1)
    End Sub

    Sub WriteFile2()
        Dim ReadKey As ConsoleKeyInfo
        FileOpen(1, File, OpenMode.Output)
        ' Stop when First Key Press = F10 + Enter
        While ReadKey.Key <> ConsoleKey.End
            ReadKey = Console.ReadKey
            TextLine = ReadKey.KeyChar + Console.ReadLine
            PrintLine(1, TextLine)
        End While
        FileClose(1)

    End Sub

End Module