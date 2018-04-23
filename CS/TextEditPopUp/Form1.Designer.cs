namespace TEPopUp
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
            this.textEditPopUp1 = new TEPopUp.TextEditPopUp();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEditPopUp1 = new TEPopUp.RepositoryItemTextEditPopUp();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPopUp1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEditPopUp1)).BeginInit();
            this.SuspendLayout();
            // 
            // textEditPopUp1
            // 
            this.textEditPopUp1.DataSource = null;
            this.textEditPopUp1.DisplayMember = null;
            this.textEditPopUp1.Location = new System.Drawing.Point(12, 12);
            this.textEditPopUp1.Name = "textEditPopUp1";
            this.textEditPopUp1.Properties.DataSource = null;
            this.textEditPopUp1.Properties.DisplayMember = null;
            this.textEditPopUp1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.textEditPopUp1.Size = new System.Drawing.Size(260, 20);
            this.textEditPopUp1.TabIndex = 3;
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(13, 39);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEditPopUp1});
            this.gridControl1.Size = new System.Drawing.Size(259, 213);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "gridColumn1";
            this.gridColumn1.ColumnEdit = this.repositoryItemTextEditPopUp1;
            this.gridColumn1.FieldName = "Fruit";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // repositoryItemTextEditPopUp1
            // 
            this.repositoryItemTextEditPopUp1.AutoHeight = false;
            this.repositoryItemTextEditPopUp1.DataSource = null;
            this.repositoryItemTextEditPopUp1.DisplayMember = null;
            this.repositoryItemTextEditPopUp1.Name = "repositoryItemTextEditPopUp1";
            this.repositoryItemTextEditPopUp1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 299);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.textEditPopUp1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textEditPopUp1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEditPopUp1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TextEditPopUp textEditPopUp1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private RepositoryItemTextEditPopUp repositoryItemTextEditPopUp1;
    }
}

