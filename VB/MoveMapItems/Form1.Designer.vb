﻿Namespace MoveMapItems
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim vectorItemsLayer1 As New DevExpress.XtraMap.VectorItemsLayer()
            Dim vectorItemsLayer2 As New DevExpress.XtraMap.VectorItemsLayer()
            Dim mapItemStorage1 As New DevExpress.XtraMap.MapItemStorage()
            Dim mapPushpin1 As New DevExpress.XtraMap.MapPushpin()
            Me.mapControl1 = New DevExpress.XtraMap.MapControl()
            DirectCast(Me.mapControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' mapControl1
            ' 
            Me.mapControl1.Dock = System.Windows.Forms.DockStyle.Fill
            vectorItemsLayer1.Name = "ShapefileLayer"
            mapPushpin1.Text = "Drag me"
            mapItemStorage1.Items.Add(mapPushpin1)
            vectorItemsLayer2.Data = mapItemStorage1
            Me.mapControl1.Layers.Add(vectorItemsLayer1)
            Me.mapControl1.Layers.Add(vectorItemsLayer2)
            Me.mapControl1.Location = New System.Drawing.Point(0, 0)
            Me.mapControl1.Name = "mapControl1"
            Me.mapControl1.Size = New System.Drawing.Size(761, 464)
            Me.mapControl1.TabIndex = 0
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(761, 464)
            Me.Controls.Add(Me.mapControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            DirectCast(Me.mapControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private WithEvents mapControl1 As DevExpress.XtraMap.MapControl
    End Class
End Namespace

