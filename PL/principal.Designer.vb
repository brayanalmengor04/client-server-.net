<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class principal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        txtUsuarioId = New TextBox()
        txtLibroId = New TextBox()
        txtCalificacion = New TextBox()
        btnCalificar = New Button()
        btnCalificacion = New Button()
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        btnEliminarUsuario = New Button()
        btnActualizarUsuario = New Button()
        btnInsertarUsuario = New Button()
        txtEmail = New TextBox()
        txtName = New TextBox()
        dtUsuario = New DataGridView()
        TabPage2 = New TabPage()
        btnEliminarLibro = New Button()
        btnActualizarLibro = New Button()
        btnInsertarLibro = New Button()
        txtAutor = New TextBox()
        txtTitulo = New TextBox()
        dtLibro = New DataGridView()
        TabPage3 = New TabPage()
        star1 = New PictureBox()
        lbCalificacion = New Label()
        star2 = New PictureBox()
        star3 = New PictureBox()
        star4 = New PictureBox()
        star5 = New PictureBox()
        dtCalificacion = New DataGridView()
        label12412 = New Label()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        CType(dtUsuario, ComponentModel.ISupportInitialize).BeginInit()
        TabPage2.SuspendLayout()
        CType(dtLibro, ComponentModel.ISupportInitialize).BeginInit()
        TabPage3.SuspendLayout()
        CType(star1, ComponentModel.ISupportInitialize).BeginInit()
        CType(star2, ComponentModel.ISupportInitialize).BeginInit()
        CType(star3, ComponentModel.ISupportInitialize).BeginInit()
        CType(star4, ComponentModel.ISupportInitialize).BeginInit()
        CType(star5, ComponentModel.ISupportInitialize).BeginInit()
        CType(dtCalificacion, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtUsuarioId
        ' 
        txtUsuarioId.Location = New Point(30, 168)
        txtUsuarioId.Name = "txtUsuarioId"
        txtUsuarioId.PlaceholderText = "ID Usuario "
        txtUsuarioId.Size = New Size(114, 23)
        txtUsuarioId.TabIndex = 0
        ' 
        ' txtLibroId
        ' 
        txtLibroId.Location = New Point(171, 247)
        txtLibroId.Name = "txtLibroId"
        txtLibroId.PlaceholderText = "ID Libro"
        txtLibroId.Size = New Size(114, 23)
        txtLibroId.TabIndex = 1
        ' 
        ' txtCalificacion
        ' 
        txtCalificacion.Location = New Point(38, 247)
        txtCalificacion.Name = "txtCalificacion"
        txtCalificacion.PlaceholderText = "Calificacion"
        txtCalificacion.Size = New Size(113, 23)
        txtCalificacion.TabIndex = 2
        ' 
        ' btnCalificar
        ' 
        btnCalificar.Location = New Point(333, 265)
        btnCalificar.Name = "btnCalificar"
        btnCalificar.Size = New Size(75, 23)
        btnCalificar.TabIndex = 3
        btnCalificar.Text = "Calificar"
        btnCalificar.UseVisualStyleBackColor = True
        ' 
        ' btnCalificacion
        ' 
        btnCalificacion.Location = New Point(414, 265)
        btnCalificacion.Name = "btnCalificacion"
        btnCalificacion.Size = New Size(243, 23)
        btnCalificacion.TabIndex = 4
        btnCalificacion.Text = "Actual Calificacion"
        btnCalificacion.UseVisualStyleBackColor = True
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Controls.Add(TabPage3)
        TabControl1.Location = New Point(41, 48)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(703, 334)
        TabControl1.TabIndex = 5
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(btnEliminarUsuario)
        TabPage1.Controls.Add(btnActualizarUsuario)
        TabPage1.Controls.Add(btnInsertarUsuario)
        TabPage1.Controls.Add(txtEmail)
        TabPage1.Controls.Add(txtName)
        TabPage1.Controls.Add(txtUsuarioId)
        TabPage1.Controls.Add(dtUsuario)
        TabPage1.Location = New Point(4, 24)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(695, 306)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Usuario"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' btnEliminarUsuario
        ' 
        btnEliminarUsuario.Location = New Point(192, 248)
        btnEliminarUsuario.Name = "btnEliminarUsuario"
        btnEliminarUsuario.Size = New Size(75, 23)
        btnEliminarUsuario.TabIndex = 5
        btnEliminarUsuario.Text = "Eliminar"
        btnEliminarUsuario.UseVisualStyleBackColor = True
        ' 
        ' btnActualizarUsuario
        ' 
        btnActualizarUsuario.Location = New Point(111, 248)
        btnActualizarUsuario.Name = "btnActualizarUsuario"
        btnActualizarUsuario.Size = New Size(75, 23)
        btnActualizarUsuario.TabIndex = 4
        btnActualizarUsuario.Text = "Actualizar"
        btnActualizarUsuario.UseVisualStyleBackColor = True
        ' 
        ' btnInsertarUsuario
        ' 
        btnInsertarUsuario.Location = New Point(30, 248)
        btnInsertarUsuario.Name = "btnInsertarUsuario"
        btnInsertarUsuario.Size = New Size(75, 23)
        btnInsertarUsuario.TabIndex = 3
        btnInsertarUsuario.Text = "Insertar"
        btnInsertarUsuario.UseVisualStyleBackColor = True
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(30, 112)
        txtEmail.Name = "txtEmail"
        txtEmail.PlaceholderText = "Email Usuario"
        txtEmail.Size = New Size(114, 23)
        txtEmail.TabIndex = 2
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(30, 52)
        txtName.Name = "txtName"
        txtName.PlaceholderText = "Nombre Usuario"
        txtName.Size = New Size(114, 23)
        txtName.TabIndex = 1
        ' 
        ' dtUsuario
        ' 
        dtUsuario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dtUsuario.Location = New Point(350, 25)
        dtUsuario.Name = "dtUsuario"
        dtUsuario.Size = New Size(310, 226)
        dtUsuario.TabIndex = 0
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(btnEliminarLibro)
        TabPage2.Controls.Add(btnActualizarLibro)
        TabPage2.Controls.Add(btnInsertarLibro)
        TabPage2.Controls.Add(txtAutor)
        TabPage2.Controls.Add(txtTitulo)
        TabPage2.Controls.Add(dtLibro)
        TabPage2.Location = New Point(4, 24)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(695, 306)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Libro"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' btnEliminarLibro
        ' 
        btnEliminarLibro.Location = New Point(194, 253)
        btnEliminarLibro.Name = "btnEliminarLibro"
        btnEliminarLibro.Size = New Size(75, 23)
        btnEliminarLibro.TabIndex = 11
        btnEliminarLibro.Text = "Eliminar"
        btnEliminarLibro.UseVisualStyleBackColor = True
        ' 
        ' btnActualizarLibro
        ' 
        btnActualizarLibro.Location = New Point(113, 253)
        btnActualizarLibro.Name = "btnActualizarLibro"
        btnActualizarLibro.Size = New Size(75, 23)
        btnActualizarLibro.TabIndex = 10
        btnActualizarLibro.Text = "Actualizar"
        btnActualizarLibro.UseVisualStyleBackColor = True
        ' 
        ' btnInsertarLibro
        ' 
        btnInsertarLibro.Location = New Point(32, 253)
        btnInsertarLibro.Name = "btnInsertarLibro"
        btnInsertarLibro.Size = New Size(75, 23)
        btnInsertarLibro.TabIndex = 9
        btnInsertarLibro.Text = "Insertar"
        btnInsertarLibro.UseVisualStyleBackColor = True
        ' 
        ' txtAutor
        ' 
        txtAutor.Location = New Point(32, 106)
        txtAutor.Name = "txtAutor"
        txtAutor.PlaceholderText = "Autor"
        txtAutor.Size = New Size(114, 23)
        txtAutor.TabIndex = 8
        ' 
        ' txtTitulo
        ' 
        txtTitulo.Location = New Point(32, 57)
        txtTitulo.Name = "txtTitulo"
        txtTitulo.PlaceholderText = "Titulo Libro"
        txtTitulo.Size = New Size(114, 23)
        txtTitulo.TabIndex = 7
        ' 
        ' dtLibro
        ' 
        dtLibro.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dtLibro.Location = New Point(352, 30)
        dtLibro.Name = "dtLibro"
        dtLibro.Size = New Size(310, 226)
        dtLibro.TabIndex = 6
        ' 
        ' TabPage3
        ' 
        TabPage3.Controls.Add(label12412)
        TabPage3.Controls.Add(dtCalificacion)
        TabPage3.Controls.Add(btnCalificar)
        TabPage3.Controls.Add(btnCalificacion)
        TabPage3.Controls.Add(star5)
        TabPage3.Controls.Add(star4)
        TabPage3.Controls.Add(txtLibroId)
        TabPage3.Controls.Add(txtCalificacion)
        TabPage3.Controls.Add(star3)
        TabPage3.Controls.Add(star2)
        TabPage3.Controls.Add(star1)
        TabPage3.Controls.Add(lbCalificacion)
        TabPage3.Location = New Point(4, 24)
        TabPage3.Name = "TabPage3"
        TabPage3.Padding = New Padding(3)
        TabPage3.Size = New Size(695, 306)
        TabPage3.TabIndex = 2
        TabPage3.Text = "Reseñas"
        TabPage3.UseVisualStyleBackColor = True
        ' 
        ' star1
        ' 
        star1.BackgroundImageLayout = ImageLayout.None
        star1.Image = My.Resources.Resources.startreview
        star1.Location = New Point(26, 106)
        star1.Name = "star1"
        star1.Size = New Size(33, 30)
        star1.SizeMode = PictureBoxSizeMode.Zoom
        star1.TabIndex = 2
        star1.TabStop = False
        ' 
        ' lbCalificacion
        ' 
        lbCalificacion.AutoSize = True
        lbCalificacion.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbCalificacion.ForeColor = Color.Gold
        lbCalificacion.Location = New Point(153, 201)
        lbCalificacion.Name = "lbCalificacion"
        lbCalificacion.Size = New Size(42, 30)
        lbCalificacion.TabIndex = 1
        lbCalificacion.Text = "5.0"
        ' 
        ' star2
        ' 
        star2.BackgroundImageLayout = ImageLayout.None
        star2.Image = My.Resources.Resources.startreview
        star2.Location = New Point(82, 106)
        star2.Name = "star2"
        star2.Size = New Size(33, 30)
        star2.SizeMode = PictureBoxSizeMode.Zoom
        star2.TabIndex = 3
        star2.TabStop = False
        ' 
        ' star3
        ' 
        star3.BackgroundImageLayout = ImageLayout.None
        star3.Image = My.Resources.Resources.startreview
        star3.Location = New Point(141, 106)
        star3.Name = "star3"
        star3.Size = New Size(33, 30)
        star3.SizeMode = PictureBoxSizeMode.Zoom
        star3.TabIndex = 4
        star3.TabStop = False
        ' 
        ' star4
        ' 
        star4.BackgroundImageLayout = ImageLayout.None
        star4.Image = My.Resources.Resources.startreview
        star4.Location = New Point(206, 106)
        star4.Name = "star4"
        star4.Size = New Size(33, 30)
        star4.SizeMode = PictureBoxSizeMode.Zoom
        star4.TabIndex = 5
        star4.TabStop = False
        ' 
        ' star5
        ' 
        star5.BackgroundImageLayout = ImageLayout.None
        star5.Image = My.Resources.Resources.startreview
        star5.Location = New Point(268, 106)
        star5.Name = "star5"
        star5.Size = New Size(33, 30)
        star5.SizeMode = PictureBoxSizeMode.Zoom
        star5.TabIndex = 6
        star5.TabStop = False
        ' 
        ' dtCalificacion
        ' 
        dtCalificacion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dtCalificacion.Location = New Point(319, 40)
        dtCalificacion.Name = "dtCalificacion"
        dtCalificacion.Size = New Size(349, 204)
        dtCalificacion.TabIndex = 7
        ' 
        ' label12412
        ' 
        label12412.AutoSize = True
        label12412.Location = New Point(44, 33)
        label12412.Name = "label12412"
        label12412.Size = New Size(41, 15)
        label12412.TabIndex = 8
        label12412.Text = "Label1"
        ' 
        ' principal
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 430)
        Controls.Add(TabControl1)
        Name = "principal"
        Text = "Sistema de Reseña"
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        CType(dtUsuario, ComponentModel.ISupportInitialize).EndInit()
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        CType(dtLibro, ComponentModel.ISupportInitialize).EndInit()
        TabPage3.ResumeLayout(False)
        TabPage3.PerformLayout()
        CType(star1, ComponentModel.ISupportInitialize).EndInit()
        CType(star2, ComponentModel.ISupportInitialize).EndInit()
        CType(star3, ComponentModel.ISupportInitialize).EndInit()
        CType(star4, ComponentModel.ISupportInitialize).EndInit()
        CType(star5, ComponentModel.ISupportInitialize).EndInit()
        CType(dtCalificacion, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents txtUsuarioId As TextBox
    Friend WithEvents txtLibroId As TextBox
    Friend WithEvents txtCalificacion As TextBox
    Friend WithEvents btnCalificar As Button
    Friend WithEvents btnCalificacion As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents dtUsuario As DataGridView
    Friend WithEvents btnEliminarUsuario As Button
    Friend WithEvents btnActualizarUsuario As Button
    Friend WithEvents btnInsertarUsuario As Button
    Friend WithEvents btnEliminarLibro As Button
    Friend WithEvents btnActualizarLibro As Button
    Friend WithEvents btnInsertarLibro As Button
    Friend WithEvents txtAutor As TextBox
    Friend WithEvents txtTitulo As TextBox
    Friend WithEvents dtLibro As DataGridView
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents star1 As PictureBox
    Friend WithEvents lbCalificacion As Label
    Friend WithEvents star5 As PictureBox
    Friend WithEvents star4 As PictureBox
    Friend WithEvents star3 As PictureBox
    Friend WithEvents star2 As PictureBox
    Friend WithEvents dtCalificacion As DataGridView
    Friend WithEvents label12412 As Label

End Class
