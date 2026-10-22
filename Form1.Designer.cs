namespace Nordic_Real_Estates___Version_2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            estateCategories = new ContextMenuStrip(components);
            menuResidential = new ToolStripMenuItem();
            menuVilla = new ToolStripMenuItem();
            menuCommercial = new ToolStripMenuItem();
            menuShop = new ToolStripMenuItem();
            menuInstitutional = new ToolStripMenuItem();
            menuSchool = new ToolStripMenuItem();
            btnEstateType = new Button();
            txtEstateSelected = new TextBox();
            txtCity = new TextBox();
            txtZipCode = new TextBox();
            txtStreet = new TextBox();
            txtID = new TextBox();
            grpVilla = new GroupBox();
            chkHasGarage = new CheckBox();
            txtGardenArea = new TextBox();
            txtLivingArea = new TextBox();
            txtNumberOfRooms = new TextBox();
            lblRooms = new Label();
            lblLivingArea = new Label();
            lblGardenArea = new Label();
            grpShop = new GroupBox();
            chkHasStorage = new CheckBox();
            lblEntrances = new Label();
            txtNumberOfEntrances = new TextBox();
            lblBusinessArea = new Label();
            txtBusinessArea = new TextBox();
            lblEmployees = new Label();
            txtNumberOfEmployees = new TextBox();
            grpSchool = new GroupBox();
            chkHasCafeteria = new CheckBox();
            txtCapacity = new TextBox();
            txtNumberOfClassrooms = new TextBox();
            lblClassrooms = new Label();
            txtNumberOfBuildings = new TextBox();
            lblCapacity = new Label();
            lblBuildings = new Label();
            grpAddress = new GroupBox();
            lblID = new Label();
            cmbCountry = new ComboBox();
            lblStreet = new Label();
            lblZipCode = new Label();
            lblCountry = new Label();
            lblCity = new Label();
            lblEstatePlanner = new Label();
            btnDelEstate = new Button();
            btnAddEstate = new Button();
            lstEstates = new ListBox();
            lblEstates = new Label();
            btnModifyEstate = new Button();
            btnApplyChanges = new Button();
            btnSave = new Button();
            estateCategories.SuspendLayout();
            grpVilla.SuspendLayout();
            grpShop.SuspendLayout();
            grpSchool.SuspendLayout();
            grpAddress.SuspendLayout();
            SuspendLayout();
            // 
            // estateCategories
            // 
            estateCategories.Items.AddRange(new ToolStripItem[] { menuResidential, menuCommercial, menuInstitutional });
            estateCategories.Name = "estateCategories";
            estateCategories.Size = new Size(140, 70);
            estateCategories.Text = "Categories";
            // 
            // menuResidential
            // 
            menuResidential.DropDownItems.AddRange(new ToolStripItem[] { menuVilla });
            menuResidential.Name = "menuResidential";
            menuResidential.Size = new Size(139, 22);
            menuResidential.Text = "Residential";
            // 
            // menuVilla
            // 
            menuVilla.Name = "menuVilla";
            menuVilla.Size = new Size(96, 22);
            menuVilla.Text = "Villa";
            menuVilla.Click += menuVilla_Click;
            // 
            // menuCommercial
            // 
            menuCommercial.DropDownItems.AddRange(new ToolStripItem[] { menuShop });
            menuCommercial.Name = "menuCommercial";
            menuCommercial.Size = new Size(139, 22);
            menuCommercial.Text = "Commercial";
            // 
            // menuShop
            // 
            menuShop.Name = "menuShop";
            menuShop.Size = new Size(101, 22);
            menuShop.Text = "Shop";
            menuShop.Click += menuShop_Click;
            // 
            // menuInstitutional
            // 
            menuInstitutional.DropDownItems.AddRange(new ToolStripItem[] { menuSchool });
            menuInstitutional.Name = "menuInstitutional";
            menuInstitutional.Size = new Size(139, 22);
            menuInstitutional.Text = "Institutional";
            // 
            // menuSchool
            // 
            menuSchool.Name = "menuSchool";
            menuSchool.Size = new Size(110, 22);
            menuSchool.Text = "School";
            menuSchool.Click += menuSchool_Click;
            // 
            // btnEstateType
            // 
            btnEstateType.Font = new Font("Mongolian Baiti", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEstateType.Location = new Point(12, 35);
            btnEstateType.Name = "btnEstateType";
            btnEstateType.Size = new Size(137, 23);
            btnEstateType.TabIndex = 1;
            btnEstateType.Text = "Select Estate Type";
            btnEstateType.UseVisualStyleBackColor = true;
            btnEstateType.Click += button1_Click;
            // 
            // txtEstateSelected
            // 
            txtEstateSelected.Font = new Font("Mongolian Baiti", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEstateSelected.Location = new Point(155, 35);
            txtEstateSelected.Name = "txtEstateSelected";
            txtEstateSelected.ReadOnly = true;
            txtEstateSelected.Size = new Size(100, 25);
            txtEstateSelected.TabIndex = 2;
            // 
            // txtCity
            // 
            txtCity.Font = new Font("Mongolian Baiti", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCity.Location = new Point(136, 117);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(100, 25);
            txtCity.TabIndex = 7;
            // 
            // txtZipCode
            // 
            txtZipCode.Font = new Font("Mongolian Baiti", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtZipCode.Location = new Point(136, 86);
            txtZipCode.Name = "txtZipCode";
            txtZipCode.Size = new Size(100, 25);
            txtZipCode.TabIndex = 6;
            // 
            // txtStreet
            // 
            txtStreet.Font = new Font("Mongolian Baiti", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStreet.Location = new Point(136, 55);
            txtStreet.Name = "txtStreet";
            txtStreet.Size = new Size(100, 25);
            txtStreet.TabIndex = 5;
            // 
            // txtID
            // 
            txtID.Font = new Font("Mongolian Baiti", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtID.Location = new Point(136, 24);
            txtID.Name = "txtID";
            txtID.Size = new Size(100, 25);
            txtID.TabIndex = 4;
            // 
            // grpVilla
            // 
            grpVilla.Controls.Add(chkHasGarage);
            grpVilla.Controls.Add(txtGardenArea);
            grpVilla.Controls.Add(txtLivingArea);
            grpVilla.Controls.Add(txtNumberOfRooms);
            grpVilla.Controls.Add(lblRooms);
            grpVilla.Controls.Add(lblLivingArea);
            grpVilla.Controls.Add(lblGardenArea);
            grpVilla.Font = new Font("Mongolian Baiti", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpVilla.Location = new Point(12, 264);
            grpVilla.Name = "grpVilla";
            grpVilla.Size = new Size(250, 180);
            grpVilla.TabIndex = 9;
            grpVilla.TabStop = false;
            grpVilla.Text = "Residential - Villa";
            // 
            // chkHasGarage
            // 
            chkHasGarage.AutoSize = true;
            chkHasGarage.Location = new Point(9, 152);
            chkHasGarage.Name = "chkHasGarage";
            chkHasGarage.Size = new Size(99, 20);
            chkHasGarage.TabIndex = 13;
            chkHasGarage.Text = "Has Garage";
            chkHasGarage.UseVisualStyleBackColor = true;
            // 
            // txtGardenArea
            // 
            txtGardenArea.Location = new Point(130, 86);
            txtGardenArea.Name = "txtGardenArea";
            txtGardenArea.Size = new Size(100, 25);
            txtGardenArea.TabIndex = 2;
            // 
            // txtLivingArea
            // 
            txtLivingArea.Location = new Point(130, 55);
            txtLivingArea.Name = "txtLivingArea";
            txtLivingArea.Size = new Size(100, 25);
            txtLivingArea.TabIndex = 1;
            // 
            // txtNumberOfRooms
            // 
            txtNumberOfRooms.Location = new Point(130, 24);
            txtNumberOfRooms.Name = "txtNumberOfRooms";
            txtNumberOfRooms.Size = new Size(100, 25);
            txtNumberOfRooms.TabIndex = 0;
            // 
            // lblRooms
            // 
            lblRooms.AutoSize = true;
            lblRooms.Location = new Point(10, 28);
            lblRooms.Name = "lblRooms";
            lblRooms.Size = new Size(51, 16);
            lblRooms.TabIndex = 17;
            lblRooms.Text = "Rooms";
            // 
            // lblLivingArea
            // 
            lblLivingArea.AutoSize = true;
            lblLivingArea.Location = new Point(9, 57);
            lblLivingArea.Name = "lblLivingArea";
            lblLivingArea.Size = new Size(82, 16);
            lblLivingArea.TabIndex = 18;
            lblLivingArea.Text = "Living Area";
            // 
            // lblGardenArea
            // 
            lblGardenArea.AutoSize = true;
            lblGardenArea.Location = new Point(10, 89);
            lblGardenArea.Name = "lblGardenArea";
            lblGardenArea.Size = new Size(87, 16);
            lblGardenArea.TabIndex = 19;
            lblGardenArea.Text = "Garden Area";
            // 
            // grpShop
            // 
            grpShop.Controls.Add(chkHasStorage);
            grpShop.Controls.Add(lblEntrances);
            grpShop.Controls.Add(txtNumberOfEntrances);
            grpShop.Controls.Add(lblBusinessArea);
            grpShop.Controls.Add(txtBusinessArea);
            grpShop.Controls.Add(lblEmployees);
            grpShop.Controls.Add(txtNumberOfEmployees);
            grpShop.Font = new Font("Mongolian Baiti", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpShop.Location = new Point(12, 264);
            grpShop.Name = "grpShop";
            grpShop.Size = new Size(250, 180);
            grpShop.TabIndex = 10;
            grpShop.TabStop = false;
            grpShop.Text = "Commercial - Shop";
            // 
            // chkHasStorage
            // 
            chkHasStorage.AutoSize = true;
            chkHasStorage.Location = new Point(9, 152);
            chkHasStorage.Name = "chkHasStorage";
            chkHasStorage.Size = new Size(101, 20);
            chkHasStorage.TabIndex = 5;
            chkHasStorage.Text = "Has Storage";
            chkHasStorage.UseVisualStyleBackColor = true;
            // 
            // lblEntrances
            // 
            lblEntrances.AutoSize = true;
            lblEntrances.Location = new Point(9, 90);
            lblEntrances.Name = "lblEntrances";
            lblEntrances.Size = new Size(68, 16);
            lblEntrances.TabIndex = 25;
            lblEntrances.Text = "Entrances";
            // 
            // txtNumberOfEntrances
            // 
            txtNumberOfEntrances.Location = new Point(130, 86);
            txtNumberOfEntrances.Name = "txtNumberOfEntrances";
            txtNumberOfEntrances.Size = new Size(100, 25);
            txtNumberOfEntrances.TabIndex = 2;
            // 
            // lblBusinessArea
            // 
            lblBusinessArea.AutoSize = true;
            lblBusinessArea.Location = new Point(10, 59);
            lblBusinessArea.Name = "lblBusinessArea";
            lblBusinessArea.Size = new Size(92, 16);
            lblBusinessArea.TabIndex = 24;
            lblBusinessArea.Text = "BusinessArea";
            // 
            // txtBusinessArea
            // 
            txtBusinessArea.Location = new Point(130, 55);
            txtBusinessArea.Name = "txtBusinessArea";
            txtBusinessArea.Size = new Size(100, 25);
            txtBusinessArea.TabIndex = 1;
            // 
            // lblEmployees
            // 
            lblEmployees.AutoSize = true;
            lblEmployees.Location = new Point(10, 28);
            lblEmployees.Name = "lblEmployees";
            lblEmployees.Size = new Size(76, 16);
            lblEmployees.TabIndex = 22;
            lblEmployees.Text = "Employees";
            // 
            // txtNumberOfEmployees
            // 
            txtNumberOfEmployees.Location = new Point(130, 24);
            txtNumberOfEmployees.Name = "txtNumberOfEmployees";
            txtNumberOfEmployees.Size = new Size(100, 25);
            txtNumberOfEmployees.TabIndex = 0;
            // 
            // grpSchool
            // 
            grpSchool.Controls.Add(chkHasCafeteria);
            grpSchool.Controls.Add(txtCapacity);
            grpSchool.Controls.Add(txtNumberOfClassrooms);
            grpSchool.Controls.Add(lblClassrooms);
            grpSchool.Controls.Add(txtNumberOfBuildings);
            grpSchool.Controls.Add(lblCapacity);
            grpSchool.Controls.Add(lblBuildings);
            grpSchool.Font = new Font("Mongolian Baiti", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpSchool.Location = new Point(12, 264);
            grpSchool.Name = "grpSchool";
            grpSchool.Size = new Size(250, 180);
            grpSchool.TabIndex = 11;
            grpSchool.TabStop = false;
            grpSchool.Text = "Insitutional - School";
            // 
            // chkHasCafeteria
            // 
            chkHasCafeteria.AutoSize = true;
            chkHasCafeteria.Location = new Point(9, 152);
            chkHasCafeteria.Name = "chkHasCafeteria";
            chkHasCafeteria.Size = new Size(110, 20);
            chkHasCafeteria.TabIndex = 13;
            chkHasCafeteria.Text = "Has Cafeteria";
            chkHasCafeteria.UseVisualStyleBackColor = true;
            // 
            // txtCapacity
            // 
            txtCapacity.Location = new Point(130, 24);
            txtCapacity.Name = "txtCapacity";
            txtCapacity.Size = new Size(100, 25);
            txtCapacity.TabIndex = 3;
            // 
            // txtNumberOfClassrooms
            // 
            txtNumberOfClassrooms.Location = new Point(130, 86);
            txtNumberOfClassrooms.Name = "txtNumberOfClassrooms";
            txtNumberOfClassrooms.Size = new Size(100, 25);
            txtNumberOfClassrooms.TabIndex = 2;
            // 
            // lblClassrooms
            // 
            lblClassrooms.AutoSize = true;
            lblClassrooms.Location = new Point(11, 90);
            lblClassrooms.Name = "lblClassrooms";
            lblClassrooms.Size = new Size(79, 16);
            lblClassrooms.TabIndex = 23;
            lblClassrooms.Text = "Classrooms";
            // 
            // txtNumberOfBuildings
            // 
            txtNumberOfBuildings.Location = new Point(130, 55);
            txtNumberOfBuildings.Name = "txtNumberOfBuildings";
            txtNumberOfBuildings.Size = new Size(100, 25);
            txtNumberOfBuildings.TabIndex = 1;
            // 
            // lblCapacity
            // 
            lblCapacity.AutoSize = true;
            lblCapacity.Location = new Point(11, 27);
            lblCapacity.Name = "lblCapacity";
            lblCapacity.Size = new Size(62, 16);
            lblCapacity.TabIndex = 20;
            lblCapacity.Text = "Capacity";
            // 
            // lblBuildings
            // 
            lblBuildings.AutoSize = true;
            lblBuildings.Location = new Point(11, 58);
            lblBuildings.Name = "lblBuildings";
            lblBuildings.Size = new Size(67, 16);
            lblBuildings.TabIndex = 21;
            lblBuildings.Text = "Buildings";
            // 
            // grpAddress
            // 
            grpAddress.Controls.Add(lblID);
            grpAddress.Controls.Add(cmbCountry);
            grpAddress.Controls.Add(txtID);
            grpAddress.Controls.Add(txtStreet);
            grpAddress.Controls.Add(txtZipCode);
            grpAddress.Controls.Add(txtCity);
            grpAddress.Controls.Add(lblStreet);
            grpAddress.Controls.Add(lblZipCode);
            grpAddress.Controls.Add(lblCountry);
            grpAddress.Controls.Add(lblCity);
            grpAddress.Font = new Font("Mongolian Baiti", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpAddress.Location = new Point(6, 76);
            grpAddress.Name = "grpAddress";
            grpAddress.Size = new Size(272, 182);
            grpAddress.TabIndex = 12;
            grpAddress.TabStop = false;
            grpAddress.Text = "Estate - Address";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(15, 27);
            lblID.Name = "lblID";
            lblID.Size = new Size(108, 16);
            lblID.TabIndex = 13;
            lblID.Text = "ID                    -";
            // 
            // cmbCountry
            // 
            cmbCountry.FormattingEnabled = true;
            cmbCountry.Location = new Point(135, 148);
            cmbCountry.Name = "cmbCountry";
            cmbCountry.Size = new Size(121, 24);
            cmbCountry.TabIndex = 8;
            // 
            // lblStreet
            // 
            lblStreet.AutoSize = true;
            lblStreet.Location = new Point(15, 59);
            lblStreet.Name = "lblStreet";
            lblStreet.Size = new Size(107, 16);
            lblStreet.TabIndex = 13;
            lblStreet.Text = "Street               -";
            // 
            // lblZipCode
            // 
            lblZipCode.AutoSize = true;
            lblZipCode.Location = new Point(15, 90);
            lblZipCode.Name = "lblZipCode";
            lblZipCode.Size = new Size(106, 16);
            lblZipCode.TabIndex = 14;
            lblZipCode.Text = "ZipCode          -";
            // 
            // lblCountry
            // 
            lblCountry.AutoSize = true;
            lblCountry.Location = new Point(16, 152);
            lblCountry.Name = "lblCountry";
            lblCountry.Size = new Size(107, 16);
            lblCountry.TabIndex = 16;
            lblCountry.Text = "Country           -";
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Location = new Point(15, 121);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(106, 16);
            lblCity.TabIndex = 15;
            lblCity.Text = "City                 -";
            // 
            // lblEstatePlanner
            // 
            lblEstatePlanner.AutoSize = true;
            lblEstatePlanner.Font = new Font("Mongolian Baiti", 15.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblEstatePlanner.Location = new Point(12, 9);
            lblEstatePlanner.Name = "lblEstatePlanner";
            lblEstatePlanner.Size = new Size(145, 23);
            lblEstatePlanner.TabIndex = 13;
            lblEstatePlanner.Text = "Estate Planner";
            // 
            // btnDelEstate
            // 
            btnDelEstate.Font = new Font("Mongolian Baiti", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelEstate.Location = new Point(268, 419);
            btnDelEstate.Name = "btnDelEstate";
            btnDelEstate.Size = new Size(103, 23);
            btnDelEstate.TabIndex = 14;
            btnDelEstate.Text = "Remove Estate";
            btnDelEstate.UseVisualStyleBackColor = true;
            btnDelEstate.Click += btnDelEstate_Click;
            // 
            // btnAddEstate
            // 
            btnAddEstate.Font = new Font("Mongolian Baiti", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddEstate.Location = new Point(268, 390);
            btnAddEstate.Name = "btnAddEstate";
            btnAddEstate.Size = new Size(103, 23);
            btnAddEstate.TabIndex = 15;
            btnAddEstate.Text = "Add Estate";
            btnAddEstate.UseVisualStyleBackColor = true;
            btnAddEstate.Click += btnAddEstate_Click;
            // 
            // lstEstates
            // 
            lstEstates.FormattingEnabled = true;
            lstEstates.ItemHeight = 15;
            lstEstates.Location = new Point(432, 35);
            lstEstates.Name = "lstEstates";
            lstEstates.Size = new Size(356, 379);
            lstEstates.TabIndex = 16;
            lstEstates.SelectedIndexChanged += lstEstates_SelectedIndexChanged;
            // 
            // lblEstates
            // 
            lblEstates.AutoSize = true;
            lblEstates.Font = new Font("Mongolian Baiti", 15.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblEstates.Location = new Point(432, 9);
            lblEstates.Name = "lblEstates";
            lblEstates.Size = new Size(76, 23);
            lblEstates.TabIndex = 17;
            lblEstates.Text = "Estates";
            lblEstates.Click += lblEstates_Click;
            // 
            // btnModifyEstate
            // 
            btnModifyEstate.Font = new Font("Mongolian Baiti", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnModifyEstate.Location = new Point(432, 419);
            btnModifyEstate.Name = "btnModifyEstate";
            btnModifyEstate.Size = new Size(114, 23);
            btnModifyEstate.TabIndex = 18;
            btnModifyEstate.Text = "Modify Estate";
            btnModifyEstate.UseVisualStyleBackColor = true;
            btnModifyEstate.Click += btnModifyEstate_Click;
            // 
            // btnApplyChanges
            // 
            btnApplyChanges.Font = new Font("Mongolian Baiti", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnApplyChanges.Location = new Point(552, 419);
            btnApplyChanges.Name = "btnApplyChanges";
            btnApplyChanges.Size = new Size(136, 23);
            btnApplyChanges.TabIndex = 19;
            btnApplyChanges.Text = "Apply Changes";
            btnApplyChanges.UseVisualStyleBackColor = true;
            btnApplyChanges.Click += btnApplyChanges_Click;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Mongolian Baiti", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(694, 419);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 23);
            btnSave.TabIndex = 20;
            btnSave.Text = "Save Data";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSave);
            Controls.Add(btnApplyChanges);
            Controls.Add(btnModifyEstate);
            Controls.Add(lblEstates);
            Controls.Add(lstEstates);
            Controls.Add(btnAddEstate);
            Controls.Add(btnDelEstate);
            Controls.Add(lblEstatePlanner);
            Controls.Add(grpAddress);
            Controls.Add(txtEstateSelected);
            Controls.Add(btnEstateType);
            Controls.Add(grpSchool);
            Controls.Add(grpVilla);
            Controls.Add(grpShop);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            estateCategories.ResumeLayout(false);
            grpVilla.ResumeLayout(false);
            grpVilla.PerformLayout();
            grpShop.ResumeLayout(false);
            grpShop.PerformLayout();
            grpSchool.ResumeLayout(false);
            grpSchool.PerformLayout();
            grpAddress.ResumeLayout(false);
            grpAddress.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ContextMenuStrip estateCategories;
        private ToolStripMenuItem menuResidential;
        private ToolStripMenuItem menuCommercial;
        private ToolStripMenuItem menuInstitutional;
        private ToolStripMenuItem menuVilla;
        private ToolStripMenuItem menuShop;
        private ToolStripMenuItem menuSchool;
        private Button btnEstateType;
        private TextBox txtEstateSelected;
        private TextBox txtCity;
        private TextBox txtZipCode;
        private TextBox txtStreet;
        private TextBox txtID;
        private GroupBox grpVilla;
        private GroupBox grpShop;
        private GroupBox grpSchool;
        private ComboBox comboBox1;
        private TextBox textBox4;
        private TextBox txtGardenArea;
        private TextBox txtLivingArea;
        private TextBox txtNumberOfRooms;
        private GroupBox grpAddress;
        private ComboBox comboBox3;
        private TextBox txtNumberOfEmployees;
        private TextBox txtBusinessArea;
        private TextBox txtNumberOfEntrances;
        private TextBox txtNumberOfClassrooms;
        private TextBox txtCapacity;
        private TextBox textBox10;
        private TextBox textBox9;
        private TextBox txtNumberOfBuildings;
        private CheckBox chkHasGarage;
        private CheckBox chkHasStorage;
        private CheckBox chkHasCafeteria;
        private ComboBox cmbCountry;
        private ComboBox comboBox4;
        private Label lblID;
        private Label lblRooms;
        private Label lblLivingArea;
        private Label lblStreet;
        private Label lblZipCode;
        private Label lblCountry;
        private Label lblCity;
        private Label lblGardenArea;
        private Label lblCapacity;
        private Label lblBuildings;
        private Label lblEmployees;
        private Label lblClassrooms;
        private Label lblBusinessArea;
        private Label lblEntrances;
        private Label lblEstatePlanner;
        private Button btnDelEstate;
        private Button btnAddEstate;
        private ListBox lstEstates;
        private Label lblEstates;
        private Button btnModifyEstate;
        private Button btnApplyChanges;
        private Button btnSave;
    }
}
