namespace KontroliFormi
{
    partial class Admin
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
            this.btnCloser = new System.Windows.Forms.Button();
            this.lblNaming = new System.Windows.Forms.Label();
            this.lblProducts = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblGifts = new System.Windows.Forms.Label();
            this.btnAdding = new System.Windows.Forms.Button();
            this.btnDeleting = new System.Windows.Forms.Button();
            this.btnSaving = new System.Windows.Forms.Button();
            this.txtNaming = new System.Windows.Forms.TextBox();
            this.txtProducing = new System.Windows.Forms.TextBox();
            this.txtDating = new System.Windows.Forms.TextBox();
            this.txtGifting = new System.Windows.Forms.TextBox();
            this.btnLoading = new System.Windows.Forms.Button();
            this.lblNameSong = new System.Windows.Forms.Label();
            this.txtBoxNameSong = new System.Windows.Forms.TextBox();
            this.txtBoxArtist = new System.Windows.Forms.TextBox();
            this.lblNameArtist = new System.Windows.Forms.Label();
            this.btnClearing = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.daza11DataSet = new KontroliFormi.daza11DataSet();
            this.daza11DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tablicaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tablicaTableAdapter = new KontroliFormi.daza11DataSetTableAdapters.TablicaTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pesenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.godinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vremetraeneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artistDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.daza11DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.daza11DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablicaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCloser
            // 
            this.btnCloser.Location = new System.Drawing.Point(885, 377);
            this.btnCloser.Name = "btnCloser";
            this.btnCloser.Size = new System.Drawing.Size(75, 23);
            this.btnCloser.TabIndex = 0;
            this.btnCloser.Text = "Close";
            this.btnCloser.UseVisualStyleBackColor = true;
            this.btnCloser.Click += new System.EventHandler(this.btnCloser_Click);
            // 
            // lblNaming
            // 
            this.lblNaming.AutoSize = true;
            this.lblNaming.Location = new System.Drawing.Point(9, 12);
            this.lblNaming.Name = "lblNaming";
            this.lblNaming.Size = new System.Drawing.Size(36, 13);
            this.lblNaming.TabIndex = 2;
            this.lblNaming.Text = "Genre";
            // 
            // lblProducts
            // 
            this.lblProducts.AutoSize = true;
            this.lblProducts.Location = new System.Drawing.Point(9, 60);
            this.lblProducts.Name = "lblProducts";
            this.lblProducts.Size = new System.Drawing.Size(37, 13);
            this.lblProducts.TabIndex = 3;
            this.lblProducts.Text = "Pesen";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(9, 99);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(67, 13);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "Vremetraene";
            // 
            // lblGifts
            // 
            this.lblGifts.AutoSize = true;
            this.lblGifts.Location = new System.Drawing.Point(9, 138);
            this.lblGifts.Name = "lblGifts";
            this.lblGifts.Size = new System.Drawing.Size(41, 13);
            this.lblGifts.TabIndex = 5;
            this.lblGifts.Text = "Godina";
            // 
            // btnAdding
            // 
            this.btnAdding.Location = new System.Drawing.Point(12, 300);
            this.btnAdding.Name = "btnAdding";
            this.btnAdding.Size = new System.Drawing.Size(75, 23);
            this.btnAdding.TabIndex = 6;
            this.btnAdding.Text = "Add";
            this.btnAdding.UseVisualStyleBackColor = true;
            this.btnAdding.Click += new System.EventHandler(this.btnAdding_Click);
            // 
            // btnDeleting
            // 
            this.btnDeleting.Location = new System.Drawing.Point(121, 300);
            this.btnDeleting.Name = "btnDeleting";
            this.btnDeleting.Size = new System.Drawing.Size(75, 23);
            this.btnDeleting.TabIndex = 7;
            this.btnDeleting.Text = "Delete";
            this.btnDeleting.UseVisualStyleBackColor = true;
            this.btnDeleting.Click += new System.EventHandler(this.btnDeleting_Click);
            // 
            // btnSaving
            // 
            this.btnSaving.Location = new System.Drawing.Point(12, 338);
            this.btnSaving.Name = "btnSaving";
            this.btnSaving.Size = new System.Drawing.Size(75, 23);
            this.btnSaving.TabIndex = 8;
            this.btnSaving.Text = "Save";
            this.btnSaving.UseVisualStyleBackColor = true;
            this.btnSaving.Click += new System.EventHandler(this.btnSaving_Click);
            // 
            // txtNaming
            // 
            this.txtNaming.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tablicaBindingSource, "Genre", true));
            this.txtNaming.Location = new System.Drawing.Point(12, 28);
            this.txtNaming.Name = "txtNaming";
            this.txtNaming.Size = new System.Drawing.Size(184, 20);
            this.txtNaming.TabIndex = 9;
            // 
            // txtProducing
            // 
            this.txtProducing.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tablicaBindingSource, "Pesen", true));
            this.txtProducing.Location = new System.Drawing.Point(12, 76);
            this.txtProducing.Name = "txtProducing";
            this.txtProducing.Size = new System.Drawing.Size(184, 20);
            this.txtProducing.TabIndex = 10;
            // 
            // txtDating
            // 
            this.txtDating.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tablicaBindingSource, "Vremetraene", true));
            this.txtDating.Location = new System.Drawing.Point(12, 115);
            this.txtDating.Name = "txtDating";
            this.txtDating.Size = new System.Drawing.Size(184, 20);
            this.txtDating.TabIndex = 11;
            // 
            // txtGifting
            // 
            this.txtGifting.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tablicaBindingSource, "Godina", true));
            this.txtGifting.Location = new System.Drawing.Point(12, 154);
            this.txtGifting.Name = "txtGifting";
            this.txtGifting.Size = new System.Drawing.Size(184, 20);
            this.txtGifting.TabIndex = 12;
            // 
            // btnLoading
            // 
            this.btnLoading.Location = new System.Drawing.Point(121, 338);
            this.btnLoading.Name = "btnLoading";
            this.btnLoading.Size = new System.Drawing.Size(75, 23);
            this.btnLoading.TabIndex = 13;
            this.btnLoading.Text = "Load";
            this.btnLoading.UseVisualStyleBackColor = true;
            // 
            // lblNameSong
            // 
            this.lblNameSong.AutoSize = true;
            this.lblNameSong.Location = new System.Drawing.Point(9, 177);
            this.lblNameSong.Name = "lblNameSong";
            this.lblNameSong.Size = new System.Drawing.Size(24, 13);
            this.lblNameSong.TabIndex = 14;
            this.lblNameSong.Text = "Ime";
            // 
            // txtBoxNameSong
            // 
            this.txtBoxNameSong.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tablicaBindingSource, "Ime", true));
            this.txtBoxNameSong.Location = new System.Drawing.Point(13, 194);
            this.txtBoxNameSong.Name = "txtBoxNameSong";
            this.txtBoxNameSong.Size = new System.Drawing.Size(183, 20);
            this.txtBoxNameSong.TabIndex = 15;
            // 
            // txtBoxArtist
            // 
            this.txtBoxArtist.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tablicaBindingSource, "Artist", true));
            this.txtBoxArtist.Location = new System.Drawing.Point(12, 233);
            this.txtBoxArtist.Name = "txtBoxArtist";
            this.txtBoxArtist.Size = new System.Drawing.Size(184, 20);
            this.txtBoxArtist.TabIndex = 16;
            // 
            // lblNameArtist
            // 
            this.lblNameArtist.AutoSize = true;
            this.lblNameArtist.Location = new System.Drawing.Point(9, 217);
            this.lblNameArtist.Name = "lblNameArtist";
            this.lblNameArtist.Size = new System.Drawing.Size(30, 13);
            this.lblNameArtist.TabIndex = 17;
            this.lblNameArtist.Text = "Artist";
            // 
            // btnClearing
            // 
            this.btnClearing.Location = new System.Drawing.Point(12, 377);
            this.btnClearing.Name = "btnClearing";
            this.btnClearing.Size = new System.Drawing.Size(75, 23);
            this.btnClearing.TabIndex = 18;
            this.btnClearing.Text = "Clear";
            this.btnClearing.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.imeDataGridViewTextBoxColumn,
            this.pesenDataGridViewTextBoxColumn,
            this.genreDataGridViewTextBoxColumn,
            this.godinaDataGridViewTextBoxColumn,
            this.vremetraeneDataGridViewTextBoxColumn,
            this.artistDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tablicaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(222, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(738, 333);
            this.dataGridView1.TabIndex = 19;
            // 
            // daza11DataSet
            // 
            this.daza11DataSet.DataSetName = "daza11DataSet";
            this.daza11DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // daza11DataSetBindingSource
            // 
            this.daza11DataSetBindingSource.DataSource = this.daza11DataSet;
            this.daza11DataSetBindingSource.Position = 0;
            // 
            // tablicaBindingSource
            // 
            this.tablicaBindingSource.DataMember = "Tablica";
            this.tablicaBindingSource.DataSource = this.daza11DataSetBindingSource;
            // 
            // tablicaTableAdapter
            // 
            this.tablicaTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // imeDataGridViewTextBoxColumn
            // 
            this.imeDataGridViewTextBoxColumn.DataPropertyName = "Ime";
            this.imeDataGridViewTextBoxColumn.HeaderText = "Ime";
            this.imeDataGridViewTextBoxColumn.Name = "imeDataGridViewTextBoxColumn";
            // 
            // pesenDataGridViewTextBoxColumn
            // 
            this.pesenDataGridViewTextBoxColumn.DataPropertyName = "Pesen";
            this.pesenDataGridViewTextBoxColumn.HeaderText = "Pesen";
            this.pesenDataGridViewTextBoxColumn.Name = "pesenDataGridViewTextBoxColumn";
            // 
            // genreDataGridViewTextBoxColumn
            // 
            this.genreDataGridViewTextBoxColumn.DataPropertyName = "Genre";
            this.genreDataGridViewTextBoxColumn.HeaderText = "Genre";
            this.genreDataGridViewTextBoxColumn.Name = "genreDataGridViewTextBoxColumn";
            // 
            // godinaDataGridViewTextBoxColumn
            // 
            this.godinaDataGridViewTextBoxColumn.DataPropertyName = "Godina";
            this.godinaDataGridViewTextBoxColumn.HeaderText = "Godina";
            this.godinaDataGridViewTextBoxColumn.Name = "godinaDataGridViewTextBoxColumn";
            // 
            // vremetraeneDataGridViewTextBoxColumn
            // 
            this.vremetraeneDataGridViewTextBoxColumn.DataPropertyName = "Vremetraene";
            this.vremetraeneDataGridViewTextBoxColumn.HeaderText = "Vremetraene";
            this.vremetraeneDataGridViewTextBoxColumn.Name = "vremetraeneDataGridViewTextBoxColumn";
            // 
            // artistDataGridViewTextBoxColumn
            // 
            this.artistDataGridViewTextBoxColumn.DataPropertyName = "Artist";
            this.artistDataGridViewTextBoxColumn.HeaderText = "Artist";
            this.artistDataGridViewTextBoxColumn.Name = "artistDataGridViewTextBoxColumn";
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 412);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnClearing);
            this.Controls.Add(this.lblNameArtist);
            this.Controls.Add(this.txtBoxArtist);
            this.Controls.Add(this.txtBoxNameSong);
            this.Controls.Add(this.lblNameSong);
            this.Controls.Add(this.btnLoading);
            this.Controls.Add(this.txtGifting);
            this.Controls.Add(this.txtDating);
            this.Controls.Add(this.txtProducing);
            this.Controls.Add(this.txtNaming);
            this.Controls.Add(this.btnSaving);
            this.Controls.Add(this.btnDeleting);
            this.Controls.Add(this.btnAdding);
            this.Controls.Add(this.lblGifts);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblProducts);
            this.Controls.Add(this.lblNaming);
            this.Controls.Add(this.btnCloser);
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.daza11DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.daza11DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablicaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCloser;
        private System.Windows.Forms.Label lblNaming;
        private System.Windows.Forms.Label lblProducts;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblGifts;
        private System.Windows.Forms.Button btnAdding;
        private System.Windows.Forms.Button btnDeleting;
        private System.Windows.Forms.Button btnSaving;
        private System.Windows.Forms.TextBox txtNaming;
        private System.Windows.Forms.TextBox txtProducing;
        private System.Windows.Forms.TextBox txtDating;
        private System.Windows.Forms.TextBox txtGifting;
        private System.Windows.Forms.Button btnLoading;
        private System.Windows.Forms.Label lblNameSong;
        private System.Windows.Forms.TextBox txtBoxNameSong;
        private System.Windows.Forms.TextBox txtBoxArtist;
        private System.Windows.Forms.Label lblNameArtist;
        private System.Windows.Forms.Button btnClearing;
        private System.Windows.Forms.DataGridView dataGridView1;
        private daza11DataSet daza11DataSet;
        private System.Windows.Forms.BindingSource daza11DataSetBindingSource;
        private System.Windows.Forms.BindingSource tablicaBindingSource;
        private daza11DataSetTableAdapters.TablicaTableAdapter tablicaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pesenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn godinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vremetraeneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn artistDataGridViewTextBoxColumn;
    }
}