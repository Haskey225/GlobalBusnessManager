<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WIN_STOCK_MANAGER
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.EditionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EntrerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SortieToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FermerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AffichageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.OUT_PRODUCT_GRID = New System.Windows.Forms.DataGridView()
        Me.id_sortie = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.out_date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.out_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.out_cause = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.out_destination = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.out_quantite = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.StatusStrip2 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.IN_PRODUCT_GRID = New System.Windows.Forms.DataGridView()
        Me.id_entrer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.in_date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.in_product = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.in_stock_init = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.in_quantite = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.in_stock_fin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.OUT_PRODUCT_GRID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        Me.StatusStrip2.SuspendLayout()
        CType(Me.IN_PRODUCT_GRID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditionToolStripMenuItem, Me.AffichageToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1098, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'EditionToolStripMenuItem
        '
        Me.EditionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EntrerToolStripMenuItem, Me.SortieToolStripMenuItem, Me.FermerToolStripMenuItem})
        Me.EditionToolStripMenuItem.Name = "EditionToolStripMenuItem"
        Me.EditionToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.EditionToolStripMenuItem.Text = "Edition"
        '
        'EntrerToolStripMenuItem
        '
        Me.EntrerToolStripMenuItem.Name = "EntrerToolStripMenuItem"
        Me.EntrerToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.EntrerToolStripMenuItem.Text = "Nouvelle entrée"
        '
        'SortieToolStripMenuItem
        '
        Me.SortieToolStripMenuItem.Name = "SortieToolStripMenuItem"
        Me.SortieToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SortieToolStripMenuItem.Text = "Nouvelle sortie"
        '
        'FermerToolStripMenuItem
        '
        Me.FermerToolStripMenuItem.Name = "FermerToolStripMenuItem"
        Me.FermerToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.FermerToolStripMenuItem.Text = "Fermer"
        '
        'AffichageToolStripMenuItem
        '
        Me.AffichageToolStripMenuItem.Name = "AffichageToolStripMenuItem"
        Me.AffichageToolStripMenuItem.Size = New System.Drawing.Size(70, 20)
        Me.AffichageToolStripMenuItem.Text = "Affichage"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 24)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.SplitContainer2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer3)
        Me.SplitContainer1.Size = New System.Drawing.Size(1098, 536)
        Me.SplitContainer1.SplitterDistance = 545
        Me.SplitContainer1.TabIndex = 1
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.StatusStrip1)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.OUT_PRODUCT_GRID)
        Me.SplitContainer2.Size = New System.Drawing.Size(545, 536)
        Me.SplitContainer2.SplitterDistance = 25
        Me.SplitContainer2.TabIndex = 1
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 3)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(545, 22)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(105, 17)
        Me.ToolStripStatusLabel1.Text = "LISTE DES SORTIES"
        '
        'OUT_PRODUCT_GRID
        '
        Me.OUT_PRODUCT_GRID.AllowUserToAddRows = False
        Me.OUT_PRODUCT_GRID.AllowUserToDeleteRows = False
        Me.OUT_PRODUCT_GRID.AllowUserToResizeRows = False
        Me.OUT_PRODUCT_GRID.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.OUT_PRODUCT_GRID.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_sortie, Me.out_date, Me.out_name, Me.out_cause, Me.out_destination, Me.out_quantite})
        Me.OUT_PRODUCT_GRID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OUT_PRODUCT_GRID.Location = New System.Drawing.Point(0, 0)
        Me.OUT_PRODUCT_GRID.Name = "OUT_PRODUCT_GRID"
        Me.OUT_PRODUCT_GRID.Size = New System.Drawing.Size(545, 507)
        Me.OUT_PRODUCT_GRID.TabIndex = 0
        '
        'id_sortie
        '
        Me.id_sortie.HeaderText = "id"
        Me.id_sortie.Name = "id_sortie"
        Me.id_sortie.Visible = False
        '
        'out_date
        '
        Me.out_date.HeaderText = "Date"
        Me.out_date.Name = "out_date"
        '
        'out_name
        '
        Me.out_name.HeaderText = "Produit"
        Me.out_name.Name = "out_name"
        '
        'out_cause
        '
        Me.out_cause.HeaderText = "Cause"
        Me.out_cause.Name = "out_cause"
        '
        'out_destination
        '
        Me.out_destination.HeaderText = "Destination"
        Me.out_destination.Name = "out_destination"
        '
        'out_quantite
        '
        Me.out_quantite.HeaderText = "Quantité"
        Me.out_quantite.Name = "out_quantite"
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer3.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer3.Name = "SplitContainer3"
        Me.SplitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.StatusStrip2)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.IN_PRODUCT_GRID)
        Me.SplitContainer3.Size = New System.Drawing.Size(549, 536)
        Me.SplitContainer3.SplitterDistance = 25
        Me.SplitContainer3.TabIndex = 1
        '
        'StatusStrip2
        '
        Me.StatusStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel2})
        Me.StatusStrip2.Location = New System.Drawing.Point(0, 3)
        Me.StatusStrip2.Name = "StatusStrip2"
        Me.StatusStrip2.Size = New System.Drawing.Size(549, 22)
        Me.StatusStrip2.TabIndex = 0
        Me.StatusStrip2.Text = "StatusStrip2"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(108, 17)
        Me.ToolStripStatusLabel2.Text = "LISTE DES ENTREES"
        '
        'IN_PRODUCT_GRID
        '
        Me.IN_PRODUCT_GRID.AllowUserToAddRows = False
        Me.IN_PRODUCT_GRID.AllowUserToDeleteRows = False
        Me.IN_PRODUCT_GRID.AllowUserToResizeRows = False
        Me.IN_PRODUCT_GRID.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.IN_PRODUCT_GRID.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_entrer, Me.in_date, Me.in_product, Me.in_stock_init, Me.in_quantite, Me.in_stock_fin})
        Me.IN_PRODUCT_GRID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.IN_PRODUCT_GRID.Location = New System.Drawing.Point(0, 0)
        Me.IN_PRODUCT_GRID.Name = "IN_PRODUCT_GRID"
        Me.IN_PRODUCT_GRID.Size = New System.Drawing.Size(549, 507)
        Me.IN_PRODUCT_GRID.TabIndex = 0
        '
        'id_entrer
        '
        Me.id_entrer.HeaderText = "id"
        Me.id_entrer.Name = "id_entrer"
        Me.id_entrer.Visible = False
        '
        'in_date
        '
        Me.in_date.HeaderText = "Date"
        Me.in_date.Name = "in_date"
        '
        'in_product
        '
        Me.in_product.HeaderText = "Produit"
        Me.in_product.Name = "in_product"
        '
        'in_stock_init
        '
        Me.in_stock_init.HeaderText = "Stock initial"
        Me.in_stock_init.Name = "in_stock_init"
        '
        'in_quantite
        '
        Me.in_quantite.HeaderText = "Quantite"
        Me.in_quantite.Name = "in_quantite"
        '
        'in_stock_fin
        '
        Me.in_stock_fin.HeaderText = "Stock final"
        Me.in_stock_fin.Name = "in_stock_fin"
        '
        'WIN_STOCK_MANAGER
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1098, 560)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "WIN_STOCK_MANAGER"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestionnaire de stock"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.PerformLayout()
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.OUT_PRODUCT_GRID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel1.PerformLayout()
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.ResumeLayout(False)
        Me.StatusStrip2.ResumeLayout(False)
        Me.StatusStrip2.PerformLayout()
        CType(Me.IN_PRODUCT_GRID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents EditionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EntrerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SortieToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FermerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AffichageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OUT_PRODUCT_GRID As DataGridView
    Friend WithEvents IN_PRODUCT_GRID As DataGridView
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents SplitContainer3 As SplitContainer
    Friend WithEvents StatusStrip2 As StatusStrip
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents id_entrer As DataGridViewTextBoxColumn
    Friend WithEvents id_sortie As DataGridViewTextBoxColumn
    Friend WithEvents out_date As DataGridViewTextBoxColumn
    Friend WithEvents out_name As DataGridViewTextBoxColumn
    Friend WithEvents out_cause As DataGridViewTextBoxColumn
    Friend WithEvents out_destination As DataGridViewTextBoxColumn
    Friend WithEvents out_quantite As DataGridViewTextBoxColumn
    Friend WithEvents in_date As DataGridViewTextBoxColumn
    Friend WithEvents in_product As DataGridViewTextBoxColumn
    Friend WithEvents in_stock_init As DataGridViewTextBoxColumn
    Friend WithEvents in_quantite As DataGridViewTextBoxColumn
    Friend WithEvents in_stock_fin As DataGridViewTextBoxColumn
End Class
