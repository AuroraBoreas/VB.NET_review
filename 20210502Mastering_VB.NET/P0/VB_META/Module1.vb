Imports VB_META
Module Module1

    Sub Main()
        VBMeta.Meta.oTopic("varDemo")
        VBMeta.Meta.varDemo()

        VBMeta.Meta.oTopic("funcDemo")
        VBMeta.Meta.funcDemo()

        VBMeta.Meta.oTopic("statentDemo")
        VBMeta.Meta.statementDemo()

        VBMeta.Meta.oTopic("controlflowDemo")
        VBMeta.Meta.controlflowDemo()

        VBMeta.Meta.oTopic("loopDemo")
        VBMeta.Meta.loopDemo()

        VBMeta.Meta.oTopic("classDemo")
        VBMeta.Meta.classDemo()

        VBMeta.Meta.oTopic("containerDemo")
        VBMeta.Meta.containerDemo()

        VBMeta.Meta.oTopic("algorithmDemo")
        VBMeta.Meta.algorithmDemo()

        Console.WriteLine(vbCrLf + "press any key to continue...")
        Console.Read()

    End Sub
End Module
