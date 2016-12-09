namespace dataSource
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dUADataSet = new dataSource.DUADataSet();
            this.catalogoTransporteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.catalogoTransporteTableAdapter = new dataSource.DUADataSetTableAdapters.catalogoTransporteTableAdapter();
            this.tableAdapterManager = new dataSource.DUADataSetTableAdapters.TableAdapterManager();
            this.catalogoTransporteBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.catalogoTransporteBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.catalogoTransporteDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dUADataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogoTransporteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogoTransporteBindingNavigator)).BeginInit();
            this.catalogoTransporteBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.catalogoTransporteDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dUADataSet
            // 
            this.dUADataSet.DataSetName = "DUADataSet";
            this.dUADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // catalogoTransporteBindingSource
            // 
            this.catalogoTransporteBindingSource.DataMember = "catalogoTransporte";
            this.catalogoTransporteBindingSource.DataSource = this.dUADataSet;
            // 
            // catalogoTransporteTableAdapter
            // 
            this.catalogoTransporteTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.arancelCapitulo2TableAdapter = null;
            this.tableAdapterManager.arancelIncisoCA_8TableAdapter = null;
            this.tableAdapterManager.arancelIncisoCR_10TableAdapter = null;
            this.tableAdapterManager.arancelPartidasTableAdapter = null;
            this.tableAdapterManager.arancelRaices_5TableAdapter = null;
            this.tableAdapterManager.arancelRaices_9TableAdapter = null;
            this.tableAdapterManager.arancelSeccionesTableAdapter = null;
            this.tableAdapterManager.arancelSubPartida_6TableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.boletaTableAdapter = null;
            this.tableAdapterManager.catalogoCondicionEntregaTableAdapter = null;
            this.tableAdapterManager.catalogoduanasTableAdapter = null;
            this.tableAdapterManager.catalogoExogeneracionLiberacionTableAdapter = null;
            this.tableAdapterManager.catalogoModalidadRegimenTableAdapter = null;
            this.tableAdapterManager.catalogoMonedasTableAdapter = null;
            this.tableAdapterManager.catalogoPuertosTableAdapter = null;
            this.tableAdapterManager.catalogoRegimenesTableAdapter = null;
            this.tableAdapterManager.catalogoSeguimientoTableAdapter = null;
            this.tableAdapterManager.catalogoTransporteTableAdapter = this.catalogoTransporteTableAdapter;
            this.tableAdapterManager.catalogoTratadoConvencionalTableAdapter = null;
            this.tableAdapterManager.catalogoUnidadedesTableAdapter = null;
            this.tableAdapterManager.catalogPaisesTableAdapter = null;
            this.tableAdapterManager.cIIU_4TableAdapter = null;
            this.tableAdapterManager.detalleTableAdapter = null;
            this.tableAdapterManager.EmpleadoTableAdapter = null;
            this.tableAdapterManager.ScDUAIniciaDetalleTableAdapter = null;
            this.tableAdapterManager.ScDUAInicialTableAdapter = null;
            this.tableAdapterManager.TipoBultosTableAdapter = null;
            this.tableAdapterManager.tipoDetalleBoletaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = dataSource.DUADataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // catalogoTransporteBindingNavigator
            // 
            this.catalogoTransporteBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.catalogoTransporteBindingNavigator.BindingSource = this.catalogoTransporteBindingSource;
            this.catalogoTransporteBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.catalogoTransporteBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.catalogoTransporteBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.catalogoTransporteBindingNavigatorSaveItem,
            this.toolStripButton1});
            this.catalogoTransporteBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.catalogoTransporteBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.catalogoTransporteBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.catalogoTransporteBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.catalogoTransporteBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.catalogoTransporteBindingNavigator.Name = "catalogoTransporteBindingNavigator";
            this.catalogoTransporteBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.catalogoTransporteBindingNavigator.Size = new System.Drawing.Size(512, 25);
            this.catalogoTransporteBindingNavigator.TabIndex = 0;
            this.catalogoTransporteBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // catalogoTransporteBindingNavigatorSaveItem
            // 
            this.catalogoTransporteBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.catalogoTransporteBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("catalogoTransporteBindingNavigatorSaveItem.Image")));
            this.catalogoTransporteBindingNavigatorSaveItem.Name = "catalogoTransporteBindingNavigatorSaveItem";
            this.catalogoTransporteBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.catalogoTransporteBindingNavigatorSaveItem.Text = "Save Data";
            this.catalogoTransporteBindingNavigatorSaveItem.Click += new System.EventHandler(this.catalogoTransporteBindingNavigatorSaveItem_Click);
            // 
            // catalogoTransporteDataGridView
            // 
            this.catalogoTransporteDataGridView.AutoGenerateColumns = false;
            this.catalogoTransporteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.catalogoTransporteDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.catalogoTransporteDataGridView.DataSource = this.catalogoTransporteBindingSource;
            this.catalogoTransporteDataGridView.Location = new System.Drawing.Point(28, 101);
            this.catalogoTransporteDataGridView.Name = "catalogoTransporteDataGridView";
            this.catalogoTransporteDataGridView.Size = new System.Drawing.Size(414, 220);
            this.catalogoTransporteDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "descripc";
            this.dataGridViewTextBoxColumn2.HeaderText = "descripc";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "descripcion";
            this.dataGridViewTextBoxColumn3.HeaderText = "descripcion";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 373);
            this.Controls.Add(this.catalogoTransporteDataGridView);
            this.Controls.Add(this.catalogoTransporteBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dUADataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogoTransporteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogoTransporteBindingNavigator)).EndInit();
            this.catalogoTransporteBindingNavigator.ResumeLayout(false);
            this.catalogoTransporteBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.catalogoTransporteDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DUADataSet dUADataSet;
        private System.Windows.Forms.BindingSource catalogoTransporteBindingSource;
        private DUADataSetTableAdapters.catalogoTransporteTableAdapter catalogoTransporteTableAdapter;
        private DUADataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator catalogoTransporteBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton catalogoTransporteBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView catalogoTransporteDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}

