<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainController
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainController))
        Me.VU_RAPPORT = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nameuser = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.produit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.client = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.contact = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.adresse = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.prix_achat = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.prix_vente = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.benefice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.vendu_par = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.source = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ribbon1 = New System.Windows.Forms.Ribbon()
        Me.MENU_PROGRAMME = New System.Windows.Forms.RibbonOrbMenuItem()
        Me.RibbonSeparator1 = New System.Windows.Forms.RibbonSeparator()
        Me.RibbonSeparator2 = New System.Windows.Forms.RibbonSeparator()
        Me.BT_IMPRESSION = New System.Windows.Forms.RibbonOrbMenuItem()
        Me.RibbonSeparator3 = New System.Windows.Forms.RibbonSeparator()
        Me.RibbonSeparator4 = New System.Windows.Forms.RibbonSeparator()
        Me.BT_ENREGISTRER = New System.Windows.Forms.RibbonOrbMenuItem()
        Me.RibbonSeparator5 = New System.Windows.Forms.RibbonSeparator()
        Me.RibbonSeparator6 = New System.Windows.Forms.RibbonSeparator()
        Me.BT_ENREGISTRER_SOUS = New System.Windows.Forms.RibbonOrbMenuItem()
        Me.RibbonOrbOptionButton1 = New System.Windows.Forms.RibbonOrbOptionButton()
        Me.RibbonButton1 = New System.Windows.Forms.RibbonButton()
        Me.RB_ACCEUIL = New System.Windows.Forms.RibbonTab()
        Me.GP_CONNEXION = New System.Windows.Forms.RibbonPanel()
        Me.BT_CON = New System.Windows.Forms.RibbonButton()
        Me.BT_DCO = New System.Windows.Forms.RibbonButton()
        Me.GP_VUE = New System.Windows.Forms.RibbonPanel()
        Me.BT_VUE_COM = New System.Windows.Forms.RibbonButton()
        Me.BT_VUE_PRODUIT = New System.Windows.Forms.RibbonButton()
        Me.BT_VUE_CLIENT = New System.Windows.Forms.RibbonButton()
        Me.BT_VUE_FOURNISSEUR = New System.Windows.Forms.RibbonButton()
        Me.RB_GESTION = New System.Windows.Forms.RibbonTab()
        Me.GP_PRODUIT = New System.Windows.Forms.RibbonPanel()
        Me.BT_PRODUCT_ADD = New System.Windows.Forms.RibbonButton()
        Me.BT_DEL_PRODUCT = New System.Windows.Forms.RibbonButton()
        Me.BT_EDIT_PRODUCT = New System.Windows.Forms.RibbonButton()
        Me.BT_PRODUCT_STOCK = New System.Windows.Forms.RibbonButton()
        Me.GP_COMMAND = New System.Windows.Forms.RibbonPanel()
        Me.BT_ADD_COMMAND = New System.Windows.Forms.RibbonButton()
        Me.BT_DELETE_COMMAND = New System.Windows.Forms.RibbonButton()
        Me.BT_EDIT_COMMAND = New System.Windows.Forms.RibbonButton()
        Me.GP_CLIENT = New System.Windows.Forms.RibbonPanel()
        Me.BT_ADD_CLIENT = New System.Windows.Forms.RibbonButton()
        Me.BT_EDIT_ClIENT = New System.Windows.Forms.RibbonButton()
        Me.BT_DEL_CLIENT = New System.Windows.Forms.RibbonButton()
        Me.RB_RAPPORT = New System.Windows.Forms.RibbonTab()
        Me.GP_RAPPORT = New System.Windows.Forms.RibbonPanel()
        Me.BT_RAP_JOUR = New System.Windows.Forms.RibbonButton()
        Me.BT_RAP_WEEK = New System.Windows.Forms.RibbonButton()
        Me.BT_RAP_MONTH = New System.Windows.Forms.RibbonButton()
        Me.STAT_BAR = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.BAR_ETAT = New System.Windows.Forms.ToolStripStatusLabel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.FORT__NUMBER = New System.Windows.Forms.Label()
        Me.BON__NUMBER = New System.Windows.Forms.Label()
        Me.FAIBLE__NUMBER = New System.Windows.Forms.Label()
        Me.RUPTURE_NUMBER = New System.Windows.Forms.Label()
        Me.BT_FORT = New System.Windows.Forms.Button()
        Me.BT_BON = New System.Windows.Forms.Button()
        Me.BT_FAIBLE = New System.Windows.Forms.Button()
        Me.BP_RUPTURE = New System.Windows.Forms.Button()
        Me.STOCK_LIST = New System.Windows.Forms.DataGridView()
        Me.id_stock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.product_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.product_stat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.product_quantite = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VU_COMMAND = New System.Windows.Forms.DataGridView()
        Me.idCommand = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.produitCommand = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clientCommand = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.contactCommand = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.adressDeLivraison = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.netPayer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.etatCommand = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.proprieteCommand = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FORNISSEUR_DATA_GRID = New System.Windows.Forms.DataGridView()
        Me.idFournisseur = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nameFournisseur = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codeFournisseur = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLIENT_DATA_VIEW = New System.Windows.Forms.DataGridView()
        Me.idClient = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nameClient = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.contactClient = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.communeClient = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRODUCT_DATA_GRID = New System.Windows.Forms.DataGridView()
        Me.idpro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.namepro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.APP_CONFIG = New System.Windows.Forms.RibbonButton()
        Me.UpDateTimer = New System.Windows.Forms.Timer(Me.components)
        Me.BT_STOCK_MANAGER = New System.Windows.Forms.RibbonButton()
        CType(Me.VU_RAPPORT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.STAT_BAR.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.STOCK_LIST, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VU_COMMAND, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FORNISSEUR_DATA_GRID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CLIENT_DATA_VIEW, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PRODUCT_DATA_GRID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'VU_RAPPORT
        '
        Me.VU_RAPPORT.AllowUserToAddRows = False
        Me.VU_RAPPORT.AllowUserToDeleteRows = False
        Me.VU_RAPPORT.AllowUserToResizeRows = False
        Me.VU_RAPPORT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.VU_RAPPORT.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.nameuser, Me.produit, Me.client, Me.contact, Me.adresse, Me.prix_achat, Me.prix_vente, Me.benefice, Me.vendu_par, Me.source})
        Me.VU_RAPPORT.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VU_RAPPORT.Location = New System.Drawing.Point(0, 0)
        Me.VU_RAPPORT.Name = "VU_RAPPORT"
        Me.VU_RAPPORT.Size = New System.Drawing.Size(878, 439)
        Me.VU_RAPPORT.TabIndex = 0
        Me.VU_RAPPORT.Visible = False
        '
        'id
        '
        Me.id.HeaderText = "id"
        Me.id.Name = "id"
        Me.id.Visible = False
        Me.id.Width = 40
        '
        'nameuser
        '
        Me.nameuser.HeaderText = "nom"
        Me.nameuser.Name = "nameuser"
        Me.nameuser.Width = 150
        '
        'produit
        '
        Me.produit.HeaderText = "produit"
        Me.produit.Name = "produit"
        '
        'client
        '
        Me.client.HeaderText = "client"
        Me.client.Name = "client"
        Me.client.Width = 150
        '
        'contact
        '
        Me.contact.HeaderText = "contact"
        Me.contact.Name = "contact"
        '
        'adresse
        '
        Me.adresse.HeaderText = "adresse"
        Me.adresse.Name = "adresse"
        Me.adresse.Width = 120
        '
        'prix_achat
        '
        Me.prix_achat.HeaderText = "prix_achat"
        Me.prix_achat.Name = "prix_achat"
        '
        'prix_vente
        '
        Me.prix_vente.HeaderText = "prix_vente"
        Me.prix_vente.Name = "prix_vente"
        '
        'benefice
        '
        Me.benefice.HeaderText = "benefice"
        Me.benefice.Name = "benefice"
        '
        'vendu_par
        '
        Me.vendu_par.HeaderText = "vendeur"
        Me.vendu_par.Name = "vendu_par"
        '
        'source
        '
        Me.source.HeaderText = "source"
        Me.source.Name = "source"
        '
        'Ribbon1
        '
        Me.Ribbon1.Location = New System.Drawing.Point(0, 0)
        Me.Ribbon1.Minimized = False
        Me.Ribbon1.Name = "Ribbon1"
        '
        '
        '
        Me.Ribbon1.OrbDropDown.Location = New System.Drawing.Point(0, 0)
        Me.Ribbon1.OrbDropDown.MenuItems.Add(Me.MENU_PROGRAMME)
        Me.Ribbon1.OrbDropDown.MenuItems.Add(Me.RibbonSeparator1)
        Me.Ribbon1.OrbDropDown.MenuItems.Add(Me.RibbonSeparator2)
        Me.Ribbon1.OrbDropDown.MenuItems.Add(Me.BT_IMPRESSION)
        Me.Ribbon1.OrbDropDown.MenuItems.Add(Me.RibbonSeparator3)
        Me.Ribbon1.OrbDropDown.MenuItems.Add(Me.RibbonSeparator4)
        Me.Ribbon1.OrbDropDown.MenuItems.Add(Me.BT_ENREGISTRER)
        Me.Ribbon1.OrbDropDown.MenuItems.Add(Me.RibbonSeparator5)
        Me.Ribbon1.OrbDropDown.MenuItems.Add(Me.RibbonSeparator6)
        Me.Ribbon1.OrbDropDown.MenuItems.Add(Me.BT_ENREGISTRER_SOUS)
        Me.Ribbon1.OrbDropDown.Name = ""
        Me.Ribbon1.OrbDropDown.NextPopup = Nothing
        Me.Ribbon1.OrbDropDown.OptionItems.Add(Me.RibbonOrbOptionButton1)
        Me.Ribbon1.OrbDropDown.PreviousPopup = Nothing
        Me.Ribbon1.OrbDropDown.Size = New System.Drawing.Size(527, 266)
        Me.Ribbon1.OrbDropDown.TabIndex = 0
        Me.Ribbon1.OrbDropDown.ToolStripDropDown = Nothing
        Me.Ribbon1.OrbImage = CType(resources.GetObject("Ribbon1.OrbImage"), System.Drawing.Image)
        '
        '
        '
        Me.Ribbon1.QuickAcessToolbar.AltKey = Nothing
        Me.Ribbon1.QuickAcessToolbar.Image = Nothing
        Me.Ribbon1.QuickAcessToolbar.Items.Add(Me.RibbonButton1)
        Me.Ribbon1.QuickAcessToolbar.Tag = Nothing
        Me.Ribbon1.QuickAcessToolbar.Text = Nothing
        Me.Ribbon1.QuickAcessToolbar.ToolTip = Nothing
        Me.Ribbon1.QuickAcessToolbar.ToolTipImage = Nothing
        Me.Ribbon1.QuickAcessToolbar.ToolTipTitle = Nothing
        Me.Ribbon1.Size = New System.Drawing.Size(1113, 138)
        Me.Ribbon1.TabIndex = 0
        Me.Ribbon1.Tabs.Add(Me.RB_ACCEUIL)
        Me.Ribbon1.Tabs.Add(Me.RB_GESTION)
        Me.Ribbon1.Tabs.Add(Me.RB_RAPPORT)
        Me.Ribbon1.TabSpacing = 6
        Me.Ribbon1.Text = "Ribbon1"
        '
        'MENU_PROGRAMME
        '
        Me.MENU_PROGRAMME.AltKey = Nothing
        Me.MENU_PROGRAMME.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left
        Me.MENU_PROGRAMME.DropDownArrowSize = New System.Drawing.Size(5, 3)
        Me.MENU_PROGRAMME.Image = CType(resources.GetObject("MENU_PROGRAMME.Image"), System.Drawing.Image)
        Me.MENU_PROGRAMME.SmallImage = CType(resources.GetObject("MENU_PROGRAMME.SmallImage"), System.Drawing.Image)
        Me.MENU_PROGRAMME.Style = System.Windows.Forms.RibbonButtonStyle.Normal
        Me.MENU_PROGRAMME.Tag = Nothing
        Me.MENU_PROGRAMME.Text = "Parametre"
        Me.MENU_PROGRAMME.ToolTip = Nothing
        Me.MENU_PROGRAMME.ToolTipImage = Nothing
        Me.MENU_PROGRAMME.ToolTipTitle = Nothing
        '
        'RibbonSeparator1
        '
        Me.RibbonSeparator1.AltKey = Nothing
        Me.RibbonSeparator1.Image = Nothing
        Me.RibbonSeparator1.Tag = Nothing
        Me.RibbonSeparator1.Text = Nothing
        Me.RibbonSeparator1.ToolTip = Nothing
        Me.RibbonSeparator1.ToolTipImage = Nothing
        Me.RibbonSeparator1.ToolTipTitle = Nothing
        '
        'RibbonSeparator2
        '
        Me.RibbonSeparator2.AltKey = Nothing
        Me.RibbonSeparator2.Image = Nothing
        Me.RibbonSeparator2.Tag = Nothing
        Me.RibbonSeparator2.Text = Nothing
        Me.RibbonSeparator2.ToolTip = Nothing
        Me.RibbonSeparator2.ToolTipImage = Nothing
        Me.RibbonSeparator2.ToolTipTitle = Nothing
        '
        'BT_IMPRESSION
        '
        Me.BT_IMPRESSION.AltKey = Nothing
        Me.BT_IMPRESSION.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left
        Me.BT_IMPRESSION.DropDownArrowSize = New System.Drawing.Size(5, 3)
        Me.BT_IMPRESSION.Image = CType(resources.GetObject("BT_IMPRESSION.Image"), System.Drawing.Image)
        Me.BT_IMPRESSION.SmallImage = CType(resources.GetObject("BT_IMPRESSION.SmallImage"), System.Drawing.Image)
        Me.BT_IMPRESSION.Style = System.Windows.Forms.RibbonButtonStyle.Normal
        Me.BT_IMPRESSION.Tag = Nothing
        Me.BT_IMPRESSION.Text = "Impression"
        Me.BT_IMPRESSION.ToolTip = Nothing
        Me.BT_IMPRESSION.ToolTipImage = Nothing
        Me.BT_IMPRESSION.ToolTipTitle = Nothing
        '
        'RibbonSeparator3
        '
        Me.RibbonSeparator3.AltKey = Nothing
        Me.RibbonSeparator3.Image = Nothing
        Me.RibbonSeparator3.Tag = Nothing
        Me.RibbonSeparator3.Text = Nothing
        Me.RibbonSeparator3.ToolTip = Nothing
        Me.RibbonSeparator3.ToolTipImage = Nothing
        Me.RibbonSeparator3.ToolTipTitle = Nothing
        '
        'RibbonSeparator4
        '
        Me.RibbonSeparator4.AltKey = Nothing
        Me.RibbonSeparator4.Image = Nothing
        Me.RibbonSeparator4.Tag = Nothing
        Me.RibbonSeparator4.Text = Nothing
        Me.RibbonSeparator4.ToolTip = Nothing
        Me.RibbonSeparator4.ToolTipImage = Nothing
        Me.RibbonSeparator4.ToolTipTitle = Nothing
        '
        'BT_ENREGISTRER
        '
        Me.BT_ENREGISTRER.AltKey = Nothing
        Me.BT_ENREGISTRER.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left
        Me.BT_ENREGISTRER.DropDownArrowSize = New System.Drawing.Size(5, 3)
        Me.BT_ENREGISTRER.Image = CType(resources.GetObject("BT_ENREGISTRER.Image"), System.Drawing.Image)
        Me.BT_ENREGISTRER.SmallImage = CType(resources.GetObject("BT_ENREGISTRER.SmallImage"), System.Drawing.Image)
        Me.BT_ENREGISTRER.Style = System.Windows.Forms.RibbonButtonStyle.Normal
        Me.BT_ENREGISTRER.Tag = Nothing
        Me.BT_ENREGISTRER.Text = "Enregistrer"
        Me.BT_ENREGISTRER.ToolTip = Nothing
        Me.BT_ENREGISTRER.ToolTipImage = Nothing
        Me.BT_ENREGISTRER.ToolTipTitle = Nothing
        '
        'RibbonSeparator5
        '
        Me.RibbonSeparator5.AltKey = Nothing
        Me.RibbonSeparator5.Image = Nothing
        Me.RibbonSeparator5.Tag = Nothing
        Me.RibbonSeparator5.Text = Nothing
        Me.RibbonSeparator5.ToolTip = Nothing
        Me.RibbonSeparator5.ToolTipImage = Nothing
        Me.RibbonSeparator5.ToolTipTitle = Nothing
        '
        'RibbonSeparator6
        '
        Me.RibbonSeparator6.AltKey = Nothing
        Me.RibbonSeparator6.Image = Nothing
        Me.RibbonSeparator6.Tag = Nothing
        Me.RibbonSeparator6.Text = Nothing
        Me.RibbonSeparator6.ToolTip = Nothing
        Me.RibbonSeparator6.ToolTipImage = Nothing
        Me.RibbonSeparator6.ToolTipTitle = Nothing
        '
        'BT_ENREGISTRER_SOUS
        '
        Me.BT_ENREGISTRER_SOUS.AltKey = Nothing
        Me.BT_ENREGISTRER_SOUS.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left
        Me.BT_ENREGISTRER_SOUS.DropDownArrowSize = New System.Drawing.Size(5, 3)
        Me.BT_ENREGISTRER_SOUS.Image = CType(resources.GetObject("BT_ENREGISTRER_SOUS.Image"), System.Drawing.Image)
        Me.BT_ENREGISTRER_SOUS.SmallImage = CType(resources.GetObject("BT_ENREGISTRER_SOUS.SmallImage"), System.Drawing.Image)
        Me.BT_ENREGISTRER_SOUS.Style = System.Windows.Forms.RibbonButtonStyle.Normal
        Me.BT_ENREGISTRER_SOUS.Tag = Nothing
        Me.BT_ENREGISTRER_SOUS.Text = "Enregistrer sous ..."
        Me.BT_ENREGISTRER_SOUS.ToolTip = Nothing
        Me.BT_ENREGISTRER_SOUS.ToolTipImage = Nothing
        Me.BT_ENREGISTRER_SOUS.ToolTipTitle = Nothing
        '
        'RibbonOrbOptionButton1
        '
        Me.RibbonOrbOptionButton1.AltKey = Nothing
        Me.RibbonOrbOptionButton1.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down
        Me.RibbonOrbOptionButton1.DropDownArrowSize = New System.Drawing.Size(5, 3)
        Me.RibbonOrbOptionButton1.Image = CType(resources.GetObject("RibbonOrbOptionButton1.Image"), System.Drawing.Image)
        Me.RibbonOrbOptionButton1.SmallImage = CType(resources.GetObject("RibbonOrbOptionButton1.SmallImage"), System.Drawing.Image)
        Me.RibbonOrbOptionButton1.Style = System.Windows.Forms.RibbonButtonStyle.Normal
        Me.RibbonOrbOptionButton1.Tag = Nothing
        Me.RibbonOrbOptionButton1.Text = "Option"
        Me.RibbonOrbOptionButton1.ToolTip = Nothing
        Me.RibbonOrbOptionButton1.ToolTipImage = Nothing
        Me.RibbonOrbOptionButton1.ToolTipTitle = Nothing
        '
        'RibbonButton1
        '
        Me.RibbonButton1.AltKey = Nothing
        Me.RibbonButton1.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down
        Me.RibbonButton1.DropDownArrowSize = New System.Drawing.Size(5, 3)
        Me.RibbonButton1.Image = CType(resources.GetObject("RibbonButton1.Image"), System.Drawing.Image)
        Me.RibbonButton1.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact
        Me.RibbonButton1.SmallImage = CType(resources.GetObject("RibbonButton1.SmallImage"), System.Drawing.Image)
        Me.RibbonButton1.Style = System.Windows.Forms.RibbonButtonStyle.Normal
        Me.RibbonButton1.Tag = Nothing
        Me.RibbonButton1.Text = "RibbonButton1"
        Me.RibbonButton1.ToolTip = Nothing
        Me.RibbonButton1.ToolTipImage = Nothing
        Me.RibbonButton1.ToolTipTitle = Nothing
        '
        'RB_ACCEUIL
        '
        Me.RB_ACCEUIL.Panels.Add(Me.GP_CONNEXION)
        Me.RB_ACCEUIL.Panels.Add(Me.GP_VUE)
        Me.RB_ACCEUIL.Tag = Nothing
        Me.RB_ACCEUIL.Text = "Acceuil"
        '
        'GP_CONNEXION
        '
        Me.GP_CONNEXION.ButtonMoreVisible = False
        Me.GP_CONNEXION.Items.Add(Me.BT_CON)
        Me.GP_CONNEXION.Items.Add(Me.BT_DCO)
        Me.GP_CONNEXION.Tag = Nothing
        Me.GP_CONNEXION.Text = "Connexion/Deconnexion"
        '
        'BT_CON
        '
        Me.BT_CON.AltKey = Nothing
        Me.BT_CON.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down
        Me.BT_CON.DropDownArrowSize = New System.Drawing.Size(5, 3)
        Me.BT_CON.Image = CType(resources.GetObject("BT_CON.Image"), System.Drawing.Image)
        Me.BT_CON.SmallImage = CType(resources.GetObject("BT_CON.SmallImage"), System.Drawing.Image)
        Me.BT_CON.Style = System.Windows.Forms.RibbonButtonStyle.Normal
        Me.BT_CON.Tag = Nothing
        Me.BT_CON.Text = "Connexion"
        Me.BT_CON.ToolTip = Nothing
        Me.BT_CON.ToolTipImage = Nothing
        Me.BT_CON.ToolTipTitle = Nothing
        '
        'BT_DCO
        '
        Me.BT_DCO.AltKey = Nothing
        Me.BT_DCO.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down
        Me.BT_DCO.DropDownArrowSize = New System.Drawing.Size(5, 3)
        Me.BT_DCO.Enabled = False
        Me.BT_DCO.Image = CType(resources.GetObject("BT_DCO.Image"), System.Drawing.Image)
        Me.BT_DCO.SmallImage = CType(resources.GetObject("BT_DCO.SmallImage"), System.Drawing.Image)
        Me.BT_DCO.Style = System.Windows.Forms.RibbonButtonStyle.Normal
        Me.BT_DCO.Tag = Nothing
        Me.BT_DCO.Text = "Deconnexion"
        Me.BT_DCO.ToolTip = Nothing
        Me.BT_DCO.ToolTipImage = Nothing
        Me.BT_DCO.ToolTipTitle = Nothing
        '
        'GP_VUE
        '
        Me.GP_VUE.ButtonMoreVisible = False
        Me.GP_VUE.Items.Add(Me.BT_VUE_COM)
        Me.GP_VUE.Items.Add(Me.BT_VUE_PRODUIT)
        Me.GP_VUE.Items.Add(Me.BT_VUE_CLIENT)
        Me.GP_VUE.Items.Add(Me.BT_VUE_FOURNISSEUR)
        Me.GP_VUE.Tag = Nothing
        Me.GP_VUE.Text = "Vue d'ensemble"
        '
        'BT_VUE_COM
        '
        Me.BT_VUE_COM.AltKey = Nothing
        Me.BT_VUE_COM.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down
        Me.BT_VUE_COM.DropDownArrowSize = New System.Drawing.Size(5, 3)
        Me.BT_VUE_COM.Image = CType(resources.GetObject("BT_VUE_COM.Image"), System.Drawing.Image)
        Me.BT_VUE_COM.SmallImage = CType(resources.GetObject("BT_VUE_COM.SmallImage"), System.Drawing.Image)
        Me.BT_VUE_COM.Style = System.Windows.Forms.RibbonButtonStyle.Normal
        Me.BT_VUE_COM.Tag = Nothing
        Me.BT_VUE_COM.Text = "Vue des commandes"
        Me.BT_VUE_COM.ToolTip = Nothing
        Me.BT_VUE_COM.ToolTipImage = Nothing
        Me.BT_VUE_COM.ToolTipTitle = Nothing
        '
        'BT_VUE_PRODUIT
        '
        Me.BT_VUE_PRODUIT.AltKey = Nothing
        Me.BT_VUE_PRODUIT.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down
        Me.BT_VUE_PRODUIT.DropDownArrowSize = New System.Drawing.Size(5, 3)
        Me.BT_VUE_PRODUIT.Image = CType(resources.GetObject("BT_VUE_PRODUIT.Image"), System.Drawing.Image)
        Me.BT_VUE_PRODUIT.SmallImage = CType(resources.GetObject("BT_VUE_PRODUIT.SmallImage"), System.Drawing.Image)
        Me.BT_VUE_PRODUIT.Style = System.Windows.Forms.RibbonButtonStyle.Normal
        Me.BT_VUE_PRODUIT.Tag = Nothing
        Me.BT_VUE_PRODUIT.Text = "Vue des produits"
        Me.BT_VUE_PRODUIT.ToolTip = Nothing
        Me.BT_VUE_PRODUIT.ToolTipImage = Nothing
        Me.BT_VUE_PRODUIT.ToolTipTitle = Nothing
        '
        'BT_VUE_CLIENT
        '
        Me.BT_VUE_CLIENT.AltKey = Nothing
        Me.BT_VUE_CLIENT.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down
        Me.BT_VUE_CLIENT.DropDownArrowSize = New System.Drawing.Size(5, 3)
        Me.BT_VUE_CLIENT.Image = CType(resources.GetObject("BT_VUE_CLIENT.Image"), System.Drawing.Image)
        Me.BT_VUE_CLIENT.SmallImage = CType(resources.GetObject("BT_VUE_CLIENT.SmallImage"), System.Drawing.Image)
        Me.BT_VUE_CLIENT.Style = System.Windows.Forms.RibbonButtonStyle.Normal
        Me.BT_VUE_CLIENT.Tag = Nothing
        Me.BT_VUE_CLIENT.Text = "Vue des clients"
        Me.BT_VUE_CLIENT.ToolTip = Nothing
        Me.BT_VUE_CLIENT.ToolTipImage = Nothing
        Me.BT_VUE_CLIENT.ToolTipTitle = Nothing
        '
        'BT_VUE_FOURNISSEUR
        '
        Me.BT_VUE_FOURNISSEUR.AltKey = Nothing
        Me.BT_VUE_FOURNISSEUR.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down
        Me.BT_VUE_FOURNISSEUR.DropDownArrowSize = New System.Drawing.Size(5, 3)
        Me.BT_VUE_FOURNISSEUR.Image = CType(resources.GetObject("BT_VUE_FOURNISSEUR.Image"), System.Drawing.Image)
        Me.BT_VUE_FOURNISSEUR.SmallImage = CType(resources.GetObject("BT_VUE_FOURNISSEUR.SmallImage"), System.Drawing.Image)
        Me.BT_VUE_FOURNISSEUR.Style = System.Windows.Forms.RibbonButtonStyle.Normal
        Me.BT_VUE_FOURNISSEUR.Tag = Nothing
        Me.BT_VUE_FOURNISSEUR.Text = "Vue fournisseurs"
        Me.BT_VUE_FOURNISSEUR.ToolTip = Nothing
        Me.BT_VUE_FOURNISSEUR.ToolTipImage = Nothing
        Me.BT_VUE_FOURNISSEUR.ToolTipTitle = Nothing
        '
        'RB_GESTION
        '
        Me.RB_GESTION.Panels.Add(Me.GP_PRODUIT)
        Me.RB_GESTION.Panels.Add(Me.GP_COMMAND)
        Me.RB_GESTION.Panels.Add(Me.GP_CLIENT)
        Me.RB_GESTION.Tag = Nothing
        Me.RB_GESTION.Text = "Gestion"
        '
        'GP_PRODUIT
        '
        Me.GP_PRODUIT.ButtonMoreVisible = False
        Me.GP_PRODUIT.Items.Add(Me.BT_PRODUCT_ADD)
        Me.GP_PRODUIT.Items.Add(Me.BT_DEL_PRODUCT)
        Me.GP_PRODUIT.Items.Add(Me.BT_EDIT_PRODUCT)
        Me.GP_PRODUIT.Items.Add(Me.BT_PRODUCT_STOCK)
        Me.GP_PRODUIT.Items.Add(Me.BT_STOCK_MANAGER)
        Me.GP_PRODUIT.Tag = Nothing
        Me.GP_PRODUIT.Text = "Produit"
        '
        'BT_PRODUCT_ADD
        '
        Me.BT_PRODUCT_ADD.AltKey = Nothing
        Me.BT_PRODUCT_ADD.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down
        Me.BT_PRODUCT_ADD.DropDownArrowSize = New System.Drawing.Size(5, 3)
        Me.BT_PRODUCT_ADD.Image = CType(resources.GetObject("BT_PRODUCT_ADD.Image"), System.Drawing.Image)
        Me.BT_PRODUCT_ADD.SmallImage = CType(resources.GetObject("BT_PRODUCT_ADD.SmallImage"), System.Drawing.Image)
        Me.BT_PRODUCT_ADD.Style = System.Windows.Forms.RibbonButtonStyle.Normal
        Me.BT_PRODUCT_ADD.Tag = Nothing
        Me.BT_PRODUCT_ADD.Text = "Ajouter un produit"
        Me.BT_PRODUCT_ADD.ToolTip = Nothing
        Me.BT_PRODUCT_ADD.ToolTipImage = Nothing
        Me.BT_PRODUCT_ADD.ToolTipTitle = Nothing
        '
        'BT_DEL_PRODUCT
        '
        Me.BT_DEL_PRODUCT.AltKey = Nothing
        Me.BT_DEL_PRODUCT.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down
        Me.BT_DEL_PRODUCT.DropDownArrowSize = New System.Drawing.Size(5, 3)
        Me.BT_DEL_PRODUCT.Image = CType(resources.GetObject("BT_DEL_PRODUCT.Image"), System.Drawing.Image)
        Me.BT_DEL_PRODUCT.SmallImage = CType(resources.GetObject("BT_DEL_PRODUCT.SmallImage"), System.Drawing.Image)
        Me.BT_DEL_PRODUCT.Style = System.Windows.Forms.RibbonButtonStyle.Normal
        Me.BT_DEL_PRODUCT.Tag = Nothing
        Me.BT_DEL_PRODUCT.Text = "Suprimer un produit"
        Me.BT_DEL_PRODUCT.ToolTip = Nothing
        Me.BT_DEL_PRODUCT.ToolTipImage = Nothing
        Me.BT_DEL_PRODUCT.ToolTipTitle = Nothing
        '
        'BT_EDIT_PRODUCT
        '
        Me.BT_EDIT_PRODUCT.AltKey = Nothing
        Me.BT_EDIT_PRODUCT.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down
        Me.BT_EDIT_PRODUCT.DropDownArrowSize = New System.Drawing.Size(5, 3)
        Me.BT_EDIT_PRODUCT.Image = CType(resources.GetObject("BT_EDIT_PRODUCT.Image"), System.Drawing.Image)
        Me.BT_EDIT_PRODUCT.SmallImage = CType(resources.GetObject("BT_EDIT_PRODUCT.SmallImage"), System.Drawing.Image)
        Me.BT_EDIT_PRODUCT.Style = System.Windows.Forms.RibbonButtonStyle.Normal
        Me.BT_EDIT_PRODUCT.Tag = Nothing
        Me.BT_EDIT_PRODUCT.Text = "Modifier un produit"
        Me.BT_EDIT_PRODUCT.ToolTip = Nothing
        Me.BT_EDIT_PRODUCT.ToolTipImage = Nothing
        Me.BT_EDIT_PRODUCT.ToolTipTitle = Nothing
        '
        'BT_PRODUCT_STOCK
        '
        Me.BT_PRODUCT_STOCK.AltKey = Nothing
        Me.BT_PRODUCT_STOCK.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down
        Me.BT_PRODUCT_STOCK.DropDownArrowSize = New System.Drawing.Size(5, 3)
        Me.BT_PRODUCT_STOCK.Image = CType(resources.GetObject("BT_PRODUCT_STOCK.Image"), System.Drawing.Image)
        Me.BT_PRODUCT_STOCK.SmallImage = CType(resources.GetObject("BT_PRODUCT_STOCK.SmallImage"), System.Drawing.Image)
        Me.BT_PRODUCT_STOCK.Style = System.Windows.Forms.RibbonButtonStyle.Normal
        Me.BT_PRODUCT_STOCK.Tag = Nothing
        Me.BT_PRODUCT_STOCK.Text = "Stock"
        Me.BT_PRODUCT_STOCK.ToolTip = Nothing
        Me.BT_PRODUCT_STOCK.ToolTipImage = Nothing
        Me.BT_PRODUCT_STOCK.ToolTipTitle = Nothing
        '
        'GP_COMMAND
        '
        Me.GP_COMMAND.ButtonMoreVisible = False
        Me.GP_COMMAND.Items.Add(Me.BT_ADD_COMMAND)
        Me.GP_COMMAND.Items.Add(Me.BT_DELETE_COMMAND)
        Me.GP_COMMAND.Items.Add(Me.BT_EDIT_COMMAND)
        Me.GP_COMMAND.Tag = Nothing
        Me.GP_COMMAND.Text = "Commandes"
        '
        'BT_ADD_COMMAND
        '
        Me.BT_ADD_COMMAND.AltKey = Nothing
        Me.BT_ADD_COMMAND.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down
        Me.BT_ADD_COMMAND.DropDownArrowSize = New System.Drawing.Size(5, 3)
        Me.BT_ADD_COMMAND.Image = CType(resources.GetObject("BT_ADD_COMMAND.Image"), System.Drawing.Image)
        Me.BT_ADD_COMMAND.SmallImage = CType(resources.GetObject("BT_ADD_COMMAND.SmallImage"), System.Drawing.Image)
        Me.BT_ADD_COMMAND.Style = System.Windows.Forms.RibbonButtonStyle.Normal
        Me.BT_ADD_COMMAND.Tag = Nothing
        Me.BT_ADD_COMMAND.Text = "Ajouter une commande"
        Me.BT_ADD_COMMAND.ToolTip = Nothing
        Me.BT_ADD_COMMAND.ToolTipImage = Nothing
        Me.BT_ADD_COMMAND.ToolTipTitle = Nothing
        '
        'BT_DELETE_COMMAND
        '
        Me.BT_DELETE_COMMAND.AltKey = Nothing
        Me.BT_DELETE_COMMAND.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down
        Me.BT_DELETE_COMMAND.DropDownArrowSize = New System.Drawing.Size(5, 3)
        Me.BT_DELETE_COMMAND.Image = CType(resources.GetObject("BT_DELETE_COMMAND.Image"), System.Drawing.Image)
        Me.BT_DELETE_COMMAND.SmallImage = CType(resources.GetObject("BT_DELETE_COMMAND.SmallImage"), System.Drawing.Image)
        Me.BT_DELETE_COMMAND.Style = System.Windows.Forms.RibbonButtonStyle.Normal
        Me.BT_DELETE_COMMAND.Tag = Nothing
        Me.BT_DELETE_COMMAND.Text = "Supprimer une commande"
        Me.BT_DELETE_COMMAND.ToolTip = Nothing
        Me.BT_DELETE_COMMAND.ToolTipImage = Nothing
        Me.BT_DELETE_COMMAND.ToolTipTitle = Nothing
        '
        'BT_EDIT_COMMAND
        '
        Me.BT_EDIT_COMMAND.AltKey = Nothing
        Me.BT_EDIT_COMMAND.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down
        Me.BT_EDIT_COMMAND.DropDownArrowSize = New System.Drawing.Size(5, 3)
        Me.BT_EDIT_COMMAND.Image = CType(resources.GetObject("BT_EDIT_COMMAND.Image"), System.Drawing.Image)
        Me.BT_EDIT_COMMAND.SmallImage = CType(resources.GetObject("BT_EDIT_COMMAND.SmallImage"), System.Drawing.Image)
        Me.BT_EDIT_COMMAND.Style = System.Windows.Forms.RibbonButtonStyle.Normal
        Me.BT_EDIT_COMMAND.Tag = Nothing
        Me.BT_EDIT_COMMAND.Text = "Modifier une commande"
        Me.BT_EDIT_COMMAND.ToolTip = Nothing
        Me.BT_EDIT_COMMAND.ToolTipImage = Nothing
        Me.BT_EDIT_COMMAND.ToolTipTitle = Nothing
        '
        'GP_CLIENT
        '
        Me.GP_CLIENT.ButtonMoreVisible = False
        Me.GP_CLIENT.Items.Add(Me.BT_ADD_CLIENT)
        Me.GP_CLIENT.Items.Add(Me.BT_EDIT_ClIENT)
        Me.GP_CLIENT.Items.Add(Me.BT_DEL_CLIENT)
        Me.GP_CLIENT.Tag = Nothing
        Me.GP_CLIENT.Text = "Clients"
        '
        'BT_ADD_CLIENT
        '
        Me.BT_ADD_CLIENT.AltKey = Nothing
        Me.BT_ADD_CLIENT.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down
        Me.BT_ADD_CLIENT.DropDownArrowSize = New System.Drawing.Size(5, 3)
        Me.BT_ADD_CLIENT.Image = CType(resources.GetObject("BT_ADD_CLIENT.Image"), System.Drawing.Image)
        Me.BT_ADD_CLIENT.SmallImage = CType(resources.GetObject("BT_ADD_CLIENT.SmallImage"), System.Drawing.Image)
        Me.BT_ADD_CLIENT.Style = System.Windows.Forms.RibbonButtonStyle.Normal
        Me.BT_ADD_CLIENT.Tag = Nothing
        Me.BT_ADD_CLIENT.Text = "Ajouter client"
        Me.BT_ADD_CLIENT.ToolTip = Nothing
        Me.BT_ADD_CLIENT.ToolTipImage = Nothing
        Me.BT_ADD_CLIENT.ToolTipTitle = Nothing
        '
        'BT_EDIT_ClIENT
        '
        Me.BT_EDIT_ClIENT.AltKey = Nothing
        Me.BT_EDIT_ClIENT.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down
        Me.BT_EDIT_ClIENT.DropDownArrowSize = New System.Drawing.Size(5, 3)
        Me.BT_EDIT_ClIENT.Image = CType(resources.GetObject("BT_EDIT_ClIENT.Image"), System.Drawing.Image)
        Me.BT_EDIT_ClIENT.SmallImage = CType(resources.GetObject("BT_EDIT_ClIENT.SmallImage"), System.Drawing.Image)
        Me.BT_EDIT_ClIENT.Style = System.Windows.Forms.RibbonButtonStyle.Normal
        Me.BT_EDIT_ClIENT.Tag = Nothing
        Me.BT_EDIT_ClIENT.Text = "Modifier"
        Me.BT_EDIT_ClIENT.ToolTip = Nothing
        Me.BT_EDIT_ClIENT.ToolTipImage = Nothing
        Me.BT_EDIT_ClIENT.ToolTipTitle = Nothing
        '
        'BT_DEL_CLIENT
        '
        Me.BT_DEL_CLIENT.AltKey = Nothing
        Me.BT_DEL_CLIENT.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down
        Me.BT_DEL_CLIENT.DropDownArrowSize = New System.Drawing.Size(5, 3)
        Me.BT_DEL_CLIENT.Image = CType(resources.GetObject("BT_DEL_CLIENT.Image"), System.Drawing.Image)
        Me.BT_DEL_CLIENT.SmallImage = CType(resources.GetObject("BT_DEL_CLIENT.SmallImage"), System.Drawing.Image)
        Me.BT_DEL_CLIENT.Style = System.Windows.Forms.RibbonButtonStyle.Normal
        Me.BT_DEL_CLIENT.Tag = Nothing
        Me.BT_DEL_CLIENT.Text = "Suprimer"
        Me.BT_DEL_CLIENT.ToolTip = Nothing
        Me.BT_DEL_CLIENT.ToolTipImage = Nothing
        Me.BT_DEL_CLIENT.ToolTipTitle = Nothing
        '
        'RB_RAPPORT
        '
        Me.RB_RAPPORT.Panels.Add(Me.GP_RAPPORT)
        Me.RB_RAPPORT.Tag = Nothing
        Me.RB_RAPPORT.Text = "Rapport"
        '
        'GP_RAPPORT
        '
        Me.GP_RAPPORT.Enabled = False
        Me.GP_RAPPORT.Items.Add(Me.BT_RAP_JOUR)
        Me.GP_RAPPORT.Items.Add(Me.BT_RAP_WEEK)
        Me.GP_RAPPORT.Items.Add(Me.BT_RAP_MONTH)
        Me.GP_RAPPORT.Tag = Nothing
        Me.GP_RAPPORT.Text = "Rapport et impression"
        '
        'BT_RAP_JOUR
        '
        Me.BT_RAP_JOUR.AltKey = Nothing
        Me.BT_RAP_JOUR.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down
        Me.BT_RAP_JOUR.DropDownArrowSize = New System.Drawing.Size(5, 3)
        Me.BT_RAP_JOUR.Image = CType(resources.GetObject("BT_RAP_JOUR.Image"), System.Drawing.Image)
        Me.BT_RAP_JOUR.SmallImage = CType(resources.GetObject("BT_RAP_JOUR.SmallImage"), System.Drawing.Image)
        Me.BT_RAP_JOUR.Style = System.Windows.Forms.RibbonButtonStyle.Normal
        Me.BT_RAP_JOUR.Tag = Nothing
        Me.BT_RAP_JOUR.Text = "Rapport de la journée"
        Me.BT_RAP_JOUR.ToolTip = Nothing
        Me.BT_RAP_JOUR.ToolTipImage = Nothing
        Me.BT_RAP_JOUR.ToolTipTitle = Nothing
        '
        'BT_RAP_WEEK
        '
        Me.BT_RAP_WEEK.AltKey = Nothing
        Me.BT_RAP_WEEK.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down
        Me.BT_RAP_WEEK.DropDownArrowSize = New System.Drawing.Size(5, 3)
        Me.BT_RAP_WEEK.Image = CType(resources.GetObject("BT_RAP_WEEK.Image"), System.Drawing.Image)
        Me.BT_RAP_WEEK.SmallImage = CType(resources.GetObject("BT_RAP_WEEK.SmallImage"), System.Drawing.Image)
        Me.BT_RAP_WEEK.Style = System.Windows.Forms.RibbonButtonStyle.Normal
        Me.BT_RAP_WEEK.Tag = Nothing
        Me.BT_RAP_WEEK.Text = "Rapport de la semaine"
        Me.BT_RAP_WEEK.ToolTip = Nothing
        Me.BT_RAP_WEEK.ToolTipImage = Nothing
        Me.BT_RAP_WEEK.ToolTipTitle = Nothing
        '
        'BT_RAP_MONTH
        '
        Me.BT_RAP_MONTH.AltKey = Nothing
        Me.BT_RAP_MONTH.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down
        Me.BT_RAP_MONTH.DropDownArrowSize = New System.Drawing.Size(5, 3)
        Me.BT_RAP_MONTH.Image = CType(resources.GetObject("BT_RAP_MONTH.Image"), System.Drawing.Image)
        Me.BT_RAP_MONTH.SmallImage = CType(resources.GetObject("BT_RAP_MONTH.SmallImage"), System.Drawing.Image)
        Me.BT_RAP_MONTH.Style = System.Windows.Forms.RibbonButtonStyle.Normal
        Me.BT_RAP_MONTH.Tag = Nothing
        Me.BT_RAP_MONTH.Text = "Rapport du mois"
        Me.BT_RAP_MONTH.ToolTip = Nothing
        Me.BT_RAP_MONTH.ToolTipImage = Nothing
        Me.BT_RAP_MONTH.ToolTipTitle = Nothing
        '
        'STAT_BAR
        '
        Me.STAT_BAR.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.BAR_ETAT})
        Me.STAT_BAR.Location = New System.Drawing.Point(0, 577)
        Me.STAT_BAR.Name = "STAT_BAR"
        Me.STAT_BAR.Size = New System.Drawing.Size(1113, 22)
        Me.STAT_BAR.TabIndex = 1
        Me.STAT_BAR.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(45, 17)
        Me.ToolStripStatusLabel1.Text = "Status: "
        '
        'BAR_ETAT
        '
        Me.BAR_ETAT.Name = "BAR_ETAT"
        Me.BAR_ETAT.Size = New System.Drawing.Size(0, 17)
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 138)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.STOCK_LIST)
        Me.SplitContainer1.Panel2.Controls.Add(Me.VU_COMMAND)
        Me.SplitContainer1.Panel2.Controls.Add(Me.FORNISSEUR_DATA_GRID)
        Me.SplitContainer1.Panel2.Controls.Add(Me.CLIENT_DATA_VIEW)
        Me.SplitContainer1.Panel2.Controls.Add(Me.PRODUCT_DATA_GRID)
        Me.SplitContainer1.Panel2.Controls.Add(Me.VU_RAPPORT)
        Me.SplitContainer1.Size = New System.Drawing.Size(1113, 439)
        Me.SplitContainer1.SplitterDistance = 231
        Me.SplitContainer1.TabIndex = 2
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Button5)
        Me.GroupBox2.Controls.Add(Me.Button6)
        Me.GroupBox2.Controls.Add(Me.Button7)
        Me.GroupBox2.Controls.Add(Me.Button8)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 176)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(221, 159)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Alert Stock"
        Me.GroupBox2.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(30, 72)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Faible stock"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(186, 109)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(13, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "0"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(78, 108)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(13, 13)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "0"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(186, 42)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(13, 13)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "0"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(78, 42)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(13, 13)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "0"
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button5.FlatAppearance.BorderColor = System.Drawing.SystemColors.Menu
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button5.Location = New System.Drawing.Point(133, 99)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(78, 31)
        Me.Button5.TabIndex = 0
        Me.Button5.Text = "Afficher:"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button6.FlatAppearance.BorderColor = System.Drawing.SystemColors.Menu
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button6.Location = New System.Drawing.Point(26, 99)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(78, 31)
        Me.Button6.TabIndex = 0
        Me.Button6.Text = "Afficher:"
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button7.FlatAppearance.BorderColor = System.Drawing.SystemColors.Menu
        Me.Button7.FlatAppearance.BorderSize = 0
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button7.Location = New System.Drawing.Point(133, 32)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(78, 31)
        Me.Button7.TabIndex = 0
        Me.Button7.Text = "Afficher:"
        Me.Button7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button8.FlatAppearance.BorderColor = System.Drawing.SystemColors.Menu
        Me.Button8.FlatAppearance.BorderSize = 0
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button8.Location = New System.Drawing.Point(24, 32)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(78, 31)
        Me.Button8.TabIndex = 0
        Me.Button8.Text = "Afficher:"
        Me.Button8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button8.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.FORT__NUMBER)
        Me.GroupBox1.Controls.Add(Me.BON__NUMBER)
        Me.GroupBox1.Controls.Add(Me.FAIBLE__NUMBER)
        Me.GroupBox1.Controls.Add(Me.RUPTURE_NUMBER)
        Me.GroupBox1.Controls.Add(Me.BT_FORT)
        Me.GroupBox1.Controls.Add(Me.BT_BON)
        Me.GroupBox1.Controls.Add(Me.BT_FAIBLE)
        Me.GroupBox1.Controls.Add(Me.BP_RUPTURE)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 11)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(221, 159)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Alert Stock"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(135, 133)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(47, 13)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Trop fort"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(30, 133)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(26, 13)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "Bon"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(135, 68)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(35, 13)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Faible"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(30, 68)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Rupture"
        '
        'FORT__NUMBER
        '
        Me.FORT__NUMBER.AutoSize = True
        Me.FORT__NUMBER.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.FORT__NUMBER.Location = New System.Drawing.Point(186, 109)
        Me.FORT__NUMBER.Name = "FORT__NUMBER"
        Me.FORT__NUMBER.Size = New System.Drawing.Size(13, 13)
        Me.FORT__NUMBER.TabIndex = 1
        Me.FORT__NUMBER.Text = "0"
        '
        'BON__NUMBER
        '
        Me.BON__NUMBER.AutoSize = True
        Me.BON__NUMBER.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BON__NUMBER.Location = New System.Drawing.Point(78, 108)
        Me.BON__NUMBER.Name = "BON__NUMBER"
        Me.BON__NUMBER.Size = New System.Drawing.Size(13, 13)
        Me.BON__NUMBER.TabIndex = 1
        Me.BON__NUMBER.Text = "0"
        '
        'FAIBLE__NUMBER
        '
        Me.FAIBLE__NUMBER.AutoSize = True
        Me.FAIBLE__NUMBER.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.FAIBLE__NUMBER.Location = New System.Drawing.Point(186, 42)
        Me.FAIBLE__NUMBER.Name = "FAIBLE__NUMBER"
        Me.FAIBLE__NUMBER.Size = New System.Drawing.Size(13, 13)
        Me.FAIBLE__NUMBER.TabIndex = 1
        Me.FAIBLE__NUMBER.Text = "0"
        '
        'RUPTURE_NUMBER
        '
        Me.RUPTURE_NUMBER.AutoSize = True
        Me.RUPTURE_NUMBER.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.RUPTURE_NUMBER.Location = New System.Drawing.Point(78, 42)
        Me.RUPTURE_NUMBER.Name = "RUPTURE_NUMBER"
        Me.RUPTURE_NUMBER.Size = New System.Drawing.Size(13, 13)
        Me.RUPTURE_NUMBER.TabIndex = 1
        Me.RUPTURE_NUMBER.Text = "0"
        '
        'BT_FORT
        '
        Me.BT_FORT.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BT_FORT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BT_FORT.FlatAppearance.BorderColor = System.Drawing.SystemColors.Menu
        Me.BT_FORT.FlatAppearance.BorderSize = 0
        Me.BT_FORT.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BT_FORT.Location = New System.Drawing.Point(133, 99)
        Me.BT_FORT.Name = "BT_FORT"
        Me.BT_FORT.Size = New System.Drawing.Size(78, 31)
        Me.BT_FORT.TabIndex = 0
        Me.BT_FORT.Text = "Afficher:"
        Me.BT_FORT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BT_FORT.UseVisualStyleBackColor = False
        '
        'BT_BON
        '
        Me.BT_BON.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BT_BON.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BT_BON.FlatAppearance.BorderColor = System.Drawing.SystemColors.Menu
        Me.BT_BON.FlatAppearance.BorderSize = 0
        Me.BT_BON.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BT_BON.Location = New System.Drawing.Point(26, 99)
        Me.BT_BON.Name = "BT_BON"
        Me.BT_BON.Size = New System.Drawing.Size(78, 31)
        Me.BT_BON.TabIndex = 0
        Me.BT_BON.Text = "Afficher:"
        Me.BT_BON.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BT_BON.UseVisualStyleBackColor = False
        '
        'BT_FAIBLE
        '
        Me.BT_FAIBLE.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BT_FAIBLE.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BT_FAIBLE.FlatAppearance.BorderColor = System.Drawing.SystemColors.Menu
        Me.BT_FAIBLE.FlatAppearance.BorderSize = 0
        Me.BT_FAIBLE.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BT_FAIBLE.Location = New System.Drawing.Point(133, 32)
        Me.BT_FAIBLE.Name = "BT_FAIBLE"
        Me.BT_FAIBLE.Size = New System.Drawing.Size(78, 31)
        Me.BT_FAIBLE.TabIndex = 0
        Me.BT_FAIBLE.Text = "Afficher:"
        Me.BT_FAIBLE.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BT_FAIBLE.UseVisualStyleBackColor = False
        '
        'BP_RUPTURE
        '
        Me.BP_RUPTURE.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BP_RUPTURE.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BP_RUPTURE.FlatAppearance.BorderColor = System.Drawing.SystemColors.Menu
        Me.BP_RUPTURE.FlatAppearance.BorderSize = 0
        Me.BP_RUPTURE.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BP_RUPTURE.Location = New System.Drawing.Point(24, 32)
        Me.BP_RUPTURE.Name = "BP_RUPTURE"
        Me.BP_RUPTURE.Size = New System.Drawing.Size(78, 31)
        Me.BP_RUPTURE.TabIndex = 0
        Me.BP_RUPTURE.Text = "Afficher:"
        Me.BP_RUPTURE.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BP_RUPTURE.UseVisualStyleBackColor = False
        '
        'STOCK_LIST
        '
        Me.STOCK_LIST.AllowUserToAddRows = False
        Me.STOCK_LIST.AllowUserToDeleteRows = False
        Me.STOCK_LIST.AllowUserToResizeColumns = False
        Me.STOCK_LIST.AllowUserToResizeRows = False
        Me.STOCK_LIST.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.STOCK_LIST.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_stock, Me.product_name, Me.product_stat, Me.product_quantite})
        Me.STOCK_LIST.Dock = System.Windows.Forms.DockStyle.Fill
        Me.STOCK_LIST.Location = New System.Drawing.Point(0, 0)
        Me.STOCK_LIST.Name = "STOCK_LIST"
        Me.STOCK_LIST.Size = New System.Drawing.Size(878, 439)
        Me.STOCK_LIST.TabIndex = 5
        Me.STOCK_LIST.Visible = False
        '
        'id_stock
        '
        Me.id_stock.HeaderText = "id"
        Me.id_stock.Name = "id_stock"
        Me.id_stock.ReadOnly = True
        Me.id_stock.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.id_stock.Visible = False
        '
        'product_name
        '
        Me.product_name.HeaderText = "nom"
        Me.product_name.Name = "product_name"
        Me.product_name.ReadOnly = True
        Me.product_name.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.product_name.Width = 200
        '
        'product_stat
        '
        Me.product_stat.HeaderText = "Status"
        Me.product_stat.Name = "product_stat"
        Me.product_stat.ReadOnly = True
        '
        'product_quantite
        '
        Me.product_quantite.HeaderText = "Quantité"
        Me.product_quantite.Name = "product_quantite"
        '
        'VU_COMMAND
        '
        Me.VU_COMMAND.AllowUserToAddRows = False
        Me.VU_COMMAND.AllowUserToDeleteRows = False
        Me.VU_COMMAND.AllowUserToResizeRows = False
        Me.VU_COMMAND.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.VU_COMMAND.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idCommand, Me.produitCommand, Me.clientCommand, Me.contactCommand, Me.adressDeLivraison, Me.netPayer, Me.etatCommand, Me.proprieteCommand})
        Me.VU_COMMAND.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VU_COMMAND.Location = New System.Drawing.Point(0, 0)
        Me.VU_COMMAND.Name = "VU_COMMAND"
        Me.VU_COMMAND.Size = New System.Drawing.Size(878, 439)
        Me.VU_COMMAND.TabIndex = 4
        Me.VU_COMMAND.Visible = False
        '
        'idCommand
        '
        Me.idCommand.HeaderText = "id"
        Me.idCommand.Name = "idCommand"
        Me.idCommand.Visible = False
        Me.idCommand.Width = 40
        '
        'produitCommand
        '
        Me.produitCommand.HeaderText = "nom du produit"
        Me.produitCommand.Name = "produitCommand"
        '
        'clientCommand
        '
        Me.clientCommand.HeaderText = "nom du client"
        Me.clientCommand.Name = "clientCommand"
        Me.clientCommand.Width = 150
        '
        'contactCommand
        '
        Me.contactCommand.HeaderText = "contact"
        Me.contactCommand.Name = "contactCommand"
        '
        'adressDeLivraison
        '
        Me.adressDeLivraison.HeaderText = "adresse de livraison"
        Me.adressDeLivraison.Name = "adressDeLivraison"
        Me.adressDeLivraison.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.adressDeLivraison.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.adressDeLivraison.Width = 120
        '
        'netPayer
        '
        Me.netPayer.HeaderText = "net à payer"
        Me.netPayer.Name = "netPayer"
        Me.netPayer.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.netPayer.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'etatCommand
        '
        Me.etatCommand.HeaderText = "status"
        Me.etatCommand.Name = "etatCommand"
        Me.etatCommand.ReadOnly = True
        Me.etatCommand.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'proprieteCommand
        '
        Me.proprieteCommand.HeaderText = "Id de l'agent"
        Me.proprieteCommand.Name = "proprieteCommand"
        '
        'FORNISSEUR_DATA_GRID
        '
        Me.FORNISSEUR_DATA_GRID.AllowUserToAddRows = False
        Me.FORNISSEUR_DATA_GRID.AllowUserToDeleteRows = False
        Me.FORNISSEUR_DATA_GRID.AllowUserToResizeRows = False
        Me.FORNISSEUR_DATA_GRID.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FORNISSEUR_DATA_GRID.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idFournisseur, Me.nameFournisseur, Me.codeFournisseur})
        Me.FORNISSEUR_DATA_GRID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FORNISSEUR_DATA_GRID.Location = New System.Drawing.Point(0, 0)
        Me.FORNISSEUR_DATA_GRID.Name = "FORNISSEUR_DATA_GRID"
        Me.FORNISSEUR_DATA_GRID.Size = New System.Drawing.Size(878, 439)
        Me.FORNISSEUR_DATA_GRID.TabIndex = 3
        Me.FORNISSEUR_DATA_GRID.Visible = False
        '
        'idFournisseur
        '
        Me.idFournisseur.HeaderText = "id"
        Me.idFournisseur.Name = "idFournisseur"
        Me.idFournisseur.Visible = False
        '
        'nameFournisseur
        '
        Me.nameFournisseur.HeaderText = "nom"
        Me.nameFournisseur.Name = "nameFournisseur"
        '
        'codeFournisseur
        '
        Me.codeFournisseur.HeaderText = "code"
        Me.codeFournisseur.Name = "codeFournisseur"
        '
        'CLIENT_DATA_VIEW
        '
        Me.CLIENT_DATA_VIEW.AllowUserToAddRows = False
        Me.CLIENT_DATA_VIEW.AllowUserToDeleteRows = False
        Me.CLIENT_DATA_VIEW.AllowUserToResizeRows = False
        Me.CLIENT_DATA_VIEW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CLIENT_DATA_VIEW.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idClient, Me.nameClient, Me.contactClient, Me.communeClient})
        Me.CLIENT_DATA_VIEW.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CLIENT_DATA_VIEW.Location = New System.Drawing.Point(0, 0)
        Me.CLIENT_DATA_VIEW.Name = "CLIENT_DATA_VIEW"
        Me.CLIENT_DATA_VIEW.Size = New System.Drawing.Size(878, 439)
        Me.CLIENT_DATA_VIEW.TabIndex = 2
        Me.CLIENT_DATA_VIEW.Visible = False
        '
        'idClient
        '
        Me.idClient.HeaderText = "id"
        Me.idClient.Name = "idClient"
        Me.idClient.Visible = False
        '
        'nameClient
        '
        Me.nameClient.HeaderText = "Nom"
        Me.nameClient.Name = "nameClient"
        Me.nameClient.Width = 200
        '
        'contactClient
        '
        Me.contactClient.HeaderText = "Contact"
        Me.contactClient.Name = "contactClient"
        Me.contactClient.Width = 150
        '
        'communeClient
        '
        Me.communeClient.HeaderText = "Commune"
        Me.communeClient.Name = "communeClient"
        Me.communeClient.Width = 150
        '
        'PRODUCT_DATA_GRID
        '
        Me.PRODUCT_DATA_GRID.AllowUserToAddRows = False
        Me.PRODUCT_DATA_GRID.AllowUserToDeleteRows = False
        Me.PRODUCT_DATA_GRID.AllowUserToOrderColumns = True
        Me.PRODUCT_DATA_GRID.AllowUserToResizeRows = False
        Me.PRODUCT_DATA_GRID.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PRODUCT_DATA_GRID.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idpro, Me.namepro, Me.code, Me.price, Me.description, Me.status, Me.quantity})
        Me.PRODUCT_DATA_GRID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PRODUCT_DATA_GRID.Location = New System.Drawing.Point(0, 0)
        Me.PRODUCT_DATA_GRID.Name = "PRODUCT_DATA_GRID"
        Me.PRODUCT_DATA_GRID.ReadOnly = True
        Me.PRODUCT_DATA_GRID.Size = New System.Drawing.Size(878, 439)
        Me.PRODUCT_DATA_GRID.TabIndex = 1
        Me.PRODUCT_DATA_GRID.Visible = False
        '
        'idpro
        '
        Me.idpro.HeaderText = "Id"
        Me.idpro.Name = "idpro"
        Me.idpro.ReadOnly = True
        Me.idpro.Visible = False
        '
        'namepro
        '
        Me.namepro.HeaderText = "code"
        Me.namepro.Name = "namepro"
        Me.namepro.ReadOnly = True
        Me.namepro.Width = 150
        '
        'code
        '
        Me.code.HeaderText = "nom"
        Me.code.Name = "code"
        Me.code.ReadOnly = True
        '
        'price
        '
        Me.price.HeaderText = "Prix"
        Me.price.Name = "price"
        Me.price.ReadOnly = True
        '
        'description
        '
        Me.description.HeaderText = "Description"
        Me.description.Name = "description"
        Me.description.ReadOnly = True
        Me.description.Width = 200
        '
        'status
        '
        Me.status.HeaderText = "Status"
        Me.status.Name = "status"
        Me.status.ReadOnly = True
        '
        'quantity
        '
        Me.quantity.HeaderText = "Quantité"
        Me.quantity.Name = "quantity"
        Me.quantity.ReadOnly = True
        '
        'APP_CONFIG
        '
        Me.APP_CONFIG.AltKey = Nothing
        Me.APP_CONFIG.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down
        Me.APP_CONFIG.DropDownArrowSize = New System.Drawing.Size(5, 3)
        Me.APP_CONFIG.Image = CType(resources.GetObject("APP_CONFIG.Image"), System.Drawing.Image)
        Me.APP_CONFIG.SmallImage = CType(resources.GetObject("APP_CONFIG.SmallImage"), System.Drawing.Image)
        Me.APP_CONFIG.Style = System.Windows.Forms.RibbonButtonStyle.Normal
        Me.APP_CONFIG.Tag = Nothing
        Me.APP_CONFIG.Text = "Configuration"
        Me.APP_CONFIG.ToolTip = Nothing
        Me.APP_CONFIG.ToolTipImage = Nothing
        Me.APP_CONFIG.ToolTipTitle = Nothing
        '
        'UpDateTimer
        '
        Me.UpDateTimer.Interval = 1000
        '
        'BT_STOCK_MANAGER
        '
        Me.BT_STOCK_MANAGER.AltKey = Nothing
        Me.BT_STOCK_MANAGER.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down
        Me.BT_STOCK_MANAGER.DropDownArrowSize = New System.Drawing.Size(5, 3)
        Me.BT_STOCK_MANAGER.Image = CType(resources.GetObject("BT_STOCK_MANAGER.Image"), System.Drawing.Image)
        Me.BT_STOCK_MANAGER.SmallImage = CType(resources.GetObject("BT_STOCK_MANAGER.SmallImage"), System.Drawing.Image)
        Me.BT_STOCK_MANAGER.Style = System.Windows.Forms.RibbonButtonStyle.Normal
        Me.BT_STOCK_MANAGER.Tag = Nothing
        Me.BT_STOCK_MANAGER.Text = "Gestion de stock"
        Me.BT_STOCK_MANAGER.ToolTip = Nothing
        Me.BT_STOCK_MANAGER.ToolTipImage = Nothing
        Me.BT_STOCK_MANAGER.ToolTipTitle = Nothing
        '
        'MainController
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1113, 599)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.STAT_BAR)
        Me.Controls.Add(Me.Ribbon1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainController"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Beeshop business manager v.2.001"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.VU_RAPPORT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.STAT_BAR.ResumeLayout(False)
        Me.STAT_BAR.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.STOCK_LIST, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VU_COMMAND, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FORNISSEUR_DATA_GRID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CLIENT_DATA_VIEW, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PRODUCT_DATA_GRID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Ribbon1 As Ribbon
    Friend WithEvents RB_ACCEUIL As RibbonTab
    Friend WithEvents GP_CONNEXION As RibbonPanel
    Friend WithEvents GP_VUE As RibbonPanel
    Friend WithEvents RB_GESTION As RibbonTab
    Friend WithEvents RB_RAPPORT As RibbonTab
    Friend WithEvents BT_CON As RibbonButton
    Friend WithEvents BT_DCO As RibbonButton
    Friend WithEvents BT_VUE_CLIENT As RibbonButton
    Friend WithEvents BT_VUE_PRODUIT As RibbonButton
    Friend WithEvents BT_VUE_FOURNISSEUR As RibbonButton
    Friend WithEvents GP_CLIENT As RibbonPanel
    Friend WithEvents BT_ADD_CLIENT As RibbonButton
    Friend WithEvents BT_EDIT_ClIENT As RibbonButton
    Friend WithEvents BT_DEL_CLIENT As RibbonButton
    Friend WithEvents GP_COMMAND As RibbonPanel
    Friend WithEvents GP_PRODUIT As RibbonPanel
    Friend WithEvents BT_ADD_COMMAND As RibbonButton
    Friend WithEvents BT_DELETE_COMMAND As RibbonButton
    Friend WithEvents BT_EDIT_COMMAND As RibbonButton
    Friend WithEvents BT_PRODUCT_ADD As RibbonButton
    Friend WithEvents BT_DEL_PRODUCT As RibbonButton
    Friend WithEvents BT_EDIT_PRODUCT As RibbonButton
    Friend WithEvents BT_PRODUCT_STOCK As RibbonButton
    Friend WithEvents STAT_BAR As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents BAR_ETAT As ToolStripStatusLabel
    Friend WithEvents GP_RAPPORT As RibbonPanel
    Friend WithEvents BT_RAP_JOUR As RibbonButton
    Friend WithEvents BT_RAP_WEEK As RibbonButton
    Friend WithEvents BT_RAP_MONTH As RibbonButton
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents PRODUCT_DATA_GRID As DataGridView
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents nameuser As DataGridViewTextBoxColumn
    Friend WithEvents produit As DataGridViewTextBoxColumn
    Friend WithEvents client As DataGridViewTextBoxColumn
    Friend WithEvents contact As DataGridViewTextBoxColumn
    Friend WithEvents adresse As DataGridViewButtonColumn
    Friend WithEvents prix_achat As DataGridViewButtonColumn
    Friend WithEvents prix_vente As DataGridViewButtonColumn
    Friend WithEvents benefice As DataGridViewTextBoxColumn
    Friend WithEvents vendu_par As DataGridViewTextBoxColumn
    Friend WithEvents source As DataGridViewTextBoxColumn
    Friend WithEvents CLIENT_DATA_VIEW As DataGridView
    Friend WithEvents idClient As DataGridViewTextBoxColumn
    Friend WithEvents nameClient As DataGridViewTextBoxColumn
    Friend WithEvents contactClient As DataGridViewTextBoxColumn
    Friend WithEvents communeClient As DataGridViewTextBoxColumn
    Friend WithEvents VU_RAPPORT As DataGridView
    Friend WithEvents FORNISSEUR_DATA_GRID As DataGridView
    Friend WithEvents idFournisseur As DataGridViewTextBoxColumn
    Friend WithEvents nameFournisseur As DataGridViewTextBoxColumn
    Friend WithEvents codeFournisseur As DataGridViewTextBoxColumn
    Friend WithEvents VU_COMMAND As DataGridView
    Friend WithEvents idpro As DataGridViewTextBoxColumn
    Friend WithEvents namepro As DataGridViewTextBoxColumn
    Friend WithEvents code As DataGridViewTextBoxColumn
    Friend WithEvents price As DataGridViewTextBoxColumn
    Friend WithEvents description As DataGridViewTextBoxColumn
    Friend WithEvents status As DataGridViewTextBoxColumn
    Friend WithEvents quantity As DataGridViewTextBoxColumn
    Friend WithEvents RibbonButton1 As RibbonButton
    Friend WithEvents APP_CONFIG As RibbonButton
    Friend WithEvents BP_RUPTURE As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents FORT__NUMBER As Label
    Friend WithEvents BON__NUMBER As Label
    Friend WithEvents FAIBLE__NUMBER As Label
    Friend WithEvents RUPTURE_NUMBER As Label
    Friend WithEvents BT_FORT As Button
    Friend WithEvents BT_BON As Button
    Friend WithEvents BT_FAIBLE As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents UpDateTimer As Timer
    Friend WithEvents MENU_PROGRAMME As RibbonOrbMenuItem
    Friend WithEvents RibbonSeparator1 As RibbonSeparator
    Friend WithEvents RibbonSeparator2 As RibbonSeparator
    Friend WithEvents RibbonOrbOptionButton1 As RibbonOrbOptionButton
    Friend WithEvents BT_IMPRESSION As RibbonOrbMenuItem
    Friend WithEvents RibbonSeparator3 As RibbonSeparator
    Friend WithEvents RibbonSeparator4 As RibbonSeparator
    Friend WithEvents BT_ENREGISTRER As RibbonOrbMenuItem
    Friend WithEvents RibbonSeparator5 As RibbonSeparator
    Friend WithEvents RibbonSeparator6 As RibbonSeparator
    Friend WithEvents BT_ENREGISTRER_SOUS As RibbonOrbMenuItem
    Friend WithEvents idCommand As DataGridViewTextBoxColumn
    Friend WithEvents produitCommand As DataGridViewTextBoxColumn
    Friend WithEvents clientCommand As DataGridViewTextBoxColumn
    Friend WithEvents contactCommand As DataGridViewTextBoxColumn
    Friend WithEvents adressDeLivraison As DataGridViewTextBoxColumn
    Friend WithEvents netPayer As DataGridViewTextBoxColumn
    Friend WithEvents etatCommand As DataGridViewButtonColumn
    Friend WithEvents proprieteCommand As DataGridViewTextBoxColumn
    Friend WithEvents STOCK_LIST As DataGridView
    Friend WithEvents id_stock As DataGridViewTextBoxColumn
    Friend WithEvents product_name As DataGridViewTextBoxColumn
    Friend WithEvents product_stat As DataGridViewTextBoxColumn
    Friend WithEvents product_quantite As DataGridViewTextBoxColumn
    Private WithEvents BT_VUE_COM As RibbonButton
    Friend WithEvents BT_STOCK_MANAGER As RibbonButton
End Class
