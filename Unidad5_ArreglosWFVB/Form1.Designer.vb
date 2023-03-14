<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnSumarFilas = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnSumarColumnas = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSumarFilas
        '
        Me.btnSumarFilas.Location = New System.Drawing.Point(118, 52)
        Me.btnSumarFilas.Name = "btnSumarFilas"
        Me.btnSumarFilas.Size = New System.Drawing.Size(102, 46)
        Me.btnSumarFilas.TabIndex = 0
        Me.btnSumarFilas.Text = "Sumar Filas"
        Me.btnSumarFilas.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 147)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(776, 280)
        Me.DataGridView1.TabIndex = 2
        '
        'btnSumarColumnas
        '
        Me.btnSumarColumnas.Location = New System.Drawing.Point(530, 52)
        Me.btnSumarColumnas.Name = "btnSumarColumnas"
        Me.btnSumarColumnas.Size = New System.Drawing.Size(102, 46)
        Me.btnSumarColumnas.TabIndex = 3
        Me.btnSumarColumnas.Text = "Sumar Columnas"
        Me.btnSumarColumnas.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnSumarColumnas)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnSumarFilas)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnSumarFilas As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnSumarColumnas As Button
End Class
