Public Class FormCadence
    Dim cQueue As Queue
    Dim txtLines As String
    Dim txtQueue = New Queue()


    Private Sub FormCadence_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cQueue = New Queue()
        Me.KeyPreview = True

    End Sub

    Private Sub FormCadence_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        Call Calcualae_Cadence()

    End Sub

    Private Sub FormCadence_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Me.TopMost = True
    End Sub


    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Dim box As New FormDetail
        box.rtbDetail.Text = txtLines
        box.Show()
    End Sub

    Private Sub Calcualae_Cadence()

        Dim currentTime As DateTime
        currentTime = DateTime.Now
        cQueue.Enqueue(currentTime)

        'start counting only after first 10 taps to set the rhythm, also always use average of 10 measurements for cadence.
        If cQueue.Count > 10 Then
            cQueue.Dequeue()
            Dim obj As DateTime
            Dim pObj As DateTime
            Dim cDuration As TimeSpan
            Dim total As Long

            'total duration for 10 taps
            For Each obj In cQueue
                If pObj.Year <> 1 Then
                    'Console.WriteLine("pObj {0}", pObj)
                    'Console.WriteLine("obj {0}", obj)
                    cDuration = obj - pObj
                    total = total + cDuration.TotalMilliseconds
                    'Console.WriteLine(cDuration.TotalMilliseconds)
                End If
                pObj = obj
            Next obj

            'Cadence calculation
            Dim cadence As Long
            cadence = (60000) / (total / (cQueue.Count - 1))
            'Console.WriteLine("Total {0}", total)
            'Console.WriteLine("Count {0}", cQueue.Count)
            'Console.WriteLine("Cadence {0}", cadence * 2)

            Dim txtLine As String

            txtLine = "Cadence " & cadence * 2
            txtQueue.Enqueue(txtLine)
            If (txtQueue.Count > 25) Then
                txtQueue.Dequeue()
            End If

            'update the cadence on the label

            lblCadence.Text = cadence
            txtLines = ""
            Dim obj2 As String
            For Each obj2 In txtQueue
                txtLines = txtLines & obj2 & vbCrLf
            Next
        End If


    End Sub


End Class