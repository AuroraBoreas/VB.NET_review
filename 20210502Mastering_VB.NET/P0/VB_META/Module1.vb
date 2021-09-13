Imports VB_META
Module Module1

    Sub Main()
        VBMeta.Meta.oTopic("varDemo")
        VBMeta.Meta.varDemo()

        VBMeta.Meta.oTopic("funcDemo")
        VBMeta.Meta.funcDemo()

        Console.WriteLine(vbCrLf + "press any key to continue...")
        Console.Read()
    End Sub
End Module
