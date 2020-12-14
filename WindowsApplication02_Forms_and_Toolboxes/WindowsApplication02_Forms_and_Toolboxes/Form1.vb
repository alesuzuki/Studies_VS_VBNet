Public Class Form1

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        'PROPERTY AutoScaleMode
        'None = Disable automatic scaling / Don't let user alter form size
        'Font = scale according with font size / Do let user alter form size
        'Dpi = scale according monitor's resolution using inches / Do let user alter form size
        'Inherit = scale according forms control acoording "AutoScaleMode from Father's class / Do let user alter form size
        Me.AutoScaleMode = Windows.Forms.AutoScaleMode.Dpi



    End Sub
End Class
