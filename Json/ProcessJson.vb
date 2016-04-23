Imports Newtonsoft.Json

Public Class ProcessJson



    Private rootObj As Rootobject
    Private outPath As String
    Private DwellerCsvQueue As New Queue(Of DwellerCsv)


    Public Sub New(jsonPath As String, outputPath As String)
        outPath = outputPath
        Using jsonReader As IO.TextReader = New IO.StreamReader(jsonPath)

            Dim readString = jsonReader.ReadToEnd

            rootObj = JsonConvert.DeserializeObject(Of Rootobject)(readString)

        End Using

        For Each d In rootObj.dwellers.dwellers.OrderBy(Function(dw) dw.serializeId)
            DwellerCsvQueue.Enqueue(GetCsvDwellerClass(d))
        Next


        Call InitializeCsvHelper()

        Do While DwellerCsvQueue.Count > 0

            CsvWriter.WriteRecord(Of DwellerCsv)(DwellerCsvQueue.Dequeue)

            If (DwellerCsvQueue.Count Mod 10 = 0) Then OutputWriter.Flush()

        Loop


        OutputWriter.Flush()

        OutputWriter.Dispose() : OutputWriter = Nothing
        CsvWriter.Dispose() : CsvWriter = Nothing

        Beep()

    End Sub



    Private Function GetCsvDwellerClass(dIn As Dweller) As DwellerCsv
        Dim NewDweller As New DwellerCsv

        If dIn.equipedOutfit IsNot Nothing Then NewDweller.EquipedOutfit = dIn.equipedOutfit.id

        If dIn.equippedPet IsNot Nothing Then
            NewDweller.EquipedPet = dIn.equippedPet.id
            NewDweller.EquipedPetBonus = dIn.equippedPet.extraData.bonus
            NewDweller.EquipedPetBonusValue = dIn.equippedPet.extraData.bonusValue
        End If

        If dIn.equipedWeapon IsNot Nothing Then NewDweller.EquipedWeapon = dIn.equipedWeapon.id

        NewDweller.ExpCurrentVal = dIn.experience.experienceValue
        NewDweller.FirstName = dIn.name
        NewDweller.Gender = If(dIn.gender = 2, "Male", "Female")
        NewDweller.Happiness = dIn.happiness.happinessValue
        NewDweller.HealthCurrent = dIn.health.healthValue
        NewDweller.HealthMaximum = dIn.health.maxHealth
        NewDweller.LastName = dIn.lastName
        NewDweller.Level = dIn.experience.currentLevel
        NewDweller.RadsCurrent = dIn.health.radiationValue
        NewDweller.Rarity = dIn.rarity
        NewDweller.SerializedId = dIn.serializeId
        NewDweller.UniqueData = dIn.uniqueData
        NewDweller.WastelandDays = dIn.daysOnWasteland
        NewDweller.WastelandHours = dIn.hoursOnWasteland


        Return NewDweller

    End Function

    Private CsvWriter As CsvHelper.CsvWriter
    Private CsvConfig As CsvHelper.Configuration.CsvConfiguration
    Private OutputWriter As IO.TextWriter
    Private Sub InitializeCsvHelper()
        CsvConfig = New CsvHelper.Configuration.CsvConfiguration
        Dim CsvMap = CsvConfig.AutoMap(Of DwellerCsv)()

        OutputWriter = New IO.StreamWriter(outPath, append:=False)
        CsvWriter = New CsvHelper.CsvWriter(OutputWriter, CsvConfig)

        CsvWriter.WriteHeader(Of DwellerCsv)()

    End Sub




End Class
